using GestionareParcari.Models;
using GestionareParcari.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GestionareParcari.DataAccess
{
    internal static class VehiculRepository
    {
        public static List<Vehicul> GetAll()
        {
            List<Vehicul> v = new List<Vehicul>();
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT IdVehicul, NumarInmatriculare, Marca, Model, Proprietar FROM Vehicul ORDER BY Model, Marca");
            foreach (DataRow dr in dt.Rows)
            {
                v.Add(MapVehicul(dr));
            }
            return v;
        }

        public static Vehicul GetById(int id)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT IdVehicul, NumarInmatriculare, Marca, Model, Proprietar FROM Vehicul WHERE IdVehicul = @Id", 
                new SqlParameter("@Id", id));

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return MapVehicul(dt.Rows[0]);
        }

        public static List<Vehicul> Search(string nrM, string proprietar)
        {
            List<Vehicul> v = new List<Vehicul>();
            DataTable dt = DatabaseHelper.ExecuteQuery(@"SELECT IdVehicul, NumarInmatriculare, Marca, Model, Proprietar FROM Vehicul
                WHERE NumarInmatriculare Like @n AND Proprietar LIKE @p",
                new SqlParameter("@n", "%" + (nrM ?? "") + "%"),
                new SqlParameter("@p", "%" + (proprietar ?? "") + "%"));
            foreach (DataRow dr in dt.Rows)
            {
                v.Add(MapVehicul(dr));
            }
            return v;
        }

        public static int Create(Vehicul v)
        {
            return DatabaseHelper.ExecuteNonQuery("INSERT INTO Vehicul (NumarInmatriculare, Marca, Model, Proprietar) VALUES (@n, @m, @mo, @p);",
                new SqlParameter("@n", v.NumarInmatriculare),
                new SqlParameter("@m", v.Marca),
                new SqlParameter("@mo", v.Model),
                new SqlParameter("@p", v.Proprietar));
        }


        public static int Update(Vehicul v)
        {
            return DatabaseHelper.ExecuteNonQuery("UPDATE Vehicul SET NumarInmatriculare = @n, Marca = @m, Model = @mo, Proprietar = @p WHERE IdVehicul = @id",
                new SqlParameter("@n", v.NumarInmatriculare),
                new SqlParameter("@m", v.Marca),
                new SqlParameter("@mo", v.Model),
                new SqlParameter("@p", v.Proprietar),
                new SqlParameter("@id", v.IdVehicul));
        }

        public static int Delete(int id)
        {
            return DatabaseHelper.ExecuteNonQuery("DELETE FROM Vehicul WHERE IdVehicul = @id", new SqlParameter("@id", id));
        }

        private static Vehicul MapVehicul(DataRow dr)
        {
            return new Vehicul
            {
                IdVehicul = Convert.ToInt32(dr["IdVehicul"]),
                NumarInmatriculare = dr["NumarInmatriculare"].ToString(),
                Marca = dr["Marca"].ToString(),
                Model = dr["Model"].ToString(),
                Proprietar = dr["Proprietar"].ToString()
            };
        }

    }
}
