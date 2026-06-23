using GestionareParcari.Models;
using GestionareParcari.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Security.Policy;


namespace GestionareParcari.DataAccess
{
    internal static class ParcareRepository
    {
        public static List<Parcare> GetAll()
        {
            List<Parcare> parcare = new List<Parcare>();
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT IdParcare, Zona, NumarLocuri, PretLunar, Tip FROM Parcare ORDER BY NumarLocuri");
            foreach (DataRow dr in dt.Rows)
            {
                parcare.Add(MapParcare(dr));
            }

            return parcare;
        }

        public static Parcare GetById(int id)
        {            
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT IdParcare, Zona, NumarLocuri, PretLunar, Tip FROM Parcare WHERE IdParcare = @i ORDER BY NumarLocuri",
                new SqlParameter("@i", id));
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return MapParcare(dt.Rows[0]);
        }

        public static List<string> GetZona()
        {
            List<string> zone = new List<string>();
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT DISTINCT Zona FROM Parcare ORDER BY Zona");
            foreach (DataRow dr in dt.Rows)
            {
                zone.Add(dr["Zona"].ToString());
            }
            return zone;
        }

        public static List<Parcare> GetByZona(string zona)
        {
            List<Parcare> p = new List<Parcare>();
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT IdParcare, Zona, NumarLocuri, PretLunar, Tip FROM Parcare WHERE Zona = @z ORDER BY NumarLocuri",
                new SqlParameter("@z", zona));
            foreach (DataRow dr in dt.Rows)
            {
                p.Add(MapParcare(dr));
            }
            return p;
        }

        public static List<string> GetTip()
        {
            List<string> tipuri = new List<string>();
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT DISTINCT Tip FROM Parcare ORDER BY Tip");
            foreach (DataRow dr in dt.Rows)
            {
                tipuri.Add(dr["Tip"].ToString());
            }
            return tipuri;
        }

        public static List<Parcare> GetByTip(string tip)
        {
            List<Parcare> p = new List<Parcare>();
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT IdParcare, Zona, NumarLocuri, PretLunar, Tip FROM Parcare WHERE Tip = @t ORDER BY NumarLocuri",
                new SqlParameter("@t", tip));
            foreach (DataRow dr in dt.Rows)
            {
                p.Add(MapParcare(dr));
            }
            return p;
        }



        public static int Create(Parcare parcare)
        {
            return DatabaseHelper.ExecuteNonQuery("INSERT INTO Parcare (Zona, NumarLocuri, PretLunar, Tip) VALUES (@z, @n, @p, @t)",
                new SqlParameter("@z", parcare.Zona),
                new SqlParameter("@n", parcare.NumarLocuri),
                new SqlParameter("@p", parcare.PretLunar),
                new SqlParameter("@t", parcare.Tip));
        }

        public static int Update(Parcare p)
        {
            return DatabaseHelper.ExecuteNonQuery("UPDATE Parcare SET Zona = @z, NumarLocuri = @n, PretLunar = @p, Tip = @t WHERE IdParcare = @i",
                new SqlParameter("@z", p.Zona),
                new SqlParameter("@n", p.NumarLocuri),
                new SqlParameter("@p", p.PretLunar),
                new SqlParameter("@t", p.Tip),
                new SqlParameter("@i", p.IdParcare)
                );
        }

        public static int Delete(int id)
        {
            return DatabaseHelper.ExecuteNonQuery("DELETE FROM Parcare WHERE IdParcare = @i", new SqlParameter("@i", id));
        }

        private static Parcare MapParcare(DataRow dr)
        {
            return new Parcare
            {
                IdParcare = Convert.ToInt32(dr["IdParcare"]),
                Zona  = dr["Zona"].ToString(),
                NumarLocuri = Convert.ToInt32(dr["NumarLocuri"]),
                PretLunar = Convert.ToDecimal(dr["PretLunar"]),
                Tip = dr["Tip"].ToString()
            };
        }
    }
}
