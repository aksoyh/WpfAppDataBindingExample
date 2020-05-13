using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppDataBindingExample
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ObservableCollection<Person> persons = new ObservableCollection<Person>();
        Person prs;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        // Add için 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            prs = new Person();
            grid1.DataContext = prs;
        }

        // Save için
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // persons koleksiyonuna yeni bir <Person> nesnesi ekler.
            persons.Add(prs);
            lstBox.ItemsSource = persons;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Resim dosyası seçilerek <Person> nesnesinin img özelliğine set edilir.
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            if(file.FileName != null)
            {
                prs.Img = file.FileName;
            }
        }

        // MVVM = Model - View - ViewModel
        // DataBinding = Binding
    }
}
