using System;
using System.Collections.Generic;

namespace TioSoft.Models;

public partial class RolPermiso
{
    public int IdRolPermiso { get; set; }

    public int? IdPermiso { get; set; }

    public int? IdRol { get; set; }

    public virtual Permiso? IdPermisoNavigation { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }
}
