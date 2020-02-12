using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Usuario
    {
        public string Nome { get; set; }

        public Usuario(string texto)
        {
            this.Nome = texto;
        }
    }
}
