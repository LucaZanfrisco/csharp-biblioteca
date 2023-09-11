using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documento
    {
        private string codice;
        public string Titolo {  get; private set; }
        public int Anno { get; private set; }
        public string Settore { get; private set; }
        public char Scaffale { get; set; }
        public string Autore { get; private set; }

        public Documento(string titolo, int anno, string settore, char scaffale, string autore)
        {
            SetCodice();
            this.Titolo = titolo;
            this.Anno = anno;
            this.Settore = settore;
            this.Scaffale = scaffale;
            this.Autore = autore;
        }

        // SETTERS

        private void SetCodice()
        {
            string caratteri = "ABCDEFGHIJKLMNOPQRSTUVXYWZ0123456789";
            Random random = new Random();

            for (int i = 0; i < 8; i++) 
            {
                this.codice += caratteri[random.Next(caratteri.Length)];
            }
        }

        // GETTERS 
        public string GetCodice()
        {
            return this.codice;
        }
       
    }
}
