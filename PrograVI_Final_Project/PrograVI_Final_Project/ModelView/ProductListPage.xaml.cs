using PrograVI_Final_Project.Models;
using PrograVI_Final_Project.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrograVI_Final_Project.ModelView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {
        public ObservableCollection<ProductByCategory> ProductByCategoryCollection;
        public ProductListPage(int categoryId, string categoryName)
        {
            InitializeComponent();
            //LblCategoryName.Text = categoryName;
            ProductByCategoryCollection = new ObservableCollection<ProductByCategory>();
            GetProducts(categoryId);
        }

        private async void GetProducts(int id)
        {
            var products = await ApiService.GetProductByCategory(id);
            foreach (var product in products)
            {
                ProductByCategoryCollection.Add(product);
            }
            //CvProducts.ItemsSource = ProductByCategoryCollection;
        }

        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void CvProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currectSelection = e.CurrentSelection.FirstOrDefault() as ProductByCategory;
            if (currectSelection == null) return;
            
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}