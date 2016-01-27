using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switches
{
    class Store
    {
        public enum Groceries
        {
            Bread = 1,
            Milk = 2,
            Cheese = 3,
            Strawberries = 4,
            Pizza = 5,
            IceCream = 6,
            Pineapple = 7,
            Muffins = 8,
            CannedBean = 9,
            CannedCorn = 10,
            Spam = 11,
            OrangJuice = 12,
            Water = 13,
            Soda = 14,
            EnergyDrink = 15,
            Candy = 16,
            Nuts = 17,
            HotDogs = 18,
            ChickenBreasts = 19,
        }
        public void ChooseYourGrocery()
        {
            Console.WriteLine("What are you looking for?");
            //Console.WriteLine("1:Bread, 2:Milk, 3:Cheese, 4:Strawberries, 5:Pizza, 6:IceCream, 7:Pineapple, 8:Muffins, 9:CannedBean, 10:CannedCorn, 11:Spam, 12:OrangJuice, 13:Water, 14:Soda, 15:EnergyDrink, 16:Candy, 17:Nuts, 18:HotDogs, 19:ChickenBreasts");
            string[] test = Enum.GetNames(typeof(Groceries));
            int num = 1;
            foreach (string name in test)
            {
                Console.WriteLine("Press {0} for - {1}", num, name);
                num++;
            }
            int eatMe = Int32.Parse(Console.ReadLine());

            switch (eatMe)
            {
                case 1:
                case 8:
                case 17:
                    {
                        Console.WriteLine("{0}, {1}, {2} are in aisle 1", Groceries.Bread, Groceries.Muffins, Groceries.Nuts);
                        break;
                    }
                case 2:
                case 3:
                case 6:
                    {
                        Console.WriteLine("{0}, {1}, {2} are in aisle 15, the Dairy aisle", Groceries.Milk, Groceries.Cheese, Groceries.IceCream);
                        break;
                    }
                case 4:
                case 7:
                    {
                        Console.WriteLine("{0}, {1} are in aisle 10, the Fruit aisle", Groceries.Strawberries, Groceries.Pineapple);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("{0} is in aisle 13", Groceries.Pizza);
                        break;
                    }
                case 9:
                case 10:
                case 11:
                    {
                        Console.WriteLine("{0}, {1}, {2} are in aisle 5", Groceries.CannedBean, Groceries.CannedCorn, Groceries.Spam);
                        break;
                    }
                case 12:
                case 13:
                case 14:
                case 15:
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3} are in aisle 11, the Drinks aisle", Groceries.OrangJuice, Groceries.Water, Groceries.Soda, Groceries.EnergyDrink);
                        break;
                    }
                case 18:
                case 19:
                    {
                        Console.WriteLine("{0}, {1} are in aisle 7, the Meat aisle", Groceries.HotDogs, Groceries.ChickenBreasts);
                        break;
                    }
                case 16:
                    {
                        Console.WriteLine("{0} is in aisle 2", Groceries.Candy);
                        break;
                    }
            }
        }
    }
}
