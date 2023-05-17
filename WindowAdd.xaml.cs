using ExamplePracWork13.Classes;
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
using System.Windows.Shapes;

namespace ExamplePracWork13
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
           
        }

        private void BtnAddReader_Click(object sender, RoutedEventArgs e)
        {
            ClassPrice Shops = new ClassPrice()
            {
                Names = names.Text,
                Shop = shop.Text,
                Price = price.Text,
                Amount = amount.Text,
            };
            ClassHelp.Shopes.Add(Shops);
        }
    }
}
