using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductMange.service;

namespace ProductMange.view
{
    public class Menu
    {
        public void Option()
        {
            System.Console.WriteLine("-----MENU-----");
            System.Console.WriteLine("1. Add");
            System.Console.WriteLine("2. Edit");
            System.Console.WriteLine("3. Delete");
            System.Console.WriteLine("4. Show");
            System.Console.WriteLine("5. Search by name");
            System.Console.WriteLine("6. End");
            Console.Write("Choose: ");
            int choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Add.create();
                    break;

                case 2:
                    Edit.editProduct();
                    break;

                case 3:
                    Delete.deleteProduct();
                    break;

                case 4:
                    Show.getAll();
                    break;

                case 5:
                    SearchByName.searchProductByName();
                    break;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Environment.Exit(0);
                    break ;
            }

        }
    }
}
