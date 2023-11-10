using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interface;
using Persistence.Data;

namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
    private readonly APIContext _context;
    private ICargo _cargos; 

    private ICiudad _ciudades;

    private IColor _colores;

    private IDepartamento _departamentos; 

    private IDetalleOrden _detalleOrdenes;

    private IDetalleVenta _detalleVentas ;

    private IEmpleado _empleados ;

    private IFormaPago _formaPagos ;

    private IGenero _generos ;

    private IInsumo _insumos;

    private IOrden _ordenes;

    private IPais _paises; 

    private IPrenda _prendas ;

    private IProducto _productos ;

    private IProveedor _proveedores;

    private IRefreshToken _refreshTokens;

    private IRol _roles; 

    private IStatus _status;

    private ITalla _tallas; 

    private ITipoEstado _tipoEstados;

    private ITipoPersona _tipoPersonas;

    private ITipoProteccion _tipoProtecciones;

    private IUser _users;

    private IVenta _ventas;
    public UnitOfWork(APIContext context){
        _context = context;
    }
    public ICargo Cargos {get{
        _cargos ??= new (_context);
    }}

    public ICiudad Ciudades {get{}}

    public IColor Colores {get{}}

    public IDepartamento Departamentos {get{}}

    public IDetalleOrden DetalleOrdenes {get{}}

    public IDetalleVenta DetalleVentas {get{}}

    public IEmpleado Empleados {get{}}

    public IFormaPago FormaPagos {get{}}

    public IGenero Generos {get{}}

    public IInsumo Insumos {get{}}

    public IOrden Ordenes {get{}}

    public IPais Paises {get{}}

    public IPrenda Prendas {get{}}

    public IProducto Productos {get{}}

    public IProveedor Proveedores {get{}}

    public IRefreshToken RefreshTokens {get{}}

    public IRol Roles {get{}}

    public IStatus Status {get{}}

    public ITalla Tallas {get{}}

    public ITipoEstado TipoEstados {get{}}

    public ITipoPersona TipoPersonas {get{}}

    public ITipoProteccion TipoProtecciones {get{}}

    public IUser Users {get{}}

    public IVenta Ventas {get{}}
}
