using System;
using System.Collections.Generic;

namespace DL;

public partial class Usuario
{
    public int Idusuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string HashContraseña { get; set; } = null!;

    public string Email { get; set; } = null!;
}
