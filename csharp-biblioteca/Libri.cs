using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libri : Documento
    {
        public int Pagine { get; set; }

        public Libri(string titolo, int anno, string settore, char scaffale, string autore, int pagine) : base(titolo, anno, settore, scaffale, autore)
        {
            this.Pagine = pagine;
        }

    }
}
