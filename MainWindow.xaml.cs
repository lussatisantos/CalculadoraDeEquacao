using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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

namespace CalculadoraDeEquacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double T { get; private set; }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            int a;
            int b;
            int c;

            a = Convert.ToInt32(ax2.Text);
            b = Convert.ToInt32(bx.Text);
            c = Convert.ToInt32(cx.Text);

            int delta;
            delta = b * b - (4 * a * c);

            if (delta < 0)
            {
                txtResultado.Text = "[Delta negativo] A equacao não tem solução  no Conjunto dos números reais";
            } else if(delta == 0)
            {
               double T = Math.Sqrt(delta);
               double x = (-b + T) / 2 * a;

                txtResultado.Text = "Delta: " + delta +  "\n" + "X: " + x + "\n\n" + "Atencao: Quando Delta igual 0, o x1 e x2 possuem o mesmo valor";  
            } else
            {
                double T = Math.Sqrt(delta);
                double x1 = (-b + T) / 2 * a;
                double x2 = (-b - T) / 2 * a;

                txtResultado.Text = "Delta: " + delta + "\n" + "X1: " + x1 + "\n" + "X2: " + x2;
            }

           // txtResultado.Text = Convert.ToString(a);
        }
    }
}
