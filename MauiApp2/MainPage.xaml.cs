using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadStores();
        }

        private void LoadStores()
        {
            List<Store> stores = new List<Store> // List of stores with name and logo
            {
                new Store { Name = "Walmart", Logo = "walmart.png" },
                new Store { Name = "Costco", Logo = "costco.png" },
                new Store { Name = "Real Canadian Superstore", Logo = "superstore.png" },
                new Store { Name = "Nike", Logo = "nike.png" },
                new Store { Name = "Lululemon", Logo = "lulu.png" },
                new Store { Name = "Food Basics", Logo = "foodb.jpeg" }
            };

            storeListView.ItemsSource = stores;
        }
    }

    public class Store
    {
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
