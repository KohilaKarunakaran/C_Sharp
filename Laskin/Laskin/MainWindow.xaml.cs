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

namespace Laskin
{

    public partial class MainWindow : Window
    {
        private int firstNumber = 0;
        private int secondNumber = 0;
        private bool isSecondNumber = false;
        private bool isDivision = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                int number = int.Parse(button.Content.ToString());
                if (!isSecondNumber)
                {
                    firstNumber = number;
                    Display.Text = firstNumber.ToString();
                    isSecondNumber = true;
                }
                else
                {
                    secondNumber = number;
                    Display.Text = secondNumber.ToString();
                }
            }
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            if (isSecondNumber) // Ensure two numbers are selected
            {
                if (isDivision)
                {
                    if (secondNumber != 0)
                    {
                        double result = (double)firstNumber / secondNumber;
                        Display.Text = result.ToString("F2");
                    }
                    else
                    {
                        Display.Text = "Error";
                    }
                }
                else
                {
                    int result = firstNumber + secondNumber;
                    Display.Text = result.ToString();
                }
                isSecondNumber = false;
                isDivision = false; // Reset after operation
            }
        }

        private void Division_Checked(object sender, RoutedEventArgs e)
        {
            isDivision = true;
        }
        private void Division_Unchecked(object sender, RoutedEventArgs e)
        {
            isDivision = false;
        }
    }
}
