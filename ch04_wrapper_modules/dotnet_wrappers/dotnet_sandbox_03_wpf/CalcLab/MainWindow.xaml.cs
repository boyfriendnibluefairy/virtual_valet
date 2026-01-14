using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalcLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        ChosenOperator chosenOperator;
        public MainWindow()
        {
            InitializeComponent();
            labelResult.Content = "0";

            // Add Event Handler for each buttons.
            // When you type +=, press tab to autocomplete handler functions.
            btnEquals.Click += BtnEquals_Click;
            btnAC.Click += BtnAC_Click;
            btnNegative.Click += BtnNegative_Click;
            btnPercentage.Click += BtnPercentage_Click;
            btnPoint.Click += BtnPoint_Click;
        }

        private void BtnPoint_Click(object sender, RoutedEventArgs e)
        {
            if (labelResult.Content.ToString().Contains("."))
            {
                // Do Nothing
            }
            else
            {
                labelResult.Content = $"{labelResult.Content.ToString()}.";
            }
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if(double.TryParse(labelResult.Content.ToString(), out newNumber))
            {
                switch (chosenOperator)
                {
                    case ChosenOperator.Addition:
                        result = BasicArithmetic.Add(lastNumber, newNumber);
                        break;
                    case ChosenOperator.Subtraction:
                        result = BasicArithmetic.Subtract(lastNumber, newNumber);
                        break;
                    case ChosenOperator.Multiplication:
                        result = BasicArithmetic.Multiply(lastNumber, newNumber);
                        break;
                    case ChosenOperator.Division:
                        result = BasicArithmetic.Divide(lastNumber, newNumber);
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                labelResult.Content = result.ToString();
            }
        }

        private void BtnPercentage_Click(object sender, RoutedEventArgs e)
        {
            double num;
            if(double.TryParse(labelResult.Content.ToString(), out num))
            {
                num = num / 100;
                if (lastNumber != 0)
                {
                    num = lastNumber * num;
                }
                labelResult.Content = num.ToString();
            }
            else
            {
                Console.WriteLine("Unable to parse result to decimal");
            }
        }

        private void BtnNegative_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(labelResult.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                labelResult.Content = lastNumber.ToString();
            }
            else
            {
                Console.WriteLine($"Unable to pase '{labelResult.Content}'");
            }
        }

        private void BtnAC_Click(object sender, RoutedEventArgs e)
        {
            labelResult.Content = "0";
            lastNumber = 0;
        }

        private void btnOperation_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(labelResult.Content.ToString(), out lastNumber))
            {
                labelResult.Content = "0";
            }
            else
            {
                Console.WriteLine($"Unable to parse '{labelResult.Content}'");
            }

            if(sender == btnPlus)
            {
                chosenOperator = ChosenOperator.Addition;
            }
            if (sender == btnMinus)
            {
                chosenOperator = ChosenOperator.Subtraction;
            }
            if (sender == btnTimes)
            {
                chosenOperator = ChosenOperator.Multiplication;
            }
            if (sender == btnDivide)
            {
                chosenOperator = ChosenOperator.Division;
            }
        }

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            int pressedValue = int.Parse((sender as Button).Content.ToString());

            if (labelResult.Content.ToString() == "0")
            {
                labelResult.Content = pressedValue.ToString();
            }
            else
            {
                labelResult.Content = $"{labelResult.Content}{pressedValue}";
            }
        }
    }

    public enum ChosenOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    public class BasicArithmetic
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Divide(double n1, double n2)
        {
            if(n2 == 0)
            {
                MessageBox.Show("Division by 0 is not supported",
                    "Invalid Operation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return 0;
            }
            return n1 / n2;
        }
    }
}
