using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
    public class Cliente : BaseEntity
    {
        public string IdCliente {get; set;}
        public string Nombre {get; set;}
        public int IdTipoPersona {get; set;}
        public TipoPersona TipoPersona {get; set;}
        public DateOnly FechaRegistro {get; set;}
        public int IdCiudadFk {get; set;}
        public Ciudad Ciudad {get; set;}
        public ICollection<Orden> Ordenes {get; set;}
    }
