using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareParcari.Models
{
    internal class Parcare
    {
        public int IdParcare {  get; set; }
        public string Zona { get; set; }
        public int NumarLocuri { get; set; }
        public decimal PretLunar { get; set; }
        public string Tip {  get; set; }

        public override string ToString()
        {
            return Zona + " (" + Tip + ") - " + PretLunar.ToString("N2") + " lei/lună";
        }
    }
}
