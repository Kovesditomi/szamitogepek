using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szamitogepek
{
    internal class Szamitogep
    {
        public int Azonosito { get; set; }
        public string ProcesszorTipus { get; set; }
        public int Sebesseg { get; set; }
        public string  Memoria{ get; set; }

        public string Oprendszer { get; set; }
        public string Gyartomodell { get; set; }
        public double  Kijelzomeret { get; set; }

        public double memoria() => double.Parse(Memoria.Split(" ").ToList()[0]);

        public Szamitogep(string s)
        {
            string[] v = s.Split('|');
            Azonosito= int.Parse(v[0]);
            ProcesszorTipus = v[1];
            Sebesseg= int.Parse(v[2]);
            Memoria = v[3];
            Oprendszer = v[4];
            Gyartomodell= v[5];
            Kijelzomeret = double.Parse(v[6]);
        }


        public override string ToString()
        {
            return $"Azonosító:{Azonosito}," +
                $"Processzor típusa:{ProcesszorTipus}" +
                $"Sebesség:{Sebesseg}" +
                $"Memória:{Memoria}" +
                $"Operácioós rendszer: {Oprendszer}" +
                $"Gyártó,modell:{Gyartomodell}" +
                $"kijelzőméret:{Kijelzomeret} ";
        }

    }

}
