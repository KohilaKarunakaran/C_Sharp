using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpintoJaksotApp
{
        public class Opettaja
        {
            public string Nimi { get; }

            public Opettaja(string nimi)
            {
                Nimi = nimi;
            }

            public override string ToString()
            {
                return Nimi;
            }
        }
}
