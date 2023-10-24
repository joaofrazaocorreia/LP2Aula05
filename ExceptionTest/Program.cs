using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insere um numero inteiro:");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido:{i}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Não inseriste um número inteiro :(");
            }
            catch (OverflowException)
            {
                Console.WriteLine("O número que inseriste é demasiado grande!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um problema desconhecido: " + e.Message);
            }

        }
    }
}
