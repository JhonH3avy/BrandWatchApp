using TesisFrontEnd.Services;
using System.Collections.ObjectModel;
using Entry = Microcharts.Entry;
using System.Linq;
using Microcharts.Forms;
using SkiaSharp;
using Microcharts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TesisFrontEnd.ViewModels
{
    public class GeneralChartsViewModel : BaseViewModel
    {
        private Chart _generalChart;

        public GeneralChartsViewModel()
        {
            ServiceClient = ApiClientFactory.GetApiClient(ApiClientType.DebugApiClient);
        }

        public IApiClient ServiceClient { get; private set; }

        public Chart GeneralChart
        {
            get => _generalChart;
            set
            {
                _generalChart = value;
                OnPropertyChanged();
            }
        }

        public async Task RefreshData()
        {
            var data = new List<Entry>();
            var chartData = await ServiceClient.GetDataForCategoryAsync("General");
            chartData.ToList().ForEach((cd) =>
            {
                var entry = new Entry(cd.Value)
                {
                    Label = cd.Label,
                    ValueLabel = cd.Value.ToString(),
                    Color = SKColor.Parse("#FF1493")
                };
                data.Add(entry);
            });
            GeneralChart = new BarChart
            {
                Entries = data
            };
        }
    }
}
