using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpintoJaksotApp
{
    public class Opintojakso
    {
        public string Nimi { get; }
        private List<Opettaja> Opettajat { get; } = new List<Opettaja>();

        public Opintojakso(string nimi)
        {
            Nimi = nimi;
        }

        public void LisääOpettaja(Opettaja opettaja)
        {
            Opettajat.Add(opettaja);
        }

        public override string ToString()
        {
            string opettajatStr = Opettajat.Count > 0
                ? string.Join(", ", Opettajat)
                : "Ei opettajia";

            return $"Opintojakso: {Nimi}, Opettaja(t): {opettajatStr}";
        }
    }
}
