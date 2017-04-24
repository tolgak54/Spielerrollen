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
        }

        private void button_datei_Click(object sender, RoutedEventArgs e)
        {
            string line;


            if (ofd.ShowDialog() == true)
            {

                StreamReader sr = new StreamReader(ofd.FileName);

                while ((line = sr.ReadLine()) != null)
                {
                    string idx = line.Substring(0, line.IndexOf(";"));
                    Label l = new Label();
                    l.Content = line;
                    listBoxAusgabe.Items.Add(l);
                }
                listBoxDatei.Items.Add(ofd.FileName);
                sr.Close();
            }
        }

        private void listBoxAusgabe_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(((Label)listBoxAusgabe.SelectedItem).Content.ToString().Contains("Abwehrspieler"))
                ((Label)listBoxAusgabe.SelectedItem).Background = Brushes.Green;
            else if (((Label)listBoxAusgabe.SelectedItem).Content.ToString().Contains("Mittelfeldspieler"))
                ((Label)listBoxAusgabe.SelectedItem).Background = Brushes.Blue;
            else if (((Label)listBoxAusgabe.SelectedItem).Content.ToString().Contains("Angreifer"))
                ((Label)listBoxAusgabe.SelectedItem).Background = Brushes.Red;
            else
                ((Label)listBoxAusgabe.SelectedItem).Background = Brushes.Yellow;
        }
    }
}
