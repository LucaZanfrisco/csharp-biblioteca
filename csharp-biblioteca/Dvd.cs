using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Documento
    {
        public int Durata {  get; private set; }
        public Dvd(string titolo, int anno, string settore, string scaffale, string autore, int durata) : base(titolo, anno, settore, scaffale, autore)
        {
            if(durata > 0)
            {
                this.Durata = durata;
            }
        }
        public override void StampaDocumento()
        {
            base.StampaDocumento();
            Console.WriteLine($"Durata: {this.Durata} min");
        }
    }
}
