using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareParcari.Models
{
    internal class Abonament
    {
        public int IdAbonament {  get; set; }
        public int IdVehicul { get; set; }
        public int IdParcare { get; set; }
        public DateTime DataIncepere { get; set; }
        public int LuniAchitate { get; set; }
        public string NumarInmatriculare { get; set; }
        public string MarcaModel { get; set;}        
        public string Proprietar { get; set; }
        public string Zona { get; set; }
        public string Tip { get; set; }
        public decimal PretLunar { get; set; }
        public DateTime DataSfarsit
        {
            get {  return DataIncepere.AddMonths(LuniAchitate); }
        }

        public decimal SumaTotala
        {
            get { return PretLunar * LuniAchitate; }
        }

        public bool EsteActiv
        {
            get {return DateTime.Now >= DataIncepere && DateTime.Now <= DataSfarsit; }
        }

        public string Status
        {
            get
            {
                if (DateTime.Now < DataIncepere) return "Viitor";
                if (DateTime.Now > DataSfarsit) return "Expirat";
                return "Activ";
            }
        }

    }
}
