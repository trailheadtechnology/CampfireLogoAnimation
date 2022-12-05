using CampfireLogoAnimation.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CampfireLogoAnimation.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}