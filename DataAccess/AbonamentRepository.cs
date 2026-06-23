using GestionareParcari.Models;
using GestionareParcari.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace GestionareParcari.DataAccess
{
    internal static class AbonamentRepository
    {
        public static List<Abonament> GetAll()
        {
            var list = new List<Abonament>();
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT a.IdAbonament, a.IdVehicul, a.IdParcare, a.DataIncepere, a.LuniAchitate, v.NumarInmatriculare," +
                "v.Marca + ' ' + v.Model AS MarcaModel, v.Proprietar, p.Zona as ZonaParcare, p.Tip as TipParcare, p.PretLunar FROM Abonament a " +
                "INNER JOIN Vehicul v ON a.Idvehicul = v.IdVehicul " +
                "INNER JOIN Parcare p ON a.IdParcare = p.IdParcare " +
                "ORDER BY a.DataIncepere DESC");
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(MapAbonament(dr));
            }
            return list;

        }

        public static Abonament GetById(int id)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT a.IdAbonament, a.IdVehicul, a.IdParcare, a.DataIncepere, a.LuniAchitate, v.NumarInmatriculare," +
                "v.Marca + ' ' + v.Model AS MarcaModel, v.Proprietar, p.Zona as ZonaParcare, p.Tip as TipParcare, p.PretLunar FROM Abonament a " +
                "INNER JOIN Vehicul v ON a.Idvehicul = v.IdVehicul " +
                "INNER JOIN Parcare p ON a.IdParcare = p.IdParcare " +
                "WHERE a.IdAbonament = @i" ,
                new SqlParameter("@i", id));
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return MapAbonament(dt.Rows[0]);
        }

        public static List<Abonament> GetByVehicul(int id)
        {
            var list = new List<Abonament>();
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT a.IdAbonament, a.IdVehicul, a.IdParcare, a.DataIncepere, a.LuniAchitate, v.NumarInmatriculare, " +
                "v.Marca + ' ' + v.Model AS MarcaModel, v.Proprietar, p.Zona as ZonaParcare, p.Tip as TipParcare, p.PretLunar FROM Abonament a " +
                "INNER JOIN Vehicul v ON a.Idvehicul = v.IdVehicul " +
                "INNER JOIN Parcare p ON a.IdParcare = p.IdParcare " +
                "WHERE a.IdVehicul = @i " +
                "ORDER BY a.DataIncepere DESC",
                new SqlParameter("@i", id));
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(MapAbonament(dr));
            }
            return list;
        }

        public static bool ExistaSuprapunere(int idVehicul, DateTime dataInceperii, int luniAchitate, int? idAbonamentExclus)
        {
            DateTime dataSfarsitNou = dataInceperii.AddMonths(luniAchitate);

            string query = "SELECT COUNT(*) FROM Abonament WHERE IdVehicul = @iv AND ((@dInceput < DATEADD(MONTH, LuniAchitate, DataIncepere) AND @dSfarsit > DataIncepere))";
            if (idAbonamentExclus.HasValue)
            {
                query += " AND IdAbonament <> @idExclus";
            }

            var parametri = new List<SqlParameter>
            {
                new SqlParameter("@iv", idVehicul),
                new SqlParameter("@dInceput", dataInceperii),
                new SqlParameter("@dSfarsit", dataSfarsitNou),
            };

            if(idAbonamentExclus.HasValue) parametri.Add(new SqlParameter("@idExclus", idAbonamentExclus.Value));

            object rez = DatabaseHelper.ExecuteScalar(query, parametri.ToArray());
            return Convert.ToInt32(rez) > 0;
        }

        public static int Create(Abonament a)
        {
            return DatabaseHelper.ExecuteNonQuery("INSERT INTO Abonament (IdVehicul, IdParcare, DataIncepere, LuniAchitate) VALUES (@iv, @ip, @d, @l);",
                new SqlParameter("@iv", a.IdVehicul),
                new SqlParameter("@ip", a.IdParcare),
                new SqlParameter("@d", a.DataIncepere),
                new SqlParameter("@l", a.LuniAchitate));
        }
        public static int Update(Abonament a)
        {
            return DatabaseHelper.ExecuteNonQuery("UPDATE Abonament SET IdVehicul = @iv, IdParcare = @ip, DataIncepere = @d, LuniAchitate = @l WHERE IdAbonament = @ia;",
                new SqlParameter("@iv", a.IdVehicul),
                new SqlParameter("@ip", a.IdParcare),
                new SqlParameter("@d", a.DataIncepere),
                new SqlParameter("@l", a.LuniAchitate),
                new SqlParameter("@ia", a.IdAbonament));
        }

        public static int Delete(int id)
        {
            return DatabaseHelper.ExecuteNonQuery("DELETE FROM Abonament WHERE IdAbonament = @ia", new SqlParameter("@ia", id));
        }

        private static Abonament MapAbonament(DataRow dr)
        {
            return new Abonament
            {
                IdAbonament = Convert.ToInt32(dr["IdAbonament"]),
                IdVehicul = Convert.ToInt32(dr["IdVehicul"]),
                IdParcare = Convert.ToInt32(dr["IdParcare"]),
                DataIncepere = Convert.ToDateTime(dr["DataIncepere"]),
                LuniAchitate = Convert.ToInt32(dr["LuniAchitate"]),
                NumarInmatriculare = dr["NumarInmatriculare"].ToString(),
                MarcaModel = dr["MarcaModel"].ToString(),
                Proprietar = dr["Proprietar"].ToString(),
                Zona = dr["ZonaParcare"].ToString(),
                Tip = dr["TipParcare"].ToString(),
                PretLunar = Convert.ToDecimal(dr["PretLunar"])
            };
        }
    }
}
