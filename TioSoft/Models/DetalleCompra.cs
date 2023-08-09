using System;
using System.Collections.Generic;

namespace TioSoft.Models;

public partial class DetalleCompra
{
    public int IdDetalleCompra { get; set; }

    public int? IdCompra { get; set; }

    public string? NombreProducto { get; set; }

    public int? Cantidad { get; set; }

    public int? IdProducto { get; set; }

    public decimal? Total { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Compra? IdCompraNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
