using TesisFrontEnd.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesisFrontEnd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserAttentionCharts : ContentPage
    {
        public UserAttentionCharts()
        {
            InitializeComponent();
            BindingContext = new GeneralChartsViewModel(Models.CategoryType.UserAttention);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ((GeneralChartsViewModel)BindingContext).RefreshData().ConfigureAwait(false);
        }
    }
}