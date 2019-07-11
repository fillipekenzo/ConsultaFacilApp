using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string NumeroSus { get; set; }
        public string Email { get; set; }
    }

    public class _Usuario
    {
        public Usuario Usuario { get; set; }
    }
}
