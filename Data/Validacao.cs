using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Validacao
    {
        public static String ValidaEmail()
        {
            string dado = string.Empty;
            do
            {
                dado = Console.ReadLine().Trim();
                if (dado.Equals(String.Empty) || !dado.Contains('@') || !dado.EndsWith(".com"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dado Invalido");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }
            while (true);
            return dado;
        }
        public static String ValidaString()
        {
            string dado = string.Empty;
            do
            {
                dado = Console.ReadLine().Trim();
                if (dado.Trim().Equals(String.Empty))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dado Invalido");
                    Console.ResetColor();
                }
            }
            while (String.IsNullOrEmpty(dado));
            return dado;
        }
        public static String ValidaString(bool isName)
        {
            string dado = String.Empty;
            do
            {
                dado = Console.ReadLine().Trim();
                if (String.IsNullOrEmpty(dado))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dado Invalido");
                    Console.ResetColor();
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
            while (true);
            dado = dado.Substring(0, 1).ToUpper() + dado.Substring(1);
            return dado;
        }
        public static int ValidaInt()
        {
            do
            {
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    return num;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido, tente novamente.");
                    Console.ResetColor();
                }
            } while (true);
        }
    }
}
