using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string ComnayName { get; set; } = string.Empty;
        //esto se pone para forzar a la DB en SQL que solo admita
        //18 digitos y 2 lugares decimales despues de la coma
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }

        //relation one to many
        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}