using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFApp.Models
{
    public class Posto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
    }

    public class _Posto
    {
        public Posto Posto { get; set; }
    }
}
