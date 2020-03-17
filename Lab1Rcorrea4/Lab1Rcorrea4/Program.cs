using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Rcorrea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Bob", "Kunga");
            Player player2 = new Player("Juan", "Perez");
            int lanzado = player1.lanzar();
            
            
            Console.WriteLine( player1.Name +" " +player1.LastName + "lanzo " + lanzado);
            Console.ReadLine();

        }
    }
}
