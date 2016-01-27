using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switches
{
    class MovieVote
    {
        int m, l, o, h, x, f = 0;
        Random random = new Random();
        
        public enum Movies
        {
            TheMatrix,
            TheLionKing,
            LOTR,
            TheHobbit,
            XMen,
            ForestGump,
        };

        public void Filter(string tally)
        {
            if (!(tally == "1" || tally == "2" || tally == "3" || tally == "4" || tally == "5" || tally == "6"))
            {
                Console.Clear();
                Console.WriteLine("That is an invalid vote!");
                Console.WriteLine("Revoting...");
                Console.ReadKey();

                Vote();
                return;
            }
        }
        public void Vote()
        {
           

            for (int i = 0; i <= 10; i++)
            { 
                Console.WriteLine("Which movie?  Press....");
                Console.WriteLine("1:TheMatrix, 2:TheLionKing, 3:LOTR, 4:TheHobbit, 5:XMen, 6:ForestGump");
                string tally = Console.ReadLine();
                Filter(tally);
                if (!(tally == "1" || tally == "2" || tally == "3" || tally == "4" || tally == "5" || tally == "6"))
                {
                    Console.Clear();
                    Console.WriteLine("That is an invalid vote!");
                    Console.WriteLine("Revoting...");
                    Console.ReadKey();

                    Vote();
                    return;
                }

                switch (tally)
                {
                    case "1":
                        m++;
                        break;
                    case "2":
                        l++;
                        break;
                    case "3":
                        o++;
                        break;
                    case "4":
                        h++;
                        break;
                    case "5":
                        x++;
                        break;
                    case "6":
                        f++;
                        break;
                }
            }
            int[] numbers = new int[] { m, l, o, h, x, f };
            int maxNum = numbers.Max();
            Console.WriteLine("-----------------------------------");
            if (m > l && m > o && m > h && m > x && m > f)
            {
                Console.WriteLine(Movies.TheMatrix + " has the most votes with...");
                Console.WriteLine(maxNum + " votes!");
            }
            else if (l > m && l > o && l > h && l > x && l > f)
            {
                Console.WriteLine(Movies.TheLionKing + " has the most votes with...");
                Console.WriteLine(maxNum + " votes!");
            }
            else if (o > m && o > l && o > h && o > x && o > f)
            {
                Console.WriteLine(Movies.LOTR + " has the most votes with...");
                Console.WriteLine(maxNum + " votes!");
            }
            else if (h > m && h > l && h > o && h > x && h > f)
            {
                Console.WriteLine(Movies.TheHobbit + " has the most votes with...");
                Console.WriteLine(maxNum + " votes!");
            }
            else if (x > m && x > l && x > o && x > h && x > f)
            {
                Console.WriteLine(Movies.XMen + " has the most votes with...");
                Console.WriteLine(maxNum + " votes!");
            }
            else if (f > m && f > l && f > o && f > h && f > x)
            {
                Console.WriteLine(Movies.ForestGump + " has the most votes with...");
                Console.WriteLine(maxNum + " votes!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("There was a tie!");
            }


            //Console.WriteLine(m);
        }
    }
}
