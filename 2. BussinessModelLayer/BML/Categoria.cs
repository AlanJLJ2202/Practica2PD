﻿using Dapper;
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
        public int idCategoria { get; set; }
        public string descripcion { get; set; }

        public bool activo { get; set; }

        public Categoria()
        {

        }


        /*
        public IEnumerable<Categoria> GetAll()
        {
           

            
        }*/

    }
}
