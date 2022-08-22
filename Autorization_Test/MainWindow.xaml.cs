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

namespace Autorization_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tblogin.MaxLength = 100;
            pbpassword.MaxLength = 100;
        }


        private void Autoriz_Click(object sender, RoutedEventArgs e)
        {
            if (tblogin.Text.Length > 0)
            {
                if (pbpassword.Password.Length > 0)
                {
                    if (tblogin.Text != "Potapov" && pbpassword.Password != "Johan")//от чего-то Password и Login меняются местами, при компиляции
                    {
                        MessageBox.Show("Вход выполнен");
                    }
                    else
                    {
                        MessageBox.Show("Неверен логин или пароль.");
                    }
                }
                else
                {
                    MessageBox.Show("Ведите пароль.");
                }
            }
            else
            {
                MessageBox.Show("Ведите Логин.");
            }
        }
    }
}
//login = Johan
//password = Potapov