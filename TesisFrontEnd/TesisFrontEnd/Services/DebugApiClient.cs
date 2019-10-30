using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesisFrontEnd.Models;

namespace TesisFrontEnd.Services
{
    public class DebugApiClient : IApiClient
    {
        public IList<ChartData> GetDataForCategory(string category)
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
                    Label = "april"
                }
            };
        }

        public Task<IList<ChartData>> GetDataForCategoryAsync(string category)
        {
            return new Task<IList<ChartData>>(() => new List<ChartData>
            {
                new ChartData
                {
                    Value = 100,
                    Label = "febrary"
                },
                new ChartData
                {
                    Value = 200,
                    Label = "april"
                }
            });
        }
    }
}
