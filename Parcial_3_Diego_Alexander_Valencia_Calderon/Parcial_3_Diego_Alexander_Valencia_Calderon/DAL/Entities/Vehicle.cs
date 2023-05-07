using System.ComponentModel.DataAnnotations;

namespace Parcial3_ValenciaCalderonDiegoAlexander.DAL.Entities
{
    public class Vehicle
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string Owner { get; set; }
        public string NumberPlate { get; set; }

    }
}
