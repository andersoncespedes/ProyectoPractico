using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data;
public class APIContext : DbContext
{
    public DbSet<Cargo> Cargos {get; set;}
    public DbSet<Ciudad> Ciudades {get; set;}
    public DbSet<Cliente> Clientes {get; set;}
    public DbSet<Color> Colores {get; set;}
    public DbSet<Departamento> Departamentos {get;set;}
    public DbSet<DetalleOrden> DetalleOrdenes {get; set;}
    public DbSet<DetalleVenta> DetalleVentas {get; set;}
    public DbSet<Empleado> Empleados {get; set;}
    public DbSet<Empresa> Empresas {get; set;}
    public DbSet<FormaPago> FormaPagos {get; set;}
    public DbSet<Genero> Generos {get; set;}
    public DbSet<Insumo> Insumos {get; set;}
    public DbSet<Orden> Ordenes {get; set;}
    public DbSet<Pais> Paises {get; set;}
    public DbSet<Prenda> Prendas {get; set;}
    public DbSet<Producto> Productos {get; set;}
    public DbSet<Proveedor> Proveedores {get; set;}
    public DbSet<RefreshToken> RefreshTokens {get; set;}
    public DbSet<Rol> Roles {get; set;}
    public DbSet<Status> Status {get; set;}
    public DbSet<Talla> Tallas {get; set;}
    public DbSet<TipoEstado> TipoEstados {get; set;}
    public DbSet<TipoPersona> TipoPersonas {get; set;}
    public DbSet<TipoProteccion> TipoProtecciones {get; set;}
    public DbSet<User> Users {get; set;}
    public DbSet<Venta> Ventas {get; set;} 

    public APIContext(DbContextOptions<APIContext> options) : base(options){

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}