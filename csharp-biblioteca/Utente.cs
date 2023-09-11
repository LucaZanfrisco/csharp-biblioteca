﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { private get; set; }
        public int Telefono { get; set; }

        public Utente(string cognome,string nome,string email,string passoword,int telefono) 
        {
            this.Cognome = cognome;
            this.Nome = nome;
            this.Email = email;
            this.Password = passoword;
            this.Telefono = telefono;
        }

    }
}