using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesisFrontEnd.Models;

namespace TesisFrontEnd.Services
{
    public class DebugApiClient : IApiClient
    {
        public IList<ChartData> GetDataForCategory(string category) => GetDebugData();

        public async Task<IList<ChartData>> GetDataForCategoryAsync(string category)
        {
            return await Task.Run(() => GetDebugData());
        }

        private IList<ChartData> GetDebugData()
        {
            return new List<ChartData>
            {
                new ChartData
                {
                    Value = 100,
                    Label = "febrary"
                },
                new ChartData
                {
                    Value = 200,
                    Label = "march"
                },
                new ChartData
                {
                    Value = 150,
                    Label = "april"
                },
                new ChartData
                {
                    Value = 80,
                    Label = "may"
                }
            };
        }
    }
}
