using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }

        public Product(string name, int price, string title)
        {
            Name = name;
            Price = price;
            Title = title;
        }
    }
}
