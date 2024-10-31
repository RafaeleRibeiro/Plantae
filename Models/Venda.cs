using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Plantae.Models
{
    public class Venda
    {
        [Key]
        public Guid VendaId { get; set; } = Guid.NewGuid();
        public DateTime DataEmissao { get; set; } = DateTime.Now;

        [ForeignKey("ClienteId")]
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("PlantaId")]
        public Guid PlantaId { get; set; }
        public Planta? Planta { get; set; }
    }
}
