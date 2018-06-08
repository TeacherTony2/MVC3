﻿using MvcApplication1.Helper;
using MvcApplication1.Models;
using MvcApplication1.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MvcApplication1.Services
{
    public class AuthServices : IAuthServices
    {
        public AuthServices() {  }

        public List<Auth> GetAll() 
        {
            string sql = "SELECT * FROM [Auth]";
            var datatable = SqlHelper.ExecuteDataTable(sql, CommandType.Text, null);
            var result = ConvertHelper.GetEntities<Auth>(datatable).ToList();
            return result;
        }

        public void Insert(Auth auth)
        {
            string sql = "INSERT [Auth](url) VALUES(@url);";
            var parms = ConvertHelper.ToSqlParameterArray<Auth>(auth);
            SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parms);
        }
        
    }
}