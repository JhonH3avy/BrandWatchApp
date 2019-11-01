using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesisFrontEnd.Models;

namespace TesisFrontEnd.Services
{
    public interface IApiClient
    {
        IList<ChartData> GetAmountDataForCategory(CategoryType category);
        IList<ChartData> GetPercentageDataForCategory(CategoryType category);
        IList<ChartData> GetCitiesDataForCategory(CategoryType category);

        Task<IList<ChartData>> GetAmountDataForCategoryAsync(CategoryType category);
        Task<IList<ChartData>> GetPercentageDataForCategoryAsync(CategoryType category);
        Task<IList<ChartData>> GetCitiesDataForCategoryAsync(CategoryType category);
    }
}
