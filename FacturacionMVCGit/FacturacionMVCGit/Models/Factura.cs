using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace FacturacionMVCGit.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public string Nit { get; set; }
        public DateTime Fecha { get; set; }
        public decimal CalcularTotal(decimal subtotal)
        {
            
            subtotal -= subtotal * (decimal)0.13;
            // agregamos el impuesto
            subtotal -= subtotal * (decimal)0.10;
            return subtotal;
        }
    }
}
