using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Marca
    {

        public DataAccess dataAccess = DataAccess.Instance();
        public int idMarca { get; set; }
        public string descripcion { get; set; }

        public bool activo { get; set; }

        public Marca()
        {

        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_marcas_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idMarca", idMarca);
            return dataAccess.Execute("stp_marcas_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idMarca", idMarca);
            parameters.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_marcas_update", parameters);
        }


        public IEnumerable<Marca> GetAll()
        {
            return dataAccess.Query<Marca>("stp_marcas_getall");
        }


        public Marca GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idMarca", idMarca);
            return dataAccess.QuerySingle<Marca>("stp_marcas_getbyid", parameters);
        }

    }
}
