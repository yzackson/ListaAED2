namespace Exercicios
{
    public class Facil3
    {
        string Linha;

        public void WriteTriangle(int qtdLinhas)
        {
            int qtdEspacos = qtdLinhas;

            if (qtdLinhas > 1)
            {
                for (int i = 0; i < qtdLinhas; i++)
                {
                    // zera a linha
                    Linha = "";

                    // adiciona os espacos
                    for (int k = 0; k < qtdEspacos; k++)
                    {
                        Linha += " ";
                    }
                    qtdEspacos -= 1;

                    // adiciona o *
                    for (int j = -1; j != i; j++)
                    {
                        Linha += "*";
                    }

                    if(i > 0)
                    {
                        // adiciona o *
                        for (int j = 0; j != i; j++)
                        {
                            Linha += "*";
                        }
                    }

                    Console.WriteLine(Linha);
                }
            } else
            {
                Linha = "*";
                Console.WriteLine(Linha);
            }
        }
    }
}
