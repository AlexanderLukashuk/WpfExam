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

namespace Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*Product product = new Product();

            Binding binding = new Binding();

            binding.ElementName = "Product";
            binding.Path = new PropertyPath("Name");*/

            Product product = new Product("Смартфон realme 6S, 128Gb, Lunar White (RMX2002)", 50000, "Размер экрана, дюйм: 6.5 / Разрешение экрана: 2400 x 1080 / Тип матрицы: IPS / Объем оперативной памяти: 6 Гб / Объем встроенной памяти: 128 Гб / Модель процессора: Helio G90T / Частота процессора: 2.05 ГГц / Разрешение основной камеры: 48 Мп + 8 Мп + 2 Мп + 2 Мп / Разрешение фронтальной камеры: 16 Мп / Беспроводные интерфейсы: Wi-Fi; Bluetooth; NFC / Емкость аккумулятора: 4300 мАч");
            nameTextBlock.Text = product.Name;
            titleTextBlock.Text = product.Title;
            priceTextBlock.Text = product.Price.ToString();
        }

        private void BuyProduct(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Конец");
            this.Close();
        }
    }
}
