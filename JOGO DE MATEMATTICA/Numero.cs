using System;

namespace JOGO_DE_MATEMATTICA
{

    class Numero
    {
        public double n1;

        public void testando()
        {
            while (n1 > 10 )
            {
                Console.WriteLine("Digite um número de 1 a 10.");
                n1 = double.Parse(Console.ReadLine());
            }
        }

        public void tecla()
        {
            ConsoleKeyInfo keyinfo;


            do
            {
                keyinfo = Console.ReadKey(true);

                if (keyinfo.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("Aperte enter, por favor");

                }
            } while (keyinfo.Key != ConsoleKey.Enter);


        }

        public double resultado()
        {
            return n1 / 2;
        }

        public override string ToString()
        {
            return "O resultado de tudo é " + resultado();
        }
    }
}
