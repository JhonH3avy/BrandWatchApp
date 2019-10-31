using Microcharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesisFrontEnd.Services;
using TesisFrontEnd.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

namespace TesisFrontEnd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralCharts : ContentPage
    {
        public GeneralCharts()
        {
            InitializeComponent();
            BindingContext = new GeneralChartsViewModel();
        }
        
        public IList<Entry> Entries { get; set; }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ((GeneralChartsViewModel)BindingContext).RefreshData();
        }
    }
}