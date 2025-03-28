using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senhaUsuario;
            char digito;
            bool senhaValida;

            Console.Write("Digite a senha: ");
            senhaUsuario = Console.ReadLine();

            int tamanhoSenha = senhaUsuario.Length;

            if (tamanhoSenha > 8) 
            {
                Console.WriteLine("Por favor a senha deve ter 8 caracteres, tente novamente !");
            }
            bool verificarNumero = senhaUsuario.Any(char.IsDigit);

            if (verificarNumero) 
            {
                Console.WriteLine("Senha valida");
            }
            else 
            {
                Console.WriteLine("Senha invalida");
            }
        }
    }
}
