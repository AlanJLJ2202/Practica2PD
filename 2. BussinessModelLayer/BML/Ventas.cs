using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Ventas
    {
        public DataAccess dataAccess = DataAccess.Instance();


        public int idVenta { get; set; }

        public int folio { get; set; }

        public DateTime fecha { get; set; }

        public int cantidad { get; set; }

        public decimal importe { get; set; }

        public int descuento { get; set; }

        public decimal total { get; set; }

        public string estatus { get; set; }

        public int idCliente { get; set; }

        public int idUsuario { get; set; }

        public bool activo { get; set; }


        public Ventas() { }


        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@folio", folio);
            parameters.Add("@fecha", fecha);
            parameters.Add("@cantidad", cantidad);
            parameters.Add("@importe", importe);
            parameters.Add("@descuento", descuento);
            parameters.Add("@total", total);
            parameters.Add("@estatus", estatus);
            parameters.Add("@idCliente", idCliente);
            parameters.Add("@idUsuario", idUsuario);
            return dataAccess.Execute("stp_ventas_add", parameters);
        }



        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            return dataAccess.Execute("stp_ventas_delete", parameters);
        }


        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            parameters.Add("@folio", folio);
            parameters.Add("@fecha", fecha);
            parameters.Add("@cantidad", cantidad);
            parameters.Add("@importe", importe);
            parameters.Add("@descuento", descuento);
            parameters.Add("@total", total);
            parameters.Add("@estatus", estatus);
            parameters.Add("@idCliente", idCliente);
            parameters.Add("@idUsuario", idUsuario);
            return dataAccess.Execute("stp_ventas_update", parameters);
        }


        public IEnumerable<Ventas> GetAll()
        {
            return dataAccess.Query<Ventas>("stp_ventas_getall");
        }


        public Ventas GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            return dataAccess.QuerySingle<Ventas>("stp_ventas_getbyid", parameters);
        }

    }
}
