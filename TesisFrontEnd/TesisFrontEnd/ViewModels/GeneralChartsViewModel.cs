using TesisFrontEnd.Services;
using Entry = Microcharts.Entry;
using System.Linq;
using SkiaSharp;
using Microcharts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using TesisFrontEnd.Models;

namespace TesisFrontEnd.ViewModels
{
    public class GeneralChartsViewModel : BaseViewModel
    {
        private Chart _generalAmountChart;
        private Chart _generalPercentageChart;
        private Chart _generalCitiesChart;

        public GeneralChartsViewModel(CategoryType category)
        {
            ServiceClient = ApiClientFactory.GetApiClient(ApiClientType.DebugApiClient);
            Category = category;
        }

        private CategoryType Category { get; set; }

        public IApiClient ServiceClient { get; private set; }

        public Chart GeneralAmountChart
        {
            get => _generalAmountChart;
            set
            {
                _generalAmountChart = value;
                OnPropertyChanged();
            }
        }

        public Chart GeneralPercentageChart
        {
            get => _generalPercentageChart;
            set
            {
                _generalPercentageChart = value;
                OnPropertyChanged();
            }
        }

        public Chart GeneralCitiesChart
        {
            get => _generalCitiesChart;
            set
            {
                _generalCitiesChart = value;
                OnPropertyChanged();
            }
        }

        public async Task RefreshData()
        {
            var randomNumberGenerator = new Random();
            var amountData = new List<Entry>();
            var chartAmountData = await ServiceClient.GetAmountDataForCategoryAsync(Category);
            chartAmountData.ToList().ForEach((cd) =>
            {
                var entry = new Entry(cd.Value)
                {
                    Label = cd.Label,
                    ValueLabel = cd.Value.ToString(),
                    Color = SKColor.FromHsl(randomNumberGenerator.Next(0, 255), randomNumberGenerator.Next(0, 255), randomNumberGenerator.Next(0, 255))
                };
                amountData.Add(entry);
            });
            GeneralAmountChart = new BarChart
            {
                Entries = amountData
            };
            var percentageData = new List<Entry>();
            var chartPercentageData = await ServiceClient.GetPercentageDataForCategoryAsync(Category);
            chartPercentageData.ToList().ForEach((cd) =>
            {
                var entry = new Entry(cd.Value)
                {
                    Label = cd.Label,
                    ValueLabel = cd.Value.ToString(),
                    Color = SKColor.FromHsl(randomNumberGenerator.Next(0, 255), randomNumberGenerator.Next(0, 255), randomNumberGenerator.Next(0, 255))
                };
                percentageData.Add(entry);
            });
            GeneralPercentageChart = new LineChart
            {
                Entries = percentageData,
                LineMode = LineMode.Spline,
                PointMode = PointMode.Circle,
                LineSize = 8,
                BackgroundColor = SKColors.Transparent,
            };
            var citiesData = new List<Entry>();
            var chartCitiesData = await ServiceClient.GetCitiesDataForCategoryAsync(Category);
            chartCitiesData.ToList().ForEach((cd) =>
            {
                var entry = new Entry(cd.Value)
                {
                    Label = cd.Label,
                    ValueLabel = cd.Value.ToString(),
                    Color = SKColor.FromHsl(randomNumberGenerator.Next(0, 255), randomNumberGenerator.Next(0, 255), randomNumberGenerator.Next(0, 255))
                };
                citiesData.Add(entry);
            });
            GeneralCitiesChart = new DonutChart
            {
                Entries = citiesData,
                BackgroundColor = SKColors.Transparent,
                HoleRadius = 0.5f,
            };
        }
    }
}
