using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpintoJaksotApp
{
    public class Opiskelija
    {
        public string Nimi { get; }
        private List<Opintojakso> Opintojaksot { get; } = new List<Opintojakso>();

        public Opiskelija(string nimi)
        {
            Nimi = nimi;
        }

        public void LisääOpintojakso(Opintojakso opintojakso)
        {
            Opintojaksot.Add(opintojakso);
        }

        public override string ToString()
        {
            string opintojaksotStr = Opintojaksot.Count > 0
                ? string.Join("\n", Opintojaksot)
                : "Ei opintojaksoja";

            return $"Opiskelija: {Nimi}\n{opintojaksotStr}";
        }
    }
}
