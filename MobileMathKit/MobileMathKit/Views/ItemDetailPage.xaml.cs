using MobileMathKit.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileMathKit.Views
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