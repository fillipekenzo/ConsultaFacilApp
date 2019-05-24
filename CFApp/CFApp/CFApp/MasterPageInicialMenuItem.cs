using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFApp
{

    public class MasterPageInicialMenuItem
    {
        public MasterPageInicialMenuItem()
        {
            TargetType = typeof(MasterPageInicialDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}