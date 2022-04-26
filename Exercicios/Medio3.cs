namespace Exercicios
{
    class Medio3_Retangulo
    {
        float Base;
        float Altura;
        public float Area;

        public Medio3_Retangulo(float Base, float Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
            this.Area = Base * Altura;
        }

        public void ShowProperties()
        {
            Console.WriteLine($"Base = {this.Base}");
            Console.WriteLine($"Altura = {this.Altura}");
            Console.WriteLine($"Area = {this.Area}");
        }
    }
}
