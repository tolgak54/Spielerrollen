using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielerrollen
{
    class Spieler
    {
        public string Name { get; set; }
        //public string Position { get; set; }
        public string Angreifer { get; set; }
        public string Mittelfeldspieler { get; set; }
        public string Verteidiger { get; set; }
        public string Torwart { get; set; }

        public Spieler(string name, string angreifer, string mittelfeld, string verteidiger, string torwart)
        {
            Name = name;
            Angreifer = angreifer;
            Mittelfeldspieler = mittelfeld;
            Verteidiger = verteidiger;
            Torwart = torwart;
        }
    }
}
