using System.ComponentModel.DataAnnotations;

namespace Parcial3_ValenciaCalderonDiegoAlexander.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
