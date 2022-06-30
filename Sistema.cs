using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Sistema{
        List<Utente> utentiRegistrati = new List<Utente>();
        List<Documento> documentiPresenti = new List<Documento> {
            new Libro("Moby Dick", 1857, "romanzo", true, 21, "bho", "bho2", 97888123, 1200),
            new DVD("test", 1921, "musica jazz", true, 115, "Led", "zeppelin", 4568478, 3)
        };

        public void registraNuovoUtente(Utente nuovoUtente){
            bool utenteValido = nuovoUtente.nome != null && nuovoUtente.cognome != null && nuovoUtente.email != null && nuovoUtente.numeroTelefonico != null;

            if (utenteValido){
                this.utentiRegistrati.Add(nuovoUtente);
            }
        }
    }

    
}
