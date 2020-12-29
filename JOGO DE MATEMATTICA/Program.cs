using System;

namespace JOGO_DE_MATEMATTICA
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero num = new Numero();

            Console.WriteLine("Digite um número de 1 a 10.");
            num.n1 = double.Parse(Console.ReadLine());
            num.testando();
            Console.WriteLine("Pense em um número e aperte enter.");
            num.tecla();
            Console.WriteLine("Multiplica por 2 e aperte enter.");
            num.tecla();
            Console.WriteLine("Mais o número que você escolheu e aperte enter.");
            num.tecla();
            Console.WriteLine("Dividido por 2 e aperte enter.");
            num.tecla();
            Console.WriteLine("Menos o número que você pensou e aperte enter.");
            num.tecla();
            Console.WriteLine(num.resultado());

            Console.ReadLine();
            return;
        }
    }
}
