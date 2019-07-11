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
        TipoConsultaService tipoConsultaService;
        List<Consulta> consultas;
        List<Medico> medicos;
        List<Posto> postos;
        List<TipoConsulta> tipoConsultas;
        public MarcarConsulta()
        {
            InitializeComponent();
            consultaService = new ConsultaService();
            medicoService = new MedicoService();
            postoService = new PostoService();
            tipoConsultaService = new TipoConsultaService();
        }
        private async void btnMarcarConsulta(object sender, EventArgs e)
        {

            Consulta consulta = new Consulta
            {

            };


            //await dataService.AddProdutoAsync(novoProduto);
            //LimpaProduto();
            //AtualizaDados();


        }
        private async Task<List<Medico>> ListarMedicos(object sender, EventArgs e)
        {

            medicos = await medicoService.GetMedicoAsync();
            return medicos;

        }

    }

}

