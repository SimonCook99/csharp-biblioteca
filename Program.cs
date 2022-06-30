//una serie di istanze per "popolare" il nostro "fake db"
// 2 o 3 utenti -> registrati
// 2 o 3 libri --> tutti disponibili
// Gli utenti si possono registrare specificando i dati ...

using csharp_biblioteca;

Sistema s = new Sistema();

Console.WriteLine("Benvenuto nella nostra biblioteca online. Seleziona un opzione: ");Console.WriteLine("1: registrati");Console.WriteLine("2: login");int opzione = int.Parse(Console.ReadLine());switch (opzione){
    case 1:
        Console.WriteLine("Crea ora il tuo nuovo utente. Inserisci il tuo nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Inserisci il tuo cognome");
        string cognome = Console.ReadLine();
        Console.WriteLine("Inserisci la tua email");
        string email = Console.ReadLine();
        Console.WriteLine("Inserisci la tua password");
        string password = Console.ReadLine();
        Console.WriteLine("Inserisci il tuo telefono");
        string telefono = Console.ReadLine();

        Utente nuovo = new Utente(nome, cognome, email, password, telefono);
        s.registraNuovoUtente(nuovo);
        break;
    case 2:
        Console.WriteLine("Inserisci la tua email: ");
        string emailLogin = Console.ReadLine();
        Console.WriteLine("Inserisci la tua password: ");
        string passwordLogin = Console.ReadLine();

        s.effettuaLogin(emailLogin);
        break;
}// Biblioteca online// 1. registrati// 2. login//login // email: ..// passowrd: ..// Biblioteca online// 1. Cerca libri// 2. Cerca dvd// Registrazione// Scrivmi il nome: // scrivimi il cognome.. etc// scrivi la passowrd: // Menu libro (titolo)// 1. visualizza dettagli libro// 2. richiedi prestito// 3. restitutisci// tutti i menu hanno esci o torna indietro
