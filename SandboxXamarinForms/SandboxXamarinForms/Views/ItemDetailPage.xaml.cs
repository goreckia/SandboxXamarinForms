using SandboxXamarinForms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SandboxXamarinForms.Views
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