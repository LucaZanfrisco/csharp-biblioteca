using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Documento
    {
        public int Durata {  get; set; }
        public Dvd(string titolo, int anno, string settore, char scaffale, string autore, int durata) : base(titolo, anno, settore, scaffale, autore)
        {
            if(durata > 0)
            {
                this.Durata = durata;
            }
        }
    }
}
