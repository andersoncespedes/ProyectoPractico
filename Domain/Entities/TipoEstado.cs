using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
public class TipoEstado : BaseEntity
{
    public string Descripcion {get; set;}
    public ICollection<Status> Estados {get; set;}
}