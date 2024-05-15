namespace InheritanceFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het programma is gestart!");

            Circle figuur1 = new Circle(50);

            figuur1.draw();

            Figure figuur2 = new Figure("Yellow");
            string kleur = figuur2.getColor();
            Console.WriteLine("De kleur van figuur 2 is " + kleur);
            figuur2.setColor("red");
            kleur = figuur2.getColor();
            Console.WriteLine("De kleur van figuur2 is " + kleur);

            Console.ReadKey();
        }
    }
}
