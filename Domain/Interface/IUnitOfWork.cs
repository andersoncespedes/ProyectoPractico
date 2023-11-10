using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interface;
public interface IUnitOfWork
{
    ICargo Cargos {get;}
    ICiudad Ciudades {get;}
    IColor Colores {get;}
    IDepartamento Departamentos {get;}
    IDetalleOrden DetalleOrdenes {get;}
    IDetalleVenta DetalleVentas {get;}
    IEmpleado Empleados {get;}
    IFormaPago FormaPagos {get;}
    IGenero Generos {get;}
    IInsumo Insumos {get;}
    IOrden Ordenes {get;}
    IPais Paises {get;}
    IPrenda Prendas {get;}
    IProducto Productos {get;}
    IProveedor Proveedores {get;}
    IRefreshToken RefreshTokens {get;}
    IRol Roles {get;}
    IStatus Status {get;}
    ITalla Tallas {get;}
    ITipoEstado TipoEstados {get;}
    ITipoPersona TipoPersonas {get;}
    ITipoProteccion TipoProtecciones {get;}
    IUser Users {get;}
    IVenta Ventas {get;}
}
