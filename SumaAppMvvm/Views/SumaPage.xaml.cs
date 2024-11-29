using SumaAppMvvm.ViewModels;

namespace SumaAppMvvm.Views;

    public partial class SumaPage : ContentPage
    {
        SumaViewModel viewModel;
        public SumaPage()
        {
            InitializeComponent();
            viewModel = new SumaViewModel();
            BindingContext = viewModel;
        }
    }