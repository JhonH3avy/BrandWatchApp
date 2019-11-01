using TesisFrontEnd.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesisFrontEnd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralCharts : ContentPage
    {
        public GeneralCharts()
        {
            InitializeComponent();
            BindingContext = new GeneralChartsViewModel(Models.CategoryType.General);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ((GeneralChartsViewModel)BindingContext).RefreshData().ConfigureAwait(false);
        }
    }
}