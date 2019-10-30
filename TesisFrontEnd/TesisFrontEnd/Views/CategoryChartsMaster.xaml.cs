using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesisFrontEnd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryChartsMaster : ContentPage
    {
        public ListView ListView;

        public CategoryChartsMaster()
        {
            InitializeComponent();

            BindingContext = new CategoryChartsMasterViewModel();
            ListView = MenuItemsListView;
        }

        class CategoryChartsMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<CategoryChartsMasterMenuItem> MenuItems { get; set; }

            public CategoryChartsMasterViewModel()
            {
                MenuItems = new ObservableCollection<CategoryChartsMasterMenuItem>(new[]
                {
                    new CategoryChartsMasterMenuItem { Id = 0, Title = "General", TargetType = typeof(GeneralCharts) },
                    new CategoryChartsMasterMenuItem { Id = 1, Title = "Tickets", TargetType = typeof(TicketsCharts) },
                    new CategoryChartsMasterMenuItem { Id = 2, Title = "Atención al usuarios", TargetType = typeof(UserAttentionCharts) },
                    new CategoryChartsMasterMenuItem { Id = 3, Title = "Experiencia de usario", TargetType = typeof(UserExperienceCharts) },
                    new CategoryChartsMasterMenuItem { Id = 4, Title = "Créditos", TargetType = typeof(Credits) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}