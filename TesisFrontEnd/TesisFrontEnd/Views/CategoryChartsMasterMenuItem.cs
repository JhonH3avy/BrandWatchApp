using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesisFrontEnd.Views
{

    public class CategoryChartsMasterMenuItem
    {
        public CategoryChartsMasterMenuItem()
        {
            TargetType = typeof(CategoryChartsMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}