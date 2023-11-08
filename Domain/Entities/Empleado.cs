using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Empleado : BaseEntity
{
    public string IdEmp {get; set;}
    public string Nombre {get; set;}
    public int IdCargoFk {get; set;}
    public Cargo Cargo {get; set;}
    public DateOnly FechaIngreso {get; set;}
    public int IdCiudadFk {get; set;}
    public Ciudad Ciudad {get; set;}
    public ICollection<Venta> Ventas {get; set;}
    public ICollection<Orden> Ordenes {get; set;}
}