using System;

namespace kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a, b, c");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            Equation example1 = new Equation(c);
            example1.A = a;
            example1.B = b;
            example1.Diskriminant();
            if (example1.D >= 0)
            {
                example1.Result();
                Console.WriteLine($"Корень 1={example1.X1} и Корень 2={example1.X2}");
            }
            else
            {
                Console.WriteLine("No decision");
            }

        }
    }

    public class Equation
    {
        private int a;
        private int b;
        private int c;
        private int d;
        private double x1;
        private double x2;

        public int A
        {
            private get
            {
                return a;
            }
            set {
                a = value;
            }

        }
        public int B
        {
            private get
            {
                return b;
            }
            set
            {
                b = value;
            }

        }

        public int C { private get; set; }
        public int D { get; private set; }
        public double X1 { get; private set; }
        public double X2 { get; private set; }


        public Equation(int c)
        {
            C = c;
            X1 = x1;
            X2 = x2;
        }

        public void Diskriminant() {
            d=b*b-4*a*c;
            D = d;
        }

        public void Result() {
             x1 = (-b + Math.Sqrt(D)) / (2 * a);
             x2 = (-b - Math.Sqrt(D)) / (2 * a);
        }

    }

}
