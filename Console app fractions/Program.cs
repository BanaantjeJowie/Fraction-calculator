namespace Console_app_fractions
{
    using System;
    using FractionLibrary;

    internal class Program
    {
        static void Main(string[] args)
        {   
            //welcome the user and display the menu
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
            int choice = int.Parse(Console.ReadLine());

            //perform the operation based on the user's choice
            if (choice == 1)  //if user chooses 1, add two fractions
            {
                Console.WriteLine("Enter the first fraction: ");
                Console.WriteLine("Enter the numerator: ");
                int numerator1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator1 = int.Parse(Console.ReadLine());
                Fraction fraction1 = new Fraction(numerator1, denominator1);
                Thread.Sleep(1000);
                Console.WriteLine("Your first fraction is: " + fraction1.ToString());
                Console.WriteLine("Enter the second fraction: ");
                Console.WriteLine("Enter the numerator: ");
                int numerator2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator2 = int.Parse(Console.ReadLine());
                Fraction fraction2 = new Fraction(numerator2, denominator2);
                Thread.Sleep(1000);
                Console.WriteLine("Your second fraction is: " + fraction2.ToString());
                Fraction result = fraction1.Add(fraction2);
                Console.WriteLine("Calculating...");
                Thread.Sleep(1000);
                Console.WriteLine("The result is: " + result.Simplify().ToString());
            }
            else if (choice == 2)  //if user chooses 2, subtract two fractions
            {
                Console.WriteLine("Enter the first fraction: ");
                Console.WriteLine("Enter the numerator: ");
                int numerator1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator1 = int.Parse(Console.ReadLine());
                Fraction fraction1 = new Fraction(numerator1, denominator1);
                Thread.Sleep(1000);
                Console.WriteLine("Your first fraction is: " + fraction1.ToString());
                Console.WriteLine("Enter the scond fraction: ");
                Console.WriteLine("Enter the numerator: ");
                int numerator2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator2 = int.Parse(Console.ReadLine());
                Fraction fraction2 = new Fraction(numerator2, denominator2);
                Thread.Sleep(1000);
                Console.WriteLine("Your second fraction is: " + fraction2.ToString());
                Fraction result = fraction1.Substract(fraction2);
                Console.WriteLine("Calculating...");
                Thread.Sleep(1000);
                Console.WriteLine("The result is: " + result.Simplify().ToString());

            }
            else if (choice == 3)   //if user chooses 3, multiply two fractions
            {
                Console.WriteLine("Enter the first fraction: ");
                Console.WriteLine("Enter the numerator: ");
                int numerator1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator1 = int.Parse(Console.ReadLine());
                Fraction fraction1 = new Fraction(numerator1, denominator1);
                Thread.Sleep(1000);
                Console.WriteLine("Your first fraction is: " + fraction1.ToString());
                Thread.Sleep(1000);
                Console.WriteLine("Enter the second fraction: ");
                Console.WriteLine("Enter the numerator: ");
                int numerator2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator2 = int.Parse(Console.ReadLine());
                Fraction fraction2 = new Fraction(numerator2, denominator2);
                Thread.Sleep(1000);
                Console.WriteLine("Your second fraction is: " + fraction2.ToString());
                Fraction result = fraction1.Multiply(fraction2);
                Console.WriteLine("Calculating...");
                Thread.Sleep(1000);

                Console.WriteLine("The result is: " + result.Simplify().ToString());

            }
            else if (choice == 4)   //if user chooses 4, divide two fractions
            {
                Console.WriteLine("Enter the first fraction: ");
                Console.WriteLine("Enter the numerator: ");
                int numerator1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator1 = int.Parse(Console.ReadLine());
                Fraction fraction1 = new Fraction(numerator1, denominator1);
                Console.WriteLine("Your first fraction is: " + fraction1.ToString());
                Console.WriteLine("Enter the second fraction: ");
                Console.WriteLine("Enter the numerator: ");
                int numerator2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator2 = int.Parse(Console.ReadLine());
                Fraction fraction2 = new Fraction(numerator2, denominator2);
                Console.WriteLine("Your second fraction is: " + fraction2.ToString());
                Fraction result = fraction1.Divide(fraction2);
                Console.WriteLine("Calculating...");
                Console.WriteLine("The result is: " + result.Simplify().ToString());

            }
            else if (choice == 5)    //if user chooses 5, find the reciprocal of a fraction
            {
                
                Console.WriteLine("Enter the fraction: ");
                Console.WriteLine("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());
                Fraction fraction = new Fraction(numerator, denominator);
                Console.WriteLine("Your fraction is: " + fraction.ToString());
                Fraction result = fraction.Reciprocal();
                Console.WriteLine("Calculating...");
                Console.WriteLine("The reciprocal is: " + result.Simplify().ToString());
            }
            else if (choice == 6)  //if user chooses 6, invert a fraction
            {
                Console.WriteLine("  NNNNNN    OOOOO ");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N   OOOOO ");
            }
            else if (choice == 7)   //if user chooses 7, simplify a fraction
            {
                Console.WriteLine("  NNNNNN    OOOOO ");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N   OOOOO ");
            }
            else if (choice == 8)  //if user chooses 8, exit the program
            {
                Console.WriteLine("  NNNNNN    OOOOO ");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N  O     O");
                Console.WriteLine("  N     N   OOOOO ");
            }
        }
    }
}
