// See https://aka.ms/new-console-template for more information

using csharp_biblioteca;

//Si vuole progettare un sistema per la gestione di una biblioteca.
//Gli utenti si possono registrare al sistema, fornendo:
//cognome
//nome
//email
//password
//recapito telefonico
//Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa
//titolo
//anno
//settore (storia, matematica, economia, …)
//uno scaffale in cui è posizionato
//un autore (Nome, Cognome)
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
//Creiamo anche una classe Biblioteca che contiene la lista dei documenti, la lista degli utenti e la lista dei prestiti.
//Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti.

Biblioteca biblioteca = new Biblioteca();

Libro theWitcher = new Libro("Il guardiano degli innocenti", 1996, "Fantasy", "A", "Andrej Sapwoski", 400);
Libro ilSignoreDegliAnelli = new Libro("Il Signore Degli Anelli", 1980, "Fantasy", "B", "J.J.Martin", 600);
Libro alice = new Libro("Alice nel paese delle meraviglie", 1968, "Avventura", "K", "Tizio", 225);

Dvd beatles = new Dvd("Ehi Jude", 1970, "Pop", "A","The Beatles", 3);

biblioteca.AddLibro(theWitcher);
biblioteca.AddLibro(ilSignoreDegliAnelli);
biblioteca.AddLibro(alice);
biblioteca.AddDvd(beatles);

biblioteca.StampaListaDocumenti();

Utente utente1 = new Utente("cognome1", "nome1", "tizio1@gmail.com", "123456789", 3412331309);
Utente utente2 = new Utente("cognome2", "nome2", "tizio2@gmail.com", "123456789", 3412331309);
Utente utente3 = new Utente("cognome3", "nome3", "tizio3@gmail.com", "123456789", 3412331309);
Utente utente4 = new Utente("cognome4", "nome4", "tizio4@gmail.com", "123456789", 3412331309);

biblioteca.AddUtente(utente1);
biblioteca.AddUtente(utente2);
biblioteca.AddUtente(utente3);
biblioteca.AddUtente(utente4);

biblioteca.AddPrestito("nome1", "cognome1", 40, theWitcher);

biblioteca.StampaListaUtenti();

Console.WriteLine("Inserire nome da cercare nella lista prestiti: ");
string nomePrestito = Console.ReadLine();

Console.WriteLine("Inserire il cognome da cercare nella lista prestiti: ");
string cognomePrestito = Console.ReadLine();

Prestito prestito = biblioteca.CercaPrestiti(nomePrestito,cognomePrestito);

if(prestito != null)
{
    prestito.StampaPrestito();
}
else
{
    Console.WriteLine("Nessun Prestito Trovato");
}


