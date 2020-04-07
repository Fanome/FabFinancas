using FabFinancas.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FabFinancas.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public DateTime dataNascmento { get; set; }
        public string email { get; set; }
        public UsuarioStatus status { get; set; }

    }
}
