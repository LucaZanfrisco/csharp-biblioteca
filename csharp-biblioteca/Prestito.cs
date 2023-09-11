using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Prestito
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public DateTime DataInizio { get; private set; }
        public DateTime DataFine { get; private set; }
        private Documento documento;

        public Prestito(string nome, string cognome, DateTime dataInizio, DateTime dataFine, Documento documento)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.DataInizio = dataInizio;
            this.DataFine = dataFine;
            this.documento = documento;
        }

        public void StampaPrestito()
        {
            Console.WriteLine($"Nome: {Nome}" +
                $"\nCognome: {Cognome}" +
                $"\nData Noleggio: {DataInizio}" +
                $"\nData Restituzione: {DataFine}");
        }
    }
}
