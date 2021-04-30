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
            Equation example1 = new Equation(a, b, c);
        //    example1.A = a;
         //   example1.B = b;
          //  example1.C=c;
            example1.Diskriminant();
            if (example1.D >= 0)
            {
                example1.Result();
                Console.WriteLine($"Корень 1={example1.X1} и Корень 2={example1.X2}");
                Console.WriteLine($"Diskriminant={example1.D}");

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

public Equation(int a, int b, int c)
        {
            A=a;
            B=b;
            C=c;
        }
        

        public void Diskriminant() {
            D=b*b-4*a*C;
                  }

        public void Result() {
             X1 = (-b + Math.Sqrt(D)) / (2 * a);
             X2 = (-b - Math.Sqrt(D)) / (2 * a);
        }

    }

}
