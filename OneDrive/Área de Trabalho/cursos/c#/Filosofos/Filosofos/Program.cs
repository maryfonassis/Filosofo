using Filosofos.Entities;

namespace Filosofos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filosofo f1 = new Filosofo("Filósofo 1", 3);
            Filosofo f2 = new Filosofo("Filósofo 2", 2);

            while (true)
            {
                Console.Clear();

                f1.MostrarEstado();
                f2.MostrarEstado();

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Filósofo 1 comer");
                Console.WriteLine("2 - Filósofo 2 comer");
                Console.WriteLine("0 - Sair");

                Console.Write("Opção: ");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 0)
                    break;

                if (escolha == 1 || escolha == 2)
                {
                    Filosofo f = escolha == 1 ? f1 : f2;

                    ExecutarCiclo(f);
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

                if (f1.Comida <= 0 && f2.Comida <= 0)
                {
                    Console.WriteLine("A comida de todos acabou!");
                    break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

            Console.WriteLine("Fim da simulação.");
        }

        static void ExecutarCiclo(Filosofo f)
        {
            f.PegarGarfo();
            Console.WriteLine($"{f.Nome} pegou o garfo.");
            f.PegarFaca();
            Console.WriteLine($"{f.Nome} pegou a faca.");

            f.Comer();

            f.LargarGarfo();
            Console.WriteLine($"{f.Nome} largou o garfo.");
            f.LargarFaca();
            Console.WriteLine($"{f.Nome} largou a faca.");
        }
    }
}