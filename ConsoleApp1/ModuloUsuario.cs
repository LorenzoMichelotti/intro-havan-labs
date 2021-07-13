using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuloUsuario
    {
        UsuarioRepository repository = new UsuarioRepository();
        public void Create()
        {
            string resposta = String.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro do usuario\n");
                Console.Write("Nome: ");
                string nome = Validacao.ValidaString(true);
                Console.Write("Sobrenome: ");
                string sobrenome = Validacao.ValidaString(true);
                Console.Write("Idade: ");
                int idade = Validacao.ValidaInt(); Console.Clear();
                Console.Write("E-mail: ");
                string email = Validacao.ValidaEmail(); Console.Clear();
                Console.Write("Endereço: ");
                string endereco = Validacao.ValidaString(); Console.Clear();
                TxtMod.ColorText("Cadastro Concluído!", ConsoleColor.Green);
                Console.ReadLine();
                Console.Clear();

                Usuario model = new Usuario(nome, sobrenome, idade, email, endereco);

                repository.Create(model);

                Console.WriteLine("Deseja cadastrar outro usuario? (y/n)");
                resposta = Console.ReadLine(); Console.Clear();
            } while (resposta == "y");
        }

        public void ReadAll()
        {
            Console.Clear();
            Console.WriteLine("Lista de Usuarios:");
            if (repository.ReadAll().Count <= 0)
            {
                TxtMod.ColorText("Nenhum Usuário cadastrado.", ConsoleColor.Yellow);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                foreach (var user in repository.ReadAll())
                {
                    Console.WriteLine($"\n\nNome: {user.Nome} {user.Sobrenome} \n{user.Idade} anos de idade \nE-mail: {user.Email}\nEndereço: {user.Endereco}");
                }
                Console.ResetColor();
            }
        }
    }
}
