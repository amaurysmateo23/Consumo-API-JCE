using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class Usuarios :IdentityUser
{
    public int UsuariosId { get; set; }
    [Required]
    public string Password { get; set; }
    public string Nombres { get; set; }

    public string Apellido1 { get; set; }

    public string Apellido2 { get; set; }

    public string foto { get; set; }
    [Required]
    public string Cedula { get; set; }

    public List<Secretos> secretos = new List<Secretos>();
    
}