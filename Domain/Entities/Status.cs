using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities; 
    public class Status : BaseEntity
    {
        public string Descripcion {get; set;}
        public int IdTipoEstadoFk {get; set;}
        public TipoEstado TipoEstado {get; set;}
        public ICollection<Prenda> Prendas {get; set;}
        public ICollection<Orden> Ordenes {get; set;}
        public ICollection<DetalleOrden> DetalleOrdenes {get; set;}
    }
