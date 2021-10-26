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

namespace Намордник.UI
{
    /// <summary>
    /// Логика взаимодействия для ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : Page
    {
        public ProductListPage()
        {
            InitializeComponent();

            DbGrid.ItemsSource = PageHelper.Entities.Product.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            PageHelper.MainFrame.GoBack(); // Navigate(new MainMenuPage())
        }
    }
}
