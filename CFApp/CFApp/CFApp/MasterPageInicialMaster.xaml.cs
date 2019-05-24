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

namespace CFApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageInicialMaster : ContentPage
    {
        public ListView ListView;

        public MasterPageInicialMaster()
        {
            InitializeComponent();

            BindingContext = new MasterPageInicialMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterPageInicialMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterPageInicialMenuItem> MenuItems { get; set; }
            
            public MasterPageInicialMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterPageInicialMenuItem>(new[]
                {
                    new MasterPageInicialMenuItem { Id = 0, Title = "Page 1" },
                    new MasterPageInicialMenuItem { Id = 1, Title = "Page 2" },
                    new MasterPageInicialMenuItem { Id = 2, Title = "Page 3" },
                    new MasterPageInicialMenuItem { Id = 3, Title = "Page 4" },
                    new MasterPageInicialMenuItem { Id = 4, Title = "Page 5" },
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