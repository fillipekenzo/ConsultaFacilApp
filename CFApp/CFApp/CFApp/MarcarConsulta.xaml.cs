using CFApp.Models;
using CFApp.Service;
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
    public partial class MarcarConsulta : ContentPage
    {
        ConsultaService consultaService;
        MedicoService medicoService;
        PostoService postoService;
        TipoConsultaService tipoConsulta;
        List<Consulta> consultas;
        List<Medico> medicos;
        List<Posto> postos;
        List<TipoConsulta> tipoConsultas;
        public MarcarConsulta()
        {
            InitializeComponent();
            consultaService = new ConsultaService();
        }         
	}
}