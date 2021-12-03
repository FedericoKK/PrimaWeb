using System;
using System.ComponentModel.DataAnnotations;

namespace Santi.Federico._5H.Primaweb.Models
{
    public class Persona
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Cognome {get; set;}
        [Required(ErrorMessage= "Inserisci una mail valida")]
        [EmailAddress]
        public string Email {get;set;}
    }
}