using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening
{
    internal class TeDoen
    {
        private int id;
        private static int count = 0; 
        private DateTime tijdStip;
        private string[] Informatie;
        private string Titel;

        public TeDoen(string titel, string[] Informatie, DateTime tijdStip)
        {
            this.Titel = titel;
            this.Informatie = Informatie;   
            this.tijdStip = tijdStip;
            count++; 
            id = count;
        }

        public string ToString()
        {
            return (id + ", " + Titel + " " + String.Join(", ", Informatie) + " " + tijdStip == null? " dringend ": " niet dringend "); 
        }

    }
}
