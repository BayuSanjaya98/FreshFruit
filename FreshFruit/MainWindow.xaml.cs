using FreshFruit.Controller;
using FreshFruit.Model;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller toni;
        private string message;

        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new
            BucketController(keranjangBuah, this);

            toni = new Seller("toni", bucketController);
            listBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        public void onFailed(string massage)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string massage)
        {
            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("anggur");
            toni.addFruit(anggur);

        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            toni.addFruit(apple);

        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("Banana");
            toni.addFruit(banana);


        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("Orange");
            toni.addFruit(orange);
        }
       
    }
}

