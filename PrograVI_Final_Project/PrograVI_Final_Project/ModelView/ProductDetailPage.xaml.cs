using PrograVI_Final_Project.Models;
using PrograVI_Final_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrograVI_Final_Project.ModelView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailPage : ContentPage
    {
        private int _productId;
        public ProductDetailPage(int productId)
        {
            InitializeComponent();
            GetProductDetails(productId);
            _productId = productId;
        }

        private async void GetProductDetails(int productId)
        {
            //No me estan funcionando las variables creadas
            //var product = await ApiService.GetProductById(productId);
            //LblName.Text = product.name;
            //LblDetail.Text = product.detail;
            //ImgProduct.Source = product.FullImageUrl;
            //LblPrice.Text = product.price.ToString();
            //LblTotalPrice.Text = LblPrice.Text;

        }

        private void TapIncrement_Tapped(object sender, EventArgs e)
        {
            //var i = Convert.ToInt16(LblQty.Text);
            //i++;
            //LblQty.Text = i.ToString();
            //LblTotalPrice.Text = (Convert.ToInt16(LblQty.Text) * Convert.ToInt16(LblPrice.Text)).ToString();

        }

        private void TapDecrement_Tapped(object sender, EventArgs e)
        {
           
        }

        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private async void BtnAddToCart_Clicked(object sender, EventArgs e)
        {
           

        }
    }
}