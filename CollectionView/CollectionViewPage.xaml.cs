using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewPage : ContentPage
    { public IList<Product> Ilist { get; set; }
        public CollectionViewPage()
        {
            InitializeComponent();
            Ilist=new List<Product>();
            Ilist.Add(new Product{ ProductName="Laptop",Description="This is sony laptop", ImageURL="Laptop.JPEG"});
            Ilist.Add(new Product { ProductName = "Led", Description = "This is sony led", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Book", Description = "This is sony book", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Bulb", Description = "This is sony bulb", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Computer", Description = "This is sony computer", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Mouse", Description = "This is sony mouse", ImageURL = "Laptop.JPEG" });

            Ilist.Add(new Product { ProductName = "Modem", Description = "This is sony books", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Sodem", Description = "This is sony bulbs", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Keyboard", Description = "This is sony computers", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Harddisk", Description = "This is sony mouses", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Modem", Description = "This is sony books", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Sodem", Description = "This is sony bulbs", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Keyboard", Description = "This is sony computers", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Product { ProductName = "Harddisk", Description = "This is sony mouses", ImageURL = "Laptop.JPEG" });
            BindingContext = this;
        }
    }
    public class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}