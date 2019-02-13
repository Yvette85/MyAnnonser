using Dapper;
using MyAnnonser.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyAnnonser.Repository
{
    public class AdsRepository
    {



        public SqlConnection con;

        private void connection()
        {

            var constr = ConfigurationManager.ConnectionStrings["AnnonserConnection"].ToString();

            con = new SqlConnection(constr);

        }

        public List<Ads> GetAllAds()
        {
            try
            {
                connection();
                //con.Open();
                con.Execute("GetAllAds", commandType: CommandType.StoredProcedure);
                //con.Query("GetAllAds", commandType: CommandType.StoredProcedure);
                //con.Close();

                //IList<Ads> Ad = SqlMapper.Query<Ads>(con, "GetAllAds").ToList();

                var myList = con.Query<Ads>("GetAllAds").ToList();


                return myList;

            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Advertisers> GetAllAdvert()
        {
            try
            {
                connection();
                //con.Open();
                con.Query("GetAllAdvertisers", commandType: CommandType.StoredProcedure);
                //con.Close();

                //IList<Advertisers> Adt = SqlMapper.Query<Advertisers>(con, "GetAllAdvertisers").ToList();
                var myList = con.Query<Advertisers>("GetAllAdvertisers").ToList();

                return myList;

            }
            catch (Exception)
            {
                throw;
            }
        }



        public void  AddAnns(Ads ad)
        {
            try
            {
      
                connection();
                SqlCommand com = new SqlCommand("AddNewAnnons", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@AdId", ad.UniqueId);
                com.Parameters.AddWithValue("@Adheadline", ad.AdHeadline);
                com.Parameters.AddWithValue("@AdText", ad.AdText);
                com.Parameters.AddWithValue("@AdvertiserId", ad.AdvertiserId);
                int i = com.ExecuteNonQuery();
                con.Close();
                
            }

         

            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Update AnnonsDetails

        public void UpdateAnnons(Ads ad)
        {
            try
            {
                connection();
                con.Execute("UpdateAnnsDetails", ad, commandType: CommandType.StoredProcedure);

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Delete Annons Details
        public bool DeleteAnnons(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AdId", Id);
                connection();
                con.Execute("DeleteAnnsById", param, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
    }

}

