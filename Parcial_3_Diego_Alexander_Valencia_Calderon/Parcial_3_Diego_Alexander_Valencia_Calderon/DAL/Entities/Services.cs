using System.ComponentModel.DataAnnotations;

namespace Parcial3_ValenciaCalderonDiegoAlexander.DAL.Entities
{
    public class Services : Entity
    {
       
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Precio del Servicio")]
        public decimal Price { get; set; }

    }
}
