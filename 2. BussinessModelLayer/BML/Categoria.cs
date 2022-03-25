using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Categoria
    {
        public DataAccess dataAccess = DataAccess.Instance();

        public int idCategoria { get; set; }
        public string descripcion { get; set; }

        public bool activo { get; set; }

        public Categoria()
        {

        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_categorias_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCategoria", idCategoria);
            return dataAccess.Execute("stp_categorias_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCategoria", idCategoria);
            parameters.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_categorias_update", parameters);
        }


        public IEnumerable<Categoria> GetAll()
        {
            return dataAccess.Query<Categoria>("stp_categorias_getall");
        }


        public Categoria GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCategoria", idCategoria);
            return dataAccess.QuerySingle<Categoria>("stp_categorias_getbyid", parameters);
        }






        /*
        public IEnumerable<Categoria> GetAll()
        {
           

            
        }*/

    }
}
