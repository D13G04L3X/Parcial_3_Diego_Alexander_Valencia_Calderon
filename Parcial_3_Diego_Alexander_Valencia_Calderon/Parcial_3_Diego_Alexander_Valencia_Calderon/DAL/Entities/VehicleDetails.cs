using System.ComponentModel.DataAnnotations;

namespace Parcial3_ValenciaCalderonDiegoAlexander.DAL.Entities
{
    public class VehicleDetails
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
