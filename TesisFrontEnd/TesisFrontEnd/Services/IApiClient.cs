using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesisFrontEnd.Models;

namespace TesisFrontEnd.Services
{
    public interface IApiClient
    {
        IList<ChartData> GetDataForCategory(string category);

        Task<IList<ChartData>> GetDataForCategoryAsync(string category);
    }
}
