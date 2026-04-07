namespace Filosofos.Entities
{
    internal class Filosofo
    {
        public enum Estado
        {
            Comendo,
            Pensando
        }
        public string Nome { get; set; }
        public bool Faca { get; private set; }
        public bool Garfo { get; private set; }
        public int Comida { get; private set; }
        public Estado EstadoAtual
        {
            get
            {
                return (Faca && Garfo && Comida > 0) ?  Estado.Comendo : Estado.Pensando;
            }
        }

        public Filosofo(string nome, int comida)
        {
            Nome = nome;
            Faca = false;
            Garfo = false;
            Comida = comida;
        }

        public bool PegarFaca()
        {
            Faca = true;
            return true;
        }
        public bool PegarGarfo()
        {
            Garfo = true;
            return true;
        }
        public bool LargarFaca()
        {
            Faca = false;
            return true;
        }
        public bool LargarGarfo()
        {
            Garfo = false;
            return true;

        }

        public void Comer()
        {
            if (Garfo && Faca && Comida > 0)
            {
                Comida--;
                Console.WriteLine("Comendo... comida restante: " + Comida);
            }
            else
            {
                Console.WriteLine("Comida indisponivel.");
            }
        }
        public void MostrarEstado()
        {
            Console.WriteLine($"{Nome} -> Estado: {EstadoAtual.ToString()} | Comida: {Comida}");
        }

    }
}
