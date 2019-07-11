using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFApp.Models
{
    public class TipoConsulta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class _TipoConsulta
    {
        public TipoConsulta TipoConsulta { get; set; }
    }
}
