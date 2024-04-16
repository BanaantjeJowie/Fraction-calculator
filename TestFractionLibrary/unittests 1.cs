using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FractionLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestFractionLibrary
{   

    public class unittests_1
    {
        private Fraction fraction = new Fraction();

        [Fact]
        public void TestHasPropertyNumerator() 
        {
            fraction.Numerator = 2;
            Assert.Equal(2, fraction.Numerator);
            Assert.NotNull(fraction.GetType().GetProperty("Numerator"));
        }
        [Fact]
        public void TestHasPropertyDenominator() 
        {
            fraction.Denominator = 5;
            Assert.Equal(5, fraction.Denominator);
            Assert.NotNull(fraction.GetType().GetProperty("Denominator"));
        }

        // test the add method
        [Fact]
        public void TestAdd()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 4);
            Fraction result = f1.Add(f2);
            Assert.NotNull(result);
            Assert.Equal(3, result.Numerator);
            Assert.Equal(4, result.Denominator);

        }

        // test the subtract method
        [Fact]
        public void TestSubtract()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 4);
            Fraction result = f1.Substract(f2);
            Assert.Equal(1, result.Numerator);
            Assert.Equal(4, result.Denominator);
        }
        [Fact]
        public void TestMultiply()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 4);
            Fraction result = f1.Multiply(f2);
            Assert.Equal(1, result.Numerator);
            Assert.Equal(8, result.Denominator);
        }
        [Fact]
        public void TestDivide()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 4);
            Fraction result = f1.Divide(f2);
            Assert.Equal(2, result.Numerator);
            Assert.Equal(1, result.Denominator);
        }
        [Fact]
        public void TestReciprocal()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction result = f1.Reciprocal();
            Assert.Equal(2, result.Numerator);
            Assert.Equal(1, result.Denominator);
        }
        [Fact]
        public void TestInvert()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction result = f1.Invert();
            Assert.Equal(2, result.Numerator);
            Assert.Equal(1, result.Denominator);
        }
        [Fact]
        public void TestSimplify()
        {
            Fraction f1 = new Fraction(2, 4);
            Fraction result = f1.Simplify();
            Assert.Equal(1, result.Numerator);
            Assert.Equal(2, result.Denominator);
        }
        [Fact]
        public void TestGCD()
        {
            Fraction f1 = new Fraction(2, 4);
            int result = f1.GCD(2, 4);
            Assert.Equal(2, result);
        }



     

    }
}
