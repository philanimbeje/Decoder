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

namespace DecoderWPF
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

        private void btnEncode_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = DecoderLibrary.Encoder.Encrypt(txtConnectionString.Text);
        }

        private void btnDecode_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = DecoderLibrary.Encoder.Decrypt(txtEncryptedString.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtConnectionString.Text = "";
        }

        private void btnClearEncrypted_Click(object sender, RoutedEventArgs e)
        {
            txtEncryptedString.Text = "";
        }

        private void txtClearResult_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
