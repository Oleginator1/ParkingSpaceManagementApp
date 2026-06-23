using GestionareParcari.Models;
using GestionareParcari.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareParcari.DataAccess
{
    public class VehiculRaport
    {
        public string NumarInmatriculare { get; set; }
        public string MarcaModel { get; set; }
        public string Proprietar {  get; set; }
        public int NumarAbonamente { get; set; }
        public decimal SumaAchitata { get; set; }
    }

    internal static class RaportRepository
    {
        public static List<VehiculRaport> GetVehiculCuTotaluri()
        {
            var lista = new List<VehiculRaport>();
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT v.NumarInmatriculare, v.Marca + '' + v.Model as MarcaModel, v.Proprietar, COUNT(a.IdAbonament) as NrAbonamente, " +
                "ISNULL(SUM(a.LuniAchitate * p.PretLunar), 0) as SumaAchitata FROM Vehicul v " +
                "LEFT JOIN Abonament a ON v.IdVehicul = a.IdVehicul " +
                "LEFT JOIN Parcare p ON a.IdParcare = p.IdParcare " +
                "GROUP BY v.NumarInmatriculare, v.Marca, v.Model, v.Proprietar " +
                "ORDER BY SumaAchitata DESC");
            foreach (DataRow dr in dt.Rows)
            {
                lista.Add(new VehiculRaport
                {
                    NumarInmatriculare = dr["NumarInmatriculare"].ToString(),
                    MarcaModel = dr["MarcaModel"].ToString(),
                    Proprietar = dr["Proprietar"].ToString(),
                    NumarAbonamente = Convert.ToInt32(dr["NrAbonamente"]),
                    SumaAchitata = Convert.ToDecimal(dr["SumaAchitata"])
                });
            }
            return lista;
        }

        public static decimal GetSumaTotalIncasata()
        {
            object rez = DatabaseHelper.ExecuteScalar("SELECT ISNULL(SUM(a.LuniAchitate * p.PretLunar), 0) FROM Abonament a " +
                "INNER JOIN Parcare p ON a.IdParcare = p.IdParcare");
            return Convert.ToDecimal(rez);
        }

        public static decimal GetMediaPlatilor()
        {
            object rez = DatabaseHelper.ExecuteScalar("SELECT ISNULL(AVG(a.LuniAchitate * p.PretLunar) ,0) FROM Abonament a " +
                "INNER JOIN Parcare p ON a.IdParcare = p.IdParcare");
            return Convert.ToDecimal(rez);
        }

        public static string GetParcariCuCeleMaiMulteAbonamente()
        {
            object rez = DatabaseHelper.ExecuteScalar("SELECT TOP 1 p.Zona + ' (' + p.Tip + ')' FROM Abonament a " +
                "INNER JOIN Parcare p ON a.IdParcare = p.IdParcare " +
                "GROUP BY p.Zona, p.Tip " +
                "ORDER BY COUNT (a.IdAbonament) DESC");
            return rez == null ? "-" : rez.ToString();
        }

        public static int GetNumarTotalAbonamente()
        {
            object rez = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Abonament");
            return Convert.ToInt32(rez);
        }

        public static int GetNumarAbonamenteActive()
        {
            object rez = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Abonament " +
                "WHERE GETDATE() >= DataIncepere AND GETDATE() <= DATEADD(MONTH, LuniAchitate, DataIncepere)");
            return Convert.ToInt32(rez);
        }
    }
}
