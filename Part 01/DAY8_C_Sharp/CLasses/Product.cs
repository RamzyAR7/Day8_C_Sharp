using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.CLasses
{
    internal class Product:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(int id , string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            Product product = (Product) obj;

            if (this.Price > product.Price)
            {
                return 1;
            }
            else if (this.Price < product.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Price : {Price}";
        }
    }
}
