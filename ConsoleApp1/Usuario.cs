using System;
using System.Collections.Generic;
using Data;

namespace ConsoleApp1
{
    class Usuario
    {
        public string nome = String.Empty, sobrenome = String.Empty, email = String.Empty, cidade = String.Empty, endereco = String.Empty, complemento = String.Empty;
        public int idade = 0;

        public void Cadastro()
        {
            Console.Clear();
            Console.WriteLine("Cadastro do usuario\n");
            Console.Write("Nome: ");
            this.nome = Validacao.ValidaString(true);
            Console.Write("Sobrenome: ");
            this.sobrenome = Validacao.ValidaString(true);
            Console.Write("Idade: ");
            this.idade = Validacao.ValidaInt(); Console.Clear();
            Console.Write("E-mail: ");
            this.email = Validacao.ValidaEmail(); Console.Clear();
            //Console.Write("Cidade: ");
            //this.cidade = Validacao.ValidaString(true);
            Console.Write("Endereço: ");
            this.endereco = Validacao.ValidaString(); Console.Clear();
            //Console.Write("Complemento: ");
            //this.complemento = Validacao.ValidaString(); Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cadastro Concluído!");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
