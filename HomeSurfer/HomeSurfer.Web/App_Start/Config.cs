using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace HomeSurfer.Web.App_Start
{
    public class Config
    {
        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionString"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionString"].ToString();
                }

                return "DefaultConnection";
            }
        }

        public static string UsersTableName
        {
            get
            {
                if (ConfigurationManager.AppSettings["UsersTableName"] != null)
                {
                    return ConfigurationManager.AppSettings["UsersTableName"].ToString();
                }

                return "Users";
            }
        }

        public static string UsersPrimaryKeyColumnName
        {
            get
            {
                if (ConfigurationManager.AppSettings["UsersPrimaryKeyColumnName"] != null)
                {
                    return ConfigurationManager.AppSettings["UsersPrimaryKeyColumnName"].ToString();
                }

                return "Id";
            }
        }

        public static string UserNameColumnName
        {
            get
            {
                if (ConfigurationManager.AppSettings["UserNameColumnName"] != null)
                {
                    return ConfigurationManager.AppSettings["UserNameColumnName"].ToString();
                }

                return "Username";
            }
        }
    }
}