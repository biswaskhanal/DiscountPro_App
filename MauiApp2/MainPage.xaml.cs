using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private List<Store> stores; // Declare stores at the class level

        public MainPage()
        {
            InitializeComponent();
            LoadStores();
        }

        private void LoadStores()
        {
            // Initialize the stores list
            stores = new List<Store>
            {
                new Store { Name = "Walmart", Logo = "walmart.png" },
                new Store { Name = "Costco", Logo = "costco.png" },
                new Store { Name = "Real Canadian Superstore", Logo = "superstore.png" },
                new Store { Name = "Nike", Logo = "nike.png" },
                new Store { Name = "Lululemon", Logo = "lulu.png" },
                new Store { Name = "Food Basics", Logo = "foodb.jpeg" }
            };

            // Set the list view item source
            storeListView.ItemsSource = stores;
        }

        private async void OnStoreTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Store store)
            {
                switch (store.Name)
                {
                    case "Walmart":
                        await Navigation.PushAsync(new WalmartContent());
                        break;
                    case "Costco":
                        await Navigation.PushAsync(new CostcoContentt());
                        break;
                    case "Lululemon":
                        await Navigation.PushAsync(new LuluContent());
                        break;
                    case "Food Basics":
                        await Navigation.PushAsync(new FoodbContent());
                        break;
                    case "Nike":
                        await Navigation.PushAsync(new NikeContent());
                        break;
                    case "Real Canadian Superstore":
                        await Navigation.PushAsync(new RealStoreContent());
                        break;
                }
            }
        }

        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            string searchText = searchBar.Text.ToLower();

            // Filter the list of stores based on the search query
            List<Store> filteredStores = stores.Where(s => s.Name.ToLower().Contains(searchText)).ToList();

            // Update the ListView with the filtered stores
            storeListView.ItemsSource = filteredStores;

            // Clear the search bar text if it's empty
            if (string.IsNullOrWhiteSpace(searchText))
            {
                storeListView.ItemsSource = stores; // Revert to original list
            }
        }
    }

    public class Store
    {
        public string Name { get; set; }
        public string Logo { get; set; }
    }

}
