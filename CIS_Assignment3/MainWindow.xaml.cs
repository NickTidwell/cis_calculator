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
using System.Data;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace CIS_Assignment3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack<string> resultStack = new Stack<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region buttonClicks


        private void btn_1_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "1" : txt_input.Text += "1";

        private void btn_2_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "2" : txt_input.Text += "2";

        private void btn_3_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "3" : txt_input.Text += "3";

        private void btn_4_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "4" : txt_input.Text += "4";

        private void btn_5_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "5" : txt_input.Text += "5";

        private void btn_6_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "6" : txt_input.Text += "6";

        private void btn_7_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "7" : txt_input.Text += "7";

        private void btn_8_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "8" : txt_input.Text += "8";

        private void btn_9_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "9" : txt_input.Text += "9";

        private void btn_0_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "0" : txt_input.Text += "0";

        private void btn_minus_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "-" : txt_input.Text += "-";

        private void btn_multiply_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "*" : txt_input.Text += "*";

        private void btn_add_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "+" : txt_input.Text += "+";
        private void btn_divide_Clicked(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "/" : txt_input.Text += "/";

        private void btn_openParenth_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = "(" : txt_input.Text += "(";

        private void btn_closeParenth_Click(object sender, RoutedEventArgs e) => txt_input.Text = txt_input.Text == "error" ? txt_input.Text = ")" : txt_input.Text += ")";

        private void btn_sqrt_Clicked(object sender, RoutedEventArgs e)
        {
            if (txt_input.Text == "error") txt_input.Text = "";
            txt_input.Text = txt_input.Text.Insert(0, "Sqrt(");
            txt_input.Text += ')';
        }


        private void btn_neg_Click(object sender, RoutedEventArgs e)
        {
            if (txt_input.Text == "error") txt_input.Text = "";
            txt_input.Text = txt_input.Text.Insert(0, "-1*(");
            txt_input.Text += ')';
        }


        #endregion

        private void btn_equate_Click(object sender, RoutedEventArgs e)
        {
            //Uses Roslyn to evaluate String Expressions, Imports math to handle Squares
            try
            {
                var result = CSharpScript.EvaluateAsync(txt_input.Text, Microsoft.CodeAnalysis.Scripting.ScriptOptions.Default.WithImports("System.Math")).Result.ToString();
                txt_input.Text = result;
                resultStack.Push(result);
            }catch
            {
                txt_input.Text = "error";
            }

        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            txt_input.Text = "";
        }

        private void btn_recall_Click(object sender, RoutedEventArgs e)
        {
            if(resultStack.Count != 0)
            {
                txt_input.Text += resultStack.Pop();
            }
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            txt_input.Text = txt_input.Text.Substring(0, txt_input.Text.Length - 1);
        }
    }
}
