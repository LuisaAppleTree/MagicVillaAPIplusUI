using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelo.Dto
{
    public class VillaCreateDto
    {
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        [Required]
        public float Tarifa { get; set; }
        public int Ocupantes { get; set; }
        public float MetrosCuadrados { get; set; }
        public string ImagenUrl { get; set; }
        public string Amenidad { get; set; }
    }
}

