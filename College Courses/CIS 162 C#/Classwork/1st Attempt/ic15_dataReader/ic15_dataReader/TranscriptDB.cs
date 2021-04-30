using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ic15_DataReader
{
    static class TranscriptDB
    {

        static public List<Transcript> GetAllTranscripts()
        {
            List<Transcript> colTranscripts = new List<Transcript>();

            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Transcripts.accdb");

            string strCommand = "Select * " +
                                " from tblTranscripts "; 


            cn.Open();

            OleDbCommand cmd = new OleDbCommand(strCommand, cn);


            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Transcript objTrans = new Transcript();
                objTrans.ID = Convert.ToInt32(dr["ID"]);
                objTrans.Course = dr["ClassName"].ToString();
                objTrans.CreditHrs = Convert.ToInt32(dr["CreditHours"]);
                objTrans.Grade = dr["LetterGrade"].ToString();

                colTranscripts.Add(objTrans);

            }


            cn.Close();


            return colTranscripts;

        }

        static public Transcript GetTranscript(int intID)
        {

            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Transcripts.accdb");

            string strCommand = "Select * " +
                                 " from tblTranscripts" +
                                 " where ID = " + intID; ;

            cn.Open();

            OleDbCommand cmd = new OleDbCommand(strCommand, cn);


            OleDbDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.HasRows)
            {
                Transcript objTrans = new Transcript();
                objTrans.ID = Convert.ToInt32(dr["ID"]);
                objTrans.Course = dr["ClassName"].ToString();
                objTrans.CreditHrs = Convert.ToInt32(dr["CreditHours"]);
                objTrans.Grade = dr["LetterGrade"].ToString();
                dr.Close();
                cn.Close();
                return objTrans;
            }
            else
            {
                dr.Close();
                cn.Close();
                return null;

            }

        }



        public static int UpdateTranscript(Transcript objOrigTrans, Transcript objNewTrans)
        {


            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Transcripts.accdb");

            string strUpdate = "UPDATE tblTranscripts "
                 + "SET ClassName = @NewClassName, "
                + " CreditHours = @NewCreditHours, "
                + " LetterGrade = @NewLetterGrade "
                + " WHERE ID = @OrigID  and "
            + " ClassName = @OrigClassName and "
           + " CreditHours = @OrigCreditHours and "
            + " LetterGrade = @OrigLetterGrade ";

            OleDbCommand cmd = new OleDbCommand(strUpdate, cn);


  
           // cmd.Parameters.AddWithValue("NewID", objNewTrans.ID);
            cmd.Parameters.AddWithValue("NewClassName", objNewTrans.Course);
            cmd.Parameters.AddWithValue("NewCreditHours", objNewTrans.CreditHrs);
            cmd.Parameters.AddWithValue("NewLetterGrade", objNewTrans.Grade);

            cmd.Parameters.AddWithValue("OrigID", objOrigTrans.ID);
            cmd.Parameters.AddWithValue("OrigClassName", objOrigTrans.Course);
            cmd.Parameters.AddWithValue("OrigCreditHours", objOrigTrans.CreditHrs);
            cmd.Parameters.AddWithValue("OrigLetterGrade", objOrigTrans.Grade);


            cn.Open();
            int updateCount = cmd.ExecuteNonQuery();
            cn.Close();
            return updateCount;
        }

    }
}
