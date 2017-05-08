using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielerrollen
{
    class Spieler : IComparable
    {
        public int Nummer { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        //public string Angreifer { get; set; }
        //public string Mittelfeldspieler { get; set; }
        //public string Verteidiger { get; set; }
        //public string Torwart { get; set; }

        public Spieler(int nummer, string name, string position)
        {
            Nummer = nummer;
            Name = name;
            Position = position;
        }

        public int CompareTo(object obj)
        {
            return this.Nummer.CompareTo(((Spieler)obj).Nummer);
        }
    }
}
