using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switches
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieVote movie = new MovieVote();
            Store store = new Store();
            //movie.Vote();

            store.ChooseYourGrocery();
            Console.Read();
        }
    }
}
