using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using VR_DocInjection.Models;
using System.Data;
using System.Data.SqlClient;

namespace VR_DocInjection.DB_Access
{
    public static class DMS_DataOperation
    {
        //public static string strConnection = "Data Source=dc1-dms-sql-a01;Initial Catalog=yf***;User ID=yfDBA;Password=r5p4W7m2X5OuEsqXk48P";
        public static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TEST;Integrated Security=True";

        public static int AddDataToVRBatchDocInj(string BatchName, int Status, string alias)
        {
            int _isBatchID = 0;
            string query = "DECLARE @ID int; " +
                " INSERT INTO [dbo].[mVRBatchDocInj] " +
                " ([BatchName],[Status],[JobStarted] ,JobCompleted) " +
                " VALUES ( '"+BatchName+"', "+ Status + ", getdate(), getdate()) " +
                " SET @ID = SCOPE_IDENTITY();  " + 
                " SELECT @ID";

            mVRBatchDocInj MVRBatchDocInj = new mVRBatchDocInj()
            {
                BatchName = BatchName,
                JobStarted = DateTime.Now,
                Status = Status
            };

            using (IDbConnection db = new SqlConnection(strConnection.Replace("***", alias)))
            {
                try
                {
                    db.Open();
                    _isBatchID = db.Query<int>(query, MVRBatchDocInj).Single();

                }
                catch (Exception ee)
                {

                    throw ee;
                }
                finally
                {
                    db.Close();
                }

            }
            return _isBatchID;
        }

        public static bool AddDataToVRDocDetails(List<SROutPut> SROutPuts, int batchID , string Alias, string RS)
        {
            bool _isInserted = false;
            int FileTypeID = 0;
            //string query = " Select FileTypeID from mFileType where FileExtension = '" + FileExtension + "'";
            using (IDbConnection db = new SqlConnection(strConnection.Replace("***", Alias)))
            {

                try
                {
                    db.Open();
                    IDbTransaction sqlTransaction = db.BeginTransaction();
                    
                }
                catch (Exception)
                {

                    throw;
                }
                finally { db.Close(); }

            }
            
            return _isInserted;
        }
        //NEED TO CHECK THE TABLE NAME
        public static int GetFileTypeId(string FileExtension, string Alias)
        {
            int FileTypeID = 0;
            string query = " Select FileTypeID from mFileType where FileExtension = '" + FileExtension + "'";
            using (IDbConnection db = new SqlConnection(strConnection.Replace("***", Alias)))
            {
               
                try
                {
                    db.Open();
                    FileTypeID = db.ExecuteScalar<int>(query);
                }
                catch (Exception)
                {

                    throw;
                }
                finally { db.Close(); }

            }
            return FileTypeID;
        }
    
    
    }
}
