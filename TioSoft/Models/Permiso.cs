using System;
using System.Collections.Generic;

namespace TioSoft.Models;

public partial class Permiso
{
    public int IdPermiso { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();
}
