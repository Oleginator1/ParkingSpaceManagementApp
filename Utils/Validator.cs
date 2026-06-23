using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareParcari.Utils
{
    internal static class Validator
    {
        public static bool TextObligatoriu(string text, string numeCamp, out string mesaj)
        {
            mesaj = "";
            if (string.IsNullOrWhiteSpace(text))
            {
                mesaj = $"Campul {numeCamp} este obligatoriu";
                return false;
            }

            return true;
        }

        public static bool NumarDecimalPozitiv(string text, string numeCamp, out decimal nr, out string mesaj)
        {
            mesaj = "";
            nr = 0;
            if (string.IsNullOrWhiteSpace(text))
            {
                mesaj = $"Campul {numeCamp} este obligatoriu";
                return false;
            }

            if (!decimal.TryParse(text, out nr))
            {
                mesaj = $"Campul {numeCamp} trebuie sa fie un numar decimal";
                return false;
            }

            if (nr < 0)
            {
                mesaj = $"Campul {numeCamp} trebuie sa fie un numar pozitiv";
                return false;
            }
            return true;
        }

        public static bool NumarIntPozitiv(string text, string numeCamp, out int nr, out string mesaj)
        {
            mesaj = "";
            nr = 0;
            if (string.IsNullOrWhiteSpace(text))
            {
                mesaj = $"Campul {numeCamp} este obligatoriu";
                return false;
            }

            if (!int.TryParse(text, out nr))
            {
                mesaj = $"Campul {numeCamp} trebuie sa fie un numar intreg";
                return false;
            }

            if (nr < 0)
            {
                mesaj = $"Campul {numeCamp} trebuie sa fie un numar pozitiv";
                return false;
            }
            return true;
        }
    }
}
