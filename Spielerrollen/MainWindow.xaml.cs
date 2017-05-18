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
        enum Spielertyp { Abwehrspieler, Mittelfeldspieler, Angreifer }
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
                    spieler.Add(new Spieler(Convert.ToInt32(line.Split(';')[0]), line.Split(';')[1], line.Split(';')[2]));
                    l.Background = Brushes.Pink;

                }
                listBoxDatei.Items.Add(ofd.FileName);
                sr.Close();
            }
        }

        private void listBoxAusgabe_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Spielertyp abwehrspieler = Spielertyp.Abwehrspieler;
            Spielertyp mittelfeldspieler = Spielertyp.Mittelfeldspieler;
            Spielertyp angreifer = Spielertyp.Angreifer;

            if (((Label)listBoxAusgabe.SelectedItem).Content.ToString().Contains(abwehrspieler.ToString()))
                ((Label)listBoxAusgabe.SelectedItem).Background = Brushes.Green;
            else if (((Label)listBoxAusgabe.SelectedItem).Content.ToString().Contains(mittelfeldspieler.ToString()))
                ((Label)listBoxAusgabe.SelectedItem).Background = Brushes.Blue;
            else if (((Label)listBoxAusgabe.SelectedItem).Content.ToString().Contains(angreifer.ToString()))
                ((Label)listBoxAusgabe.SelectedItem).Background = Brushes.Red;
            else
                ((Label)listBoxAusgabe.SelectedItem).Background = Brushes.Yellow;


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBoxAusgabe.Items.Clear();
            spieler.Sort();
            foreach (Spieler item in spieler)
            {
                Label l2 = new Label();
                l2.Content = item.Nummer + ";" + item.Name + ";" + item.Position;
                listBoxAusgabe.Items.Add(l2);
                l2.Background = Brushes.Pink;
            }
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            listBoxDatei.Items.Clear();
            listBoxAusgabe.Items.Clear();
            spieler.Clear();
        }
    }
}
