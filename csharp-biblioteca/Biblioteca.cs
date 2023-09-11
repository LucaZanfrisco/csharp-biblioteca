using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        public List<Documento> documenti = new List<Documento>();
        public List<Utente> utenti = new List<Utente>();
        public List<Prestito> prestiti = new List<Prestito>();

        public void AddDocumento(string titolo, int anno, string settore, string scaffale, string autore)
        {
            documenti.Add(new Documento(titolo, anno, settore, scaffale, autore));
        }
        public void AddDocumento(Documento documento)
        {
            documenti.Add(documento);
        }
        public void AddLibro(string titolo, int anno, string settore, string scaffale, string autore, int pagine)
        {
            documenti.Add(new Libro(titolo, anno, settore, scaffale, autore, pagine));
        }
        public void AddLibro(Libro libro)
        {
            documenti.Add(libro);
        }

        public void AddDvd(string titolo, int anno, string settore, string scaffale, string autore, int durata)
        {
            documenti.Add(new Dvd(titolo, anno, settore, scaffale, autore, durata));
        }
        public void AddDvd(Dvd dvd)
        {
            documenti.Add(dvd);
        }

        public void AddUtente(string cognome, string nome, string email, string password, int telefono)
        {
            utenti.Add(new Utente(cognome, nome, email, password, telefono));
        }
        public void AddPrestito(string nome, string cognome, int numeroGiorni, Documento documento)
        {
            prestiti.Add(new Prestito(nome, cognome, DateTime.Now, DateTime.Now.AddDays(numeroGiorni), documento));
        }

        public Documento CercaDocumento(string codice, string titolo)
        {
            foreach(Documento documento in documenti)
            {
                if(documento.GetCodice() == codice.ToUpper() || documento.Titolo.ToLower() == titolo.ToLower())
                {
                    return documento;
                }
            }
            return null;
        }

        public Prestito CercaPrestiti(string nome, string cognome)
        {
            foreach(Prestito prestito in prestiti)
            {
                if(prestito.Nome.ToLower() == nome.ToLower() && prestito.Cognome.ToLower() == cognome.ToLower())
                {
                    return prestito;
                }
            }
            return null;
        }
        public void StampaListaDocumenti()
        {
            foreach(var elemento in documenti)
            {
                Console.WriteLine($"Codice: {elemento.GetCodice()}" +
                                    $"\nTitolo: {elemento.Titolo}" +
                                    $"\nAnno: {elemento.Anno}" +
                                    $"\nSettore: {elemento.Settore}" +
                                    $"\nScaffale: {elemento.Scaffale}" +
                                    $"\nAutore: {elemento.Autore}");


            }
        }
        public void StampaListaUtenti()
        {
            foreach(var elemento in utenti)
            {
                Console.WriteLine($"Nome: {elemento.Nome}" +
                $"\nCognome: {elemento.Cognome}" +
                $"\nEmail: {elemento.Email}" +
                $"\nTelefono: {elemento.Telefono}");
            }
        }
        public void StampaListaPrestiti()
        {
            foreach(var elemento in prestiti)
            {
                Console.WriteLine($"Nome: {elemento.Nome}" +
                $"\nCognome: {elemento.Cognome}" +
                $"\nData Noleggio: {elemento.DataInizio}" +
                $"\nData Restituzione: {elemento.DataFine}" +
                $"{StampaListaDocumenti}");
            }
        }
    }
}
