namespace Exercicios
{
    class Medio2
    {
        public int[] Numeros1 = new int[50];
        public int[] Numeros2 = new int[50];

        Random random = new();

        public void WriteVector()
        {
            for (int i = 0; i < 50; i++)
            {
                Numeros1[i] = random.Next(1000);
                Numeros2[i] = random.Next(1000);
            }

            Numeros1.Concat(Numeros2);

            Array.Sort(Numeros1);

            foreach (int i in Numeros1)
            {
                Console.WriteLine(i);
            }
        }
    }
}