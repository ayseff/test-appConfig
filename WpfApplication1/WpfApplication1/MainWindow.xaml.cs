using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
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
using WpfApplication1.Properties;

namespace WpfApplication1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var x = ConfigurationManager.AppSettings.AllKeys;
            //MessageBox.Show(ConfigurationManager.AppSettings.Count.ToString());
            MessageBox.Show(ConfigurationManager.AppSettings["x"]);
            //MessageBox.Show(Settings.Default.a);
            //var defaultSpecialA = Properties.SpecialSettings.Default.specialA;
        }
    }
}
