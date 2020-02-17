using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VR_DocInjection.Models;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace VR_DocInjection.DB_Access
{

    public static class ERM_DataFetch
    {
        readonly static string  ERM_string = "Data Source=erm-sqldev;Initial Catalog=ERM-QA;Persist Security Info=True;User ID=yfDBA;Password=2017YFolderSQLdev!@";

        public static List<ERM_BatchDetails> GetBatchDetails()
        {
            List<ERM_BatchDetails> eRM_BatchDetails = new List<ERM_BatchDetails>();

            eRM_BatchDetails.Add(new ERM_BatchDetails() { batch_name = "ANTD01072019-1377592_ANT_SR_Categorize Scan", pk_batch_id = 1377592, verification_required_path = @"C:\Users\Dibya.Rath\Downloads\VR_DocInjection\BATCH\" });
            eRM_BatchDetails.Add(new ERM_BatchDetails() { batch_name = "ANTD01072019-1377593_ANT_SR_Categorize Scan", pk_batch_id = 1377593, verification_required_path = @"C:\Users\Dibya.Rath\Downloads\VR_DocInjection\BATCH\" }); 
            eRM_BatchDetails.Add(new ERM_BatchDetails() { batch_name = "ANTD01072019-1377594_ANT_SR_Categorize Scan", pk_batch_id = 1377594, verification_required_path = @"C:\Users\Dibya.Rath\Downloads\VR_DocInjection\BATCH\" }); 
            eRM_BatchDetails.Add(new ERM_BatchDetails() { batch_name = "ANTD01072019-1377595_ANT_SR_Categorize Scan", pk_batch_id = 1377595, verification_required_path = @"C:\Users\Dibya.Rath\Downloads\VR_DocInjection\BATCH\" });
            eRM_BatchDetails.Add(new ERM_BatchDetails() { batch_name = "ANTD01072019-1377596_ANT_SR_Categorize Scan", pk_batch_id = 1377596, verification_required_path = @"C:\Users\Dibya.Rath\Downloads\VR_DocInjection\BATCH\" });

            //string query = "SELECT top 10  bth.pk_batch_id,bth.batch_name,rsam.verification_required_path FROM batch bth " +
            //    " JOIN dbo.recods_series_account_mapping rsam " +
            //    " ON bth.fk_account_id = rsam.fk_account_id " +
            //    " WHERE bth.fk_batch_status_id = 17 ";
            //using (IDbConnection db = new SqlConnection(ERM_string))
            //{
            //    try
            //    {
            //        db.Open();
            //        eRM_BatchDetails = db.Query<ERM_BatchDetails>(query).ToList();
            //    }
            //    catch (Exception ee)
            //    {

            //        throw ee;
            //    }
            //    finally
            //    {
            //        db.Close();
            //    }

            //}

            return eRM_BatchDetails;
        }
    }
}
