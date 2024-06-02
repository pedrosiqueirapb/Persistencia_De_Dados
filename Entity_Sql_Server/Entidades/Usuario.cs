using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Sql_Server.Entidades
{
    internal class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string NomeUser { get; set; }
        public string EmailUser { get; set; }
        public string SenhaUser { get; set; }
        public string EnderecoUser { get; set; }
        public string? LembreteSenha { get; set; }
        public int IdadeUser { get; set; }
        public char SexoUser { get; set; }
    }
}
