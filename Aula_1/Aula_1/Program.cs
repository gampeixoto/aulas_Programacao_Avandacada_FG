using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Execicio em sala
            byte tecla, teclaCalculadora;
            int idade, conta;
            float contaGrande, numeroGrande;
            bool verdadeiroOuFalso, simOuNao;
            string nome, frases;
            char letra, numero;
            #endregion

            #region Execicio de casa

            #region 1
            Console.WriteLine("Diga dois números:");
            string numb1 = Console.ReadLine();
            string numb2 = Console.ReadLine();
            int soma = int.Parse(numb1) + int.Parse(numb2);
            Console.WriteLine("A soma dos numeros são:" + soma.ToString());
            #endregion

            #region 2
            Console.WriteLine("Diga dois numeros: ");
            string n1= Console.ReadLine();
            string n2= Console.ReadLine();
            int sub = int.Parse(n1) - int.Parse(n2);
            Console.WriteLine("A subtração dos dois números é: " + sub.ToString());
            #endregion

            #region 3
            Console.WriteLine("Digite dois numeros: ");
            numb1 = Console.ReadLine();
            numb2 = Console.ReadLine();
            int mult = int.Parse(numb1) * int.Parse(numb2);
            Console.WriteLine("A multiplicação de dois numeros é :" + mult.ToString());
            #endregion

            #region 4
            Console.WriteLine("Digite dois numeros: ");
            numb1 = Console.ReadLine();
            numb2 = Console.ReadLine();
            int divisao = int.Parse(numb1) / int.Parse(numb2);
            Console.WriteLine("A divisão dois numeros é : " + divisao.ToString());
            #endregion
            
            #region 5
            Console.WriteLine("Digite dois numeros: ");
            numb1 = Console.ReadLine();
            Console.WriteLine("O sucessor do seu numero é: " + (int.Parse(numb1) +1));
            #endregion

            #region 6
            Console.WriteLine("Digite dois numeros:");
            numb1 = Console.ReadLine();
            numb2 = Console.ReadLine();

            if(int.Parse(numb1) % int.Parse(numb2) == 0)
                Console.WriteLine(numb1 + " é multiplo de "+numb2);
            else
                Console.WriteLine(numb1+" não é multiplo de "+ numb2);
            #endregion

            #region 7
            Console.WriteLine("A quantos anos você fuma?");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos cigarros você fuma por dia?");
            int qtDia = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto custava cada cigarro?");
            int valor = int.Parse(Console.ReadLine());
            int valorTotal = (((ano * 365) * qtDia) * valor);
            Console.WriteLine("Você já gastou R$" + valorTotal.ToString());
            #endregion

            #endregion

        }
    }
}
