using System.ComponentModel.DataAnnotations; 

namespace Lab3_OsmarAnccoE.Dtos
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        public string Phonenumber { get; set; } = null!;

        [Required(ErrorMessage = "El DNI es obligatorio.")]
        [StringLength(8)]
        public string Dni { get; set; } = null!;

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string Password { get; set; } = null!;

        public Guid? RoleId { get; set; }
        
        public bool Status { get; set; } = true;
    }
}