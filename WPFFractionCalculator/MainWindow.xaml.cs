using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using FractionLibrary;
using System;




namespace WPFFractionCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        new Fraction firstFraction = new Fraction();
        new Fraction secondFraction = new Fraction();
        new Fraction resultFraction = new Fraction();


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Result(object sender, RoutedEventArgs e)
        {
            if (Operator.Text == "+" )
            {
                if (txtDenominatorone.Text == "" || txtNumeratorone.Text == "" || txtDenominatortwo.Text == "" || txtNumeratortwo.Text == "" )
                {
                    txtMessageotd.Text = "Please fill in all fields.";
                }
                else
                {
                    txtMessageotd.Text = "";
                    firstFraction = new Fraction(int.Parse(txtNumeratorone.Text), int.Parse(txtDenominatorone.Text));
                    secondFraction = new Fraction(int.Parse(txtNumeratortwo.Text), int.Parse(txtDenominatortwo.Text));
                    resultFraction = firstFraction.Add(secondFraction).Simplify();
                    txtDenominatorResult.Text = resultFraction.Denominator.ToString();
                    txtNumeratorResult.Text = resultFraction.Numerator.ToString();
                }
                
                
                
            }
            else if(Operator.Text == "-")
            {

                if (txtDenominatorone.Text == "" || txtNumeratorone.Text == "" || txtDenominatortwo.Text == "" || txtNumeratortwo.Text == "")
                {
                    txtMessageotd.Text = "Please fill in all fields.";
                }
                else
                { 
                    firstFraction = new Fraction(int.Parse(txtNumeratorone.Text), int.Parse(txtDenominatorone.Text));
                    secondFraction = new Fraction(int.Parse(txtNumeratortwo.Text), int.Parse(txtDenominatortwo.Text));
                    resultFraction = firstFraction.Substract(secondFraction).Simplify();
                    txtDenominatorResult.Text = resultFraction.Denominator.ToString();
                    txtNumeratorResult.Text = resultFraction.Numerator.ToString();
                }
            }
            else if(Operator.Text == "/")
            {
                if (txtDenominatorone.Text == "" || txtNumeratorone.Text == "" || txtDenominatortwo.Text == "" || txtNumeratortwo.Text == "")
                {
                    txtMessageotd.Text = "Please fill in all fields.";
                }

                else
                {
                   firstFraction = new Fraction(int.Parse(txtNumeratorone.Text), int.Parse(txtDenominatorone.Text));
                    secondFraction = new Fraction(int.Parse(txtNumeratortwo.Text), int.Parse(txtDenominatortwo.Text));
                    resultFraction = firstFraction.Divide(secondFraction).Simplify();
                    txtDenominatorResult.Text = resultFraction.Denominator.ToString();
                    txtNumeratorResult.Text = resultFraction.Numerator.ToString();  
                }
                
                
            }
            else if(Operator.Text == "x")
            {
                if (txtDenominatorone.Text == "" || txtNumeratorone.Text == "" || txtDenominatortwo.Text == "" || txtNumeratortwo.Text == "")
                {
                    txtMessageotd.Text = "Please fill in all fields.";
                }
                else
                {
                    firstFraction = new Fraction(int.Parse(txtNumeratorone.Text), int.Parse(txtDenominatorone.Text));
                    secondFraction = new Fraction(int.Parse(txtNumeratortwo.Text), int.Parse(txtDenominatortwo.Text));
                    resultFraction = firstFraction.Multiply(secondFraction).Simplify();
                    txtDenominatorResult.Text = resultFraction.Denominator.ToString();
                    txtNumeratorResult.Text = resultFraction.Numerator.ToString();
                }
                
                
            }
            else if(Operator.Text == "-f")
            {
                if (txtDenominatorone.Text == "" || txtNumeratorone.Text == "" )
                {
                    txtMessageotd.Text = "Please fill in all fields.";
                }
                else
                { 
                firstFraction = new Fraction(int.Parse(txtNumeratorone.Text), int.Parse(txtDenominatorone.Text));
                secondFraction = new Fraction(int.Parse(txtNumeratortwo.Text), int.Parse(txtDenominatortwo.Text));
                resultFraction = firstFraction.Reciprocal().Simplify();
                txtDenominatorResult.Text = resultFraction.Denominator.ToString();
                txtNumeratorResult.Text = resultFraction.Numerator.ToString();
                txtNumeratortwo.Visibility = Visibility.Hidden;
                txtDenominatortwo.Visibility = Visibility.Hidden;
                streeptwee.Visibility = Visibility.Hidden;
                txtMessageotd.Text = "The second fraction is not used in this operation.";
                }
            }
            else if(Operator.Text == "1/f")
            {
                if (txtDenominatorone.Text == "" || txtNumeratorone.Text == "" )
                {
                    txtMessageotd.Text = "Please fill in all fields.";
                }
                else
                { 
                firstFraction = new Fraction(int.Parse(txtNumeratorone.Text), int.Parse(txtDenominatorone.Text));
                secondFraction = new Fraction(int.Parse(txtNumeratortwo.Text), int.Parse(txtDenominatortwo.Text));
                resultFraction = firstFraction.Invert().Simplify();
                txtDenominatorResult.Text = resultFraction.Denominator.ToString();
                txtNumeratorResult.Text = resultFraction.Numerator.ToString();
                txtNumeratortwo.Visibility = Visibility.Hidden;
                txtDenominatortwo.Visibility = Visibility.Hidden;
                streeptwee.Visibility = Visibility.Hidden;
                txtMessageotd.Text = "The second fraction is not used in this operation.";
                }
            }
        }
        

        private void AddOperator_Click(object sender, RoutedEventArgs e)
        {
            Operator.Text = "+";
        }

        private void SubstractOperator_Click(object sender, RoutedEventArgs e)
        {
            Operator.Text = "-";
        }

        private void DivideOperator_Click(object sender, RoutedEventArgs e)
        {
            Operator.Text = "/";
        }

        private void MultiplyOperator_Click(object sender, RoutedEventArgs e)
        {
            Operator.Text = "x";
        }

        private void ReciprocalOperator_Click(object sender, RoutedEventArgs e)
        {
            Operator.Text = "-f";
        }

        private void InvertOperator_Click(object sender, RoutedEventArgs e)
        {
            Operator.Text = "1/f";
        }
        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            txtNumeratorone.Text = "";
            txtDenominatorone.Text = "";
            txtNumeratortwo.Text = "";
            txtDenominatortwo.Text = "";
            txtNumeratorResult.Text = "";
            txtDenominatorResult.Text = "";
            txtMessageotd.Text = "";
            Operator.Text = "";
        }
        private void BtnAbout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AboutWindow aboutWindow = new();
            aboutWindow.ShowDialog();
            this.Show();
        }


    }
}