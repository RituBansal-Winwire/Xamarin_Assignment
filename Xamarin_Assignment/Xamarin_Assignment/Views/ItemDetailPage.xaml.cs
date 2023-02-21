using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_Assignment.ViewModels;

namespace Xamarin_Assignment.Views
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