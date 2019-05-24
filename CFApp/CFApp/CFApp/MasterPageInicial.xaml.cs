using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CFApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageInicial : MasterDetailPage
    {
        public MasterPageInicial()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageInicialMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            //Detail = new NavigationPage(page);

            switch (item.Id)
            {
                case 0:
                    Detail = new NavigationPage(new Home());
                    break;
                case 1:
                    Detail = new NavigationPage(new MinhasConsultas());
                    break;
            }

            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}