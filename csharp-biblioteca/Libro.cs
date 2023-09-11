using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documento
    {
        public int Pagine { get; private set; }

        public Libro(string titolo, int anno, string settore, char scaffale, string autore, int pagine) : base(titolo, anno, settore, scaffale, autore)
        {
            if(pagine > 0)
            {
                this.Pagine = pagine;
            }
        }

    }
}
