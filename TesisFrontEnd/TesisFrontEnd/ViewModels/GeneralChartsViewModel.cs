using TesisFrontEnd.Services;
using System.Collections.ObjectModel;
using Entry = Microcharts.Entry;
using System.Linq;
using Microcharts.Forms;
using SkiaSharp;

namespace TesisFrontEnd.ViewModels
{
    public class GeneralChartsViewModel : BaseViewModel
    {
        public GeneralChartsViewModel(ChartView chart)
        {
            GeneralChart = chart;
            ServiceClient = ApiClientFactory.GetApiClient(ApiClientType.DebugApiClient);
            Data = new ObservableCollection<Entry>();
        }

        public IApiClient ServiceClient { get; private set; }

        public ChartView GeneralChart { get; set; }

        public ObservableCollection<Entry> Data { get; private set; }

        public async void RefreshData()
        {
            Data.Clear();
            var chartData = await ServiceClient.GetDataForCategoryAsync("General");
            chartData.AsParallel().ForAll((cd) =>
            {
                var entry = new Entry(cd.Value)
                {
                    Label = cd.Label,
                    ValueLabel = cd.Value.ToString(),
                    Color = SKColor.Parse("#FF1493")
                };
                Data.Add(entry);
            });
            GeneralChart.Chart = new Microcharts.BarChart
            {
                Entries = Data
            };
        }
    }
}
