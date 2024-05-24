using EasySerealayser;
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

namespace TestBiblioteka
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

        private void Ser_Click(object sender, RoutedEventArgs e)
        {
            MyData data = new MyData();
            data.Text1 = textSer.Text;
            Solayser.Serialize(data);

        }

        private void DeSer_Click(object sender, RoutedEventArgs e)
        {
            MyData data = Solayser.Deserialize<MyData>();
            textDeser.Text = data.Text1;
        }
    }
}