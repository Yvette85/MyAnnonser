using Dapper;
using MyAnnonser.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyAnnonser.Repository
{
    public class AdsRepository
    {


        public SqlConnection con;
        public List<Ads> GetAllAds()
        {




            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["AnnonserConnection"].ToString()))
            {



                string readSp = "GetAllAdvert";
                return db.Query<Ads>(readSp, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }

}

//        public SqlConnection con;


//        private void connection()
//        {



//            var constr = ConfigurationManager.ConnectionStrings["AnnonserConnection"].ToString();

//            con = new SqlConnection(constr);

//        }

//        public List<Ads> GetAllAds()
//        {
//            try
//            {
//                connection();
//                //con.Open();
//                con.Execute("GetAllAds", commandType: CommandType.StoredProcedure);
//                //con.Close();

//                IList<Ads> Ad = SqlMapper.Query<Ads>(con, "GetAllAds").ToList();
//                return Ad.ToList();




//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//    }
//}

