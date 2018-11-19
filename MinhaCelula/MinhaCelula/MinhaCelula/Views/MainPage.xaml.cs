using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MinhaCelula.Models;
using System.Collections.ObjectModel;
using MinhaCelula.Services;

namespace MinhaCelula.Views
{
	public partial class MainPage : MasterDetailPage
	{
        public MainPage ()
		{
			InitializeComponent ();

            // Define a propriedade ItemSource da pagina MainPage.xaml
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Models.MenuItem)e.SelectedItem;
            //obtem o tipo de objeto 
            Type pagina = item.TargetType;

            //abre a pagina correspondente ao item selecionado
            //Cria uma instância do tipo especificado usando o construtor
            //que melhor se adequa ao parametro informado
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            IsPresented = false;
        }

    }
}