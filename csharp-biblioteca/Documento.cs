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
        private string titolo;
        private int anno;
        private string settore;
        private string autore;

        public Documento(string titolo, int anno, string settore, string autore)
        {
            SetCodice();
            SetTitolo(titolo);
            SetAnno(anno);
            SetSettore(settore);
            SetAutore(autore);
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

        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void SetAnno(int anno)
        {
            this.anno = anno;
        }

        public void SetSettore(string settore)
        {
            this.settore = settore;
        }

        public void SetAutore(string autore)
        {
            this.autore = autore;
        }

        // GETTERS

        public string GetCodice()
        {
            return this.codice;
        }

        public string GetTitolo()
        {
            return this.titolo;
        }

        public int GetAnno()
        {
            return this.anno;
        }

        public string GetSettore()
        {
            return this.settore;
        }

        public string GetAutore()
        {
            return this.autore;
        }
    }
}
