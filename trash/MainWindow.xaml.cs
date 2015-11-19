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
using System.Xml;

namespace trash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Test t = new Test();

            TestClass tc = new TestClass();


            richTextBox.AppendText(t.configName);
            richTextBox.AppendText("\r\n");
            richTextBox.AppendText(tc.configName);
            richTextBox.AppendText("\r\n");
            richTextBox.AppendText(t.getCfgParam("add[@key='User']/@value", "Not found"));

            //MessageBox.Show(t.configName + " " + tc.configName);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Test t = new Test();
            XmlNode n = t.getCfgParamNode("pippo");

            n.InnerText = "My Text";

            xwcs.core.cfg.ConfigData.Open().Save();
        }
    }
}
