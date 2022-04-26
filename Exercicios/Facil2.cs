namespace Exercicios
{
    public class Facil2
    {
        public void WritePar()
        {
            for (int i = 0; i < 100; i++)
            {
                if((i % 2 == 0) && (i > 0))
                {
                    if (i == 98)
                    {
                        Console.Write(i);
                        continue;
                    }
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
