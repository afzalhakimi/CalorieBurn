using CalorieBurn.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CalorieBurn.Views
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