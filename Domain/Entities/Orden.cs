using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Orden : BaseEntity
{
    public DateOnly Fecha {get; set;}
    public int IdEmpleadoFk {get; set;}
    public Empleado Empleado {get; set;}
    public int IdClienteFk {get;set;}
    public Cliente Cliente {get; set;}
    public int IdEstadoFk {get; set;}
    public Status Status {get; set;}
}
