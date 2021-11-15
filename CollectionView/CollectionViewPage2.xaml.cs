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
    public partial class CollectionViewPage2 : ContentPage
    {
        public IList<Products> Ilist { get; set; }
        public CollectionViewPage2()
        {
            InitializeComponent();

            Ilist = new List<Products>();
            Ilist.Add(new Products { ProductName = "Laptop", Description = "This is sony laptop", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Led", Description = "This is sony led", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Book", Description = "This is sony book", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Bulb", Description = "This is sony bulb", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Computer", Description = "This is sony computer", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Mouse", Description = "This is sony mouse", ImageURL = "Laptop.JPEG" });

            Ilist.Add(new Products { ProductName = "Modem", Description = "This is sony books", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Sodem", Description = "This is sony bulbs", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Keyboard", Description = "This is sony computers", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Harddisk", Description = "This is sony mouses", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Modem", Description = "This is sony books", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Sodem", Description = "This is sony bulbs", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Keyboard", Description = "This is sony computers", ImageURL = "Laptop.JPEG" });
            Ilist.Add(new Products { ProductName = "Harddisk", Description = "This is sony mouses", ImageURL = "Laptop.JPEG" });
            BindingContext = this;
        }
    }
    public class Products
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
