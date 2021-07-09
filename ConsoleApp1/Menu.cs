using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp1
{
    class Menu
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public void MontaMenu()
        {
            Cabecalho();
            Opcoes();
            Rodape();
            Escolhas();
        }

        private static void Rodape()
        {
            Console.Write("Escolha uma opção\t");
        }

        private static void Opcoes()
        {
            Console.WriteLine("\t1-Cadastrar Usuario");
            Console.WriteLine("\t2-Cadastrar Produto");
            Console.WriteLine("\t3-Ver lista de usuarios");
            Console.WriteLine("\t4-Sair");
        }

        private static void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------Havan Labs--------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--------------Bem-Vindo--------------");
            Console.ResetColor();
        }

        public void Escolhas()
        {
            int opcao = 0;
            do
            {
                opcao = Validacao.ValidaInt();
                switch (opcao)
                {
                    case 1:
                        string resposta = String.Empty;
                        do
                        {
                            Usuario user = new Usuario();
                            user.Cadastro();
                            usuarios.Add(user);
                            Console.WriteLine("Deseja cadastrar outro usuario? (y/n)");
                            resposta = Console.ReadLine(); Console.Clear();
                        } while (resposta == "y");
                        MontaMenu();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Em implementação...");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        MontaMenu();
                        break;
                    case 3:
                        MostrarListaUsuarios(usuarios);
                        Console.ReadLine();
                        Console.Clear();
                        MontaMenu();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Até breve!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida! Tente novamente");
                        Console.ResetColor();
                        break;
                }
            } while (opcao < 0 || opcao > 4);
        }

        private static void MostrarListaUsuarios(List<Usuario> usuarios)
        {
            Console.Clear();
            Console.WriteLine("Lista de Usuarios:");
            if (usuarios.Count <= 0)
            {
                Console.WriteLine("Nenhum Usuário cadastrado.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                foreach (var user in usuarios)
                {
                    Console.WriteLine($"\n\nNome: {user.nome} {user.sobrenome} \n{user.idade} anos de idade \nE-mail: {user.email}\nEndereço: {user.endereco}");
                }
                Console.ResetColor();
            }
        }
    }
}
