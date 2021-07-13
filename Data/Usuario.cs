using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Data
{
    public class Usuario
    {
        //Encapsulamento - Propriedade
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public List<Produto> MeusProdutos { get; set; }

        //Construtor
        public Usuario(string nome, string sobrenome, int idade, string email, string endereco)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.Email = email;
            this.Endereco = endereco;
        }
        public Usuario()
        {

        }
    }
}
