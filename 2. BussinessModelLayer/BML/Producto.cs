using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Producto
    {
        public DataAccess dataAccess = DataAccess.Instance();

        public int idProducto { get; set; }

        public string descripcion { get; set; }

        public int idCategoria { get; set; }

        public decimal precioUnitario { get; set; }

        public int stock { get; set; }

        public string codigo { get; set; }

        public int idMarca { get; set; }

        public bool activo { get; set; }

        public Producto() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@descripcion", descripcion);
            parameters.Add("@idCategoria", idCategoria);
            parameters.Add("@precioUnitario", precioUnitario);
            parameters.Add("@stock", stock);
            parameters.Add("@codigo", codigo);
            parameters.Add("@idMarca", idMarca);
            return dataAccess.Execute("stp_productos_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProducto", idProducto);
            return dataAccess.Execute("stp_productos_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCategoria", idCategoria);
            parameters.Add("@descripcion", descripcion);
            parameters.Add("@idCategoria", idCategoria);
            parameters.Add("@precioUnitario", precioUnitario);
            parameters.Add("@stock", stock);
            parameters.Add("@codigo", codigo);
            parameters.Add("@idMarca", idMarca);
            return dataAccess.Execute("stp_productos_update", parameters);
        }


        public IEnumerable<Producto> GetAll()
        {
            return dataAccess.Query<Producto>("stp_productos_getall");
        }


        public Producto GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProducto", idProducto);
            return dataAccess.QuerySingle<Producto>("stp_productos_getbyid", parameters);
        }

        public Producto GetByCodigo()
        { 
            var parameters = new DynamicParameters();
            parameters.Add("@codigo", codigo);
            return dataAccess.QuerySingle<Producto>("stp_productos_getbycodigo", parameters);
        }
    }
}
