namespace Exercicios
{
    class Facil4
    {
        int fibo = 0;
        int num1 = 1;
        int num2;

        public void WriteFibo()
        {
            for (int i = 0; i < 30; i++)
            {
                if (i == 29)
                {
                    Console.Write(fibo);
                    continue;
                }
                Console.Write(fibo + ", ");
                num2 = num1;
                num1 = fibo;
                fibo = num1 + num2;
            }
        }
    }
}