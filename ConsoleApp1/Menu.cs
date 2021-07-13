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
        ModuloUsuario moduloUsuario = new ModuloUsuario();
        public List<Usuario> usuarios = new List<Usuario>();
        public void MontaMenu()
        {
            Cabecalho();
            Opcoes();
            Rodape();
            Escolhas();
        }

        private void Rodape()
        {
            Console.Write("Escolha uma opção\t");
        }

        private void Opcoes()
        {
            Console.WriteLine("\t1-Cadastrar Usuario");
            Console.WriteLine("\t2-Cadastrar Produto");
            Console.WriteLine("\t3-Ver lista de usuarios");
            Console.WriteLine("\t4-Sair");
        }

        private void Cabecalho()
        {
            TxtMod.ColorText("--------------Havan Labs--------------", ConsoleColor.Cyan);
            TxtMod.ColorText("--------------Bem-Vindo--------------", ConsoleColor.Gray);
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
                        moduloUsuario.Create();
                        MontaMenu();
                        break;
                    case 2:
                        Console.Clear();
                        TxtMod.ColorText("Em implementação...", ConsoleColor.Yellow);
                        Console.ReadLine();
                        Console.Clear();
                        MontaMenu();
                        break;
                    case 3:
                        moduloUsuario.ReadAll();
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
                        TxtMod.ColorText("Opção inválida! Tente novamente", ConsoleColor.Red);
                        break;
                }
            } while (opcao < 0 || opcao > 4);
        }

        //private void MostrarListaUsuarios(List<Usuario> usuarios)
        //{
        //    Console.Clear();
        //    Console.WriteLine("Lista de Usuarios:");
        //    if (usuarios.Count <= 0)
        //    {
        //        TxtMod.ColorText("Nenhum Usuário cadastrado.", ConsoleColor.Yellow);
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        foreach (var user in usuarios)
        //        {
        //            Console.WriteLine($"\n\nNome: {user.Nome} {user.Sobrenome} \n{user.Idade} anos de idade \nE-mail: {user.Email}\nEndereço: {user.Endereco}");
        //        }
        //        Console.ResetColor();
        //    }
        //}
    }
}
