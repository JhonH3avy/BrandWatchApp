using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesisFrontEnd.Models;

namespace TesisFrontEnd.Services
{
    public class DebugApiClient : IApiClient
    {
        public DebugApiClient()
        {
            NumberGenerator = new Random();
        }

        public IList<ChartData> GetAmountDataForCategory(CategoryType category) => GetDebugAmountData();

        public async Task<IList<ChartData>> GetAmountDataForCategoryAsync(CategoryType category)
        {
            return await Task.Run(() => GetDebugAmountData());
        }

        public IList<ChartData> GetCitiesDataForCategory(CategoryType category) => GetDebugCitiesData();

        public async Task<IList<ChartData>> GetCitiesDataForCategoryAsync(CategoryType category)
        {
            return await Task.Run(() => GetDebugCitiesData());
        }

        public IList<ChartData> GetPercentageDataForCategory(CategoryType category) => GetDebugPercentageData();

        public async Task<IList<ChartData>> GetPercentageDataForCategoryAsync(CategoryType category)
        {
            return await Task.Run(() => GetDebugPercentageData());
        }

        private Random NumberGenerator { get; set; }

        private IList<ChartData> GetDebugAmountData()
        {
            return new List<ChartData>
                {
                    new ChartData
                    {
                        Value = NumberGenerator.Next(50, 150),
                        Label = "febrary"
                    },
                    new ChartData
                    {
                        Value = NumberGenerator.Next(50, 150),
                        Label = "march"
                    },
                    new ChartData
                    {
                        Value = NumberGenerator.Next(50, 150),
                        Label = "april"
                    },
                    new ChartData
                    {
                        Value = NumberGenerator.Next(50, 150),
                        Label = "may"
                    }
                };
        }

        private IList<ChartData> GetDebugPercentageData()
        {
            return new List<ChartData>
                {
                    new ChartData
                    {
                        Value = (float)NumberGenerator.NextDouble(),
                        Label = "febrary"
                    },
                    new ChartData
                    {
                        Value = (float)NumberGenerator.NextDouble(),
                        Label = "march"
                    },
                    new ChartData
                    {
                        Value = (float)NumberGenerator.NextDouble(),
                        Label = "april"
                    },
                    new ChartData
                    {
                        Value = (float)NumberGenerator.NextDouble(),
                        Label = "may"
                    }
                };
        }

        private IList<ChartData> GetDebugCitiesData()
        {
            return new List<ChartData>
                {
                    new ChartData
                    {
                        Value = NumberGenerator.Next(50, 150),
                        Label = "Bogota"
                    },
                    new ChartData
                    {
                        Value = NumberGenerator.Next(50, 150),
                        Label = "Medellin"
                    },
                    new ChartData
                    {
                        Value = NumberGenerator.Next(50, 150),
                        Label = "Cartaagena"
                    },
                    new ChartData
                    {
                        Value = NumberGenerator.Next(50, 150),
                        Label = "Cali"
                    }
                };
        }
    }
}
