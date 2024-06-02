using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Sql_Server.Entidades
{
    internal class Produto
    {
        [Key]
        public int Id { get; set; }
        public string NomeProd { get; set; }
        public double PrecoProd { get; set; }
        public string DescricaoProd { get; set; }
        public int QuantidadeProd { get; set; }
        public int AvaliacaoProd { get; set; }
        public string CategoriaProd { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}
