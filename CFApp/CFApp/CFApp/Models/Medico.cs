using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFApp.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PostoId { get; set; }
        public int TipoConsultaId { get; set; }
    }

    public class _Medico
    {
        public Medico Medico { get; set; }
    }
}
