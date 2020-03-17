using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Rcorrea4
{
    class Player
    {
        private string name;
        private string lastName;

        public Player(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public int lanzar(int min=0, int max=2)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
