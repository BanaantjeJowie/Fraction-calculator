
namespace FractionLibrary
{
    public class Fraction
    {
        //uml diagrammatic representation of the class
        //--------------------------------------------------------------------------------
        //- numerator: int
        //- denominator: int
        //+ << get/set >> Numerator: int
        //+ << get/set >> Denominator: int
        //--------------------------------------------------------------------------------
        //+ Fraction()
        //+ Fraction(numerator: int, denominator: int)
        //+ add(fraction: Fraction): Fraction
        //+ subtract(fraction: Fraction): Fraction
        //+ multiply(fraction: Fraction): Fraction
        //+ divide(fraction: Fraction): Fraction
        //+ reciprocal(): Fraction
        //+ invert(): fraction
        //+ simplify(): Fraction
        //+ Result(): double
        //+ ToString(): string
        //--------------------------------------------------------------------------------

        //The general idea behind the mathematical methods is that the result of the calculation is always returned as a new object of type Fraction.Neither the called upon object or the right operand is ever modified.



        //welcome the user to the fraction calculator
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Fraction Calculator. \n What do you want to do?");
            Thread.Sleep(2000);
            Console.WriteLine("Please wait for the menu to load...");
            Thread.Sleep(1000);
            Console.WriteLine("1. Add two fractions");
            Thread.Sleep(500);
            Console.WriteLine("2. Subtract two fractions");
            Thread.Sleep(500);
            Console.WriteLine("3. Multiply two fractions");
            Thread.Sleep(500);
            Console.WriteLine("4. Divide two fractions");
            Thread.Sleep(500);
            Console.WriteLine("5. Reciprocal of a fraction");
            Thread.Sleep(500);
            Console.WriteLine("6. Invert a fraction");
            Thread.Sleep(500);
            Console.WriteLine("7. Simplify a fraction");
            Thread.Sleep(500);
            Console.WriteLine("8. Exit");
            Thread.Sleep(500);
            Console.WriteLine("Enter your choice: ");
            
        }

        //properties
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        //constructors
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }


        //methods

        public Fraction Add(Fraction fraction)
        {
            int newNumerator = Numerator * fraction.Denominator + Denominator * fraction.Numerator;
            int newDenominator = Denominator * fraction.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Substract(Fraction fraction) 
        {
            int newNumerator = Numerator * fraction.Denominator - Denominator * fraction.Numerator;
            int newDenominator = Denominator * fraction.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Multiply(Fraction fraction) 
        {
            int newNumerator = Numerator * fraction.Numerator;
            int newDenominator = Denominator * fraction.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Divide(Fraction fraction)
        {
            int newNumerator = Numerator * fraction.Denominator;
            int newDenominator = Denominator * fraction.Numerator;
            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Reciprocal()
        {
            return new Fraction(Denominator, Numerator);
        }
        public Fraction Invert()
        {
            return new Fraction(-Numerator, Denominator);
        }
        public Fraction Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            return new Fraction(Numerator / gcd, Denominator / gcd);
        }
        private int GCD(int numerator, int denominator)
        {
           

            while (denominator != 0)
            {
                int temp = denominator;
                denominator = numerator % denominator;
                numerator = temp;
            }
            return numerator;

        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }        
        public double Result()

        {
            return (double)Numerator / Denominator;
        }




         

    }
}
