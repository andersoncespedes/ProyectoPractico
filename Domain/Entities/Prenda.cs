using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
    public class Prenda : BaseEntity
    {
        public string IdPrenda {get; set;}
        public string Nombre {get; set;}
        public double ValorUnitCop {get; set;}
        public double ValorUnitUsd {get; set;}
        public int IdStatusFk {get; set;}
        public Status Status {get; set;}
        public int IdTipoProteccion {get; set;}
        public TipoProteccion TipoProteccion {get; set;}
        public int IdGeneroFk {get; set;}
        public Genero Genero {get; set;}
        public ICollection<Insumo> Insumos {get; set;} 
        public ICollection<InsumoPrenda> InsumoPrendas {get; set;}
        public ICollection<DetalleOrden> DetalleOrdenes {get; set;}
    }
