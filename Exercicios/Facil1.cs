namespace Exercicios
{
    public class Facil1
    {
        public void WriteName(string name)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(name == "" ? "Zé sem nome" : i.ToString() + " - " + name);
            }
        }
    }
}
