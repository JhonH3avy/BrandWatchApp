using TesisFrontEnd.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesisFrontEnd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserExperienceCharts : ContentPage
    {
        public UserExperienceCharts()
        {
            InitializeComponent();
            BindingContext = new GeneralChartsViewModel(Models.CategoryType.UserExperience);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ((GeneralChartsViewModel)BindingContext).RefreshData().ConfigureAwait(false);
        }
    }
}