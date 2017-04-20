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
using System.IO;
using Microsoft.Win32;

namespace Spielerrollen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog ofd = new OpenFileDialog();
        List<Spieler> spieler = new List<Spieler>();

        public MainWindow()
        {
            InitializeComponent();
            //test();
        }

        private void button_datei_Click(object sender, RoutedEventArgs e)
        {
            string line = "";


            if (ofd.ShowDialog() == true)
            {

                StreamReader sr = new StreamReader(ofd.FileName);

                while ((line = sr.ReadLine()) != null)
                {
                    string idx = line.Substring(0, line.IndexOf(";"));
                    listBoxAusgabe.Items.Add(line);
                }
                listBoxDatei.Items.Add(ofd.FileName);
                sr.Close();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < listBoxAusgabe.Items.Count; i++)
            {
                switch (spieler.Count)
                {
                    case 1:
   
                        break;
                    case 2:
                        
                        break;
                    case 3:

                        break;
                    default:
                        
                        break;
                }
            }
        }
        //public void test()
        //{
        //FileStream f = new FileStream(@"C:\Users\tolga\Desktop\Schule\3CHIT\SEW\Projekt\Spielerrollen2.csv", FileMode.Open, FileAccess.Read);
        //StreamReader s = new StreamReader(f);
        //label.Content = s.ReadToEnd();       
        //string[] sj = s.ReadToEnd().Split(';');
        //label.Content = "Name: " + sj[0] + ", Position: " + sj[1]; 
        //}
    }
}
