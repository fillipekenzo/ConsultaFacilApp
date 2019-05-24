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
                    new MasterPageInicialMenuItem { Id = 0, Title = "Home" },
                    new MasterPageInicialMenuItem { Id = 1, Title = "Minhas Consultas" }
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