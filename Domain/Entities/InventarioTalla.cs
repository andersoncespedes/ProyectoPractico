using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
    public class InventarioTalla 
    {
        public int IdTallaFk {get; set;}
        public Talla Talla {get; set;}
        public int IdInvFk {get; set;}
        public Producto Producto {get; set;}
    }
