using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Cliente
    {
        public DataAccess dataAccess = DataAccess.Instance();

        public int idCliente { get; set; }

        public string nombre { get; set; }

        public string apMaterno { get; set; }

        public string apPaterno { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public string cp { get; set; }

        public bool activo { get; set; }

       
        public Cliente() { }


        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@apMaterno", apMaterno);
            parameters.Add("@apPaterno", apPaterno);
            parameters.Add("@direccion", direccion);
            parameters.Add("@telefono", telefono);
            parameters.Add("@cp", cp);
            return dataAccess.Execute("stp_clientes_add", parameters);
        }



        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCliente", idCliente);
            return dataAccess.Execute("stp_clientes_delete", parameters);
        }


        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCliente", idCliente);
            parameters.Add("@nombre", nombre);
            parameters.Add("@apMaterno", apMaterno);
            parameters.Add("@apPaterno", apPaterno);
            parameters.Add("@direccion", direccion);
            parameters.Add("@telefono", telefono);
            parameters.Add("@cp", cp);
            return dataAccess.Execute("stp_clientes_update", parameters);
        }


        public IEnumerable<Cliente> GetAll()
        {
            return dataAccess.Query<Cliente>("stp_clientes_getall");
        }


        public Cliente GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCliente", idCliente);
            return dataAccess.QuerySingle<Cliente>("stp_clientes_getbyid", parameters);
        }
    }
}
