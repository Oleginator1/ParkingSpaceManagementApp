using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareParcari.Models
{
    internal class Vehicul
    {
        public int IdVehicul { get; set; }
        public string NumarInmatriculare { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public string Proprietar { get; set; }

        public override string ToString()
        {
            return NumarInmatriculare + " — " + Marca + " " + Model;
        }
    }
}
