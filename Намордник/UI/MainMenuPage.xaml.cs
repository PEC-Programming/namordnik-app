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
using Намордник.UI;

namespace Намордник
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();

            PageHelper.FrameName.Text = "Главное меню";
        }

        private void BtnToProductList_Click(object sender, RoutedEventArgs e)
        {
            PageHelper.MainFrame.Navigate(new ProductListPage());
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            PageHelper.MainFrame.Navigate(new AddProductPage());
        }
    }
}
