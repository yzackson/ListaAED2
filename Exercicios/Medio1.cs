namespace Exercicios
{
    class Medio1
    {
        public int[] Numeros = new int[100];

        Random random = new();

        public void WriteVector()
        {
            for (int i = 0; i < Numeros.Length; i++)
            {
                Numeros[i] = random.Next(1000);
            }

            Array.Sort(Numeros);

            foreach (int i in Numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}