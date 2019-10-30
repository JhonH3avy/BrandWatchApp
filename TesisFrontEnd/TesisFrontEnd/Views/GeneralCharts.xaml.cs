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
            //BindingContext = new GeneralChartsViewModel(GeneralChart);
            Entries = new List<Entry>
            {
                new Entry(100)
                {
                    ValueLabel = "100",
                    Label = "febrary"
                },
                new Entry(200)
                {
                    ValueLabel = "200",
                    Label = "april"
                }
            };
            GeneralChart.Chart = new BarChart
            {
                Entries = Entries
            };
        }
        
        public IList<Entry> Entries { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //((GeneralChartsViewModel)BindingContext).RefreshData();
        }
    }
}