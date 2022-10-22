using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oefening
{
    internal class FouteRij<T>
    {
        private List<T> rij = new List<T>();
        private T huidige;


        public T InRijToevoegen(T element)
        {
            rij.Add(element);
            if (this.rij.Count == 1)
            {
                huidige = element;
            }
            return huidige;
        }

        public T UitRijVerwijderen()
        {
            rij.Remove(huidige);
            if (rij.Count > 0) {
                huidige = rij[0];
            } else
            {
                huidige = default(T);
            }
            return huidige;
        }

        public T ToonVolgende()
        {
            //[rij.Count - 1];
            // FindIndex plaats van element
            // IndexOf idem 
            if (rij.Count > 0) {
                int rijNR = rij.IndexOf(huidige);
                if (rijNR == rij.Count - 1)
                {
                    huidige = rij[0];
                } else
                {
                    huidige = rij[rijNR + 1];
                }
            }
            return huidige;
        }

        public void RijLeegmaken()
        {
            rij.Clear();
            huidige = default(T);
        }

        public T ZetAchteraanInRij()
        {
            if (rij.Count > 0)
            {
                rij.Remove(huidige);
                rij.Add(huidige);
                huidige = rij[0];
            }
            return huidige;
        }

        public string ToString()
        {
            return String.Join("\n", rij.ToArray());
        }

        public bool IsLeeg()
        {
            return rij.Count == 0;
        }

        public int Count()
        {
            return rij.Count;
        }

        public T HuidigElement()
        {
            return huidige; 
        }
    }
}
