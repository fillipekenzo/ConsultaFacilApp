using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFApp.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PostoId { get; set; }
        public int MedicoId { get; set; }
        public int TipoConsultaId { get; set; }
        public string DataHora { get; set; }
    }

    public class _Consulta
    {
        public Consulta Consulta { get; set; }
    }
}
