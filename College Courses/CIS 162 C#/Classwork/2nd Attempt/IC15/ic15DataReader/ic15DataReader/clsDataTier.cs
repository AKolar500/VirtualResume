using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Collections;
using System.Configuration;

namespace ic15DataReader
{
    class clsDataTier
    {
        public static List<Transcript> GetAllTranscriptsList()
        {
            List<Transcript> colTranscript = new List<Transcript>();

            SqlConnection cn = new SqlConnection(GetConnectionString());

            string strSelect = " Select ID, ClassName, ClassCreditHours, ClassGrade " +
                               " From tblTranscripts " +
                               " Order by ID ";

            SqlCommand cmd = new SqlCommand(strSelect, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                Transcript objTranscript = new Transcript();

                objTranscript.ID = Convert.ToInt32(dr["ID"]);
                objTranscript.ClassName = dr["ClassName"].ToString();
                objTranscript.CreditHours = Convert.ToInt32(dr["ClassCreditHours"]);
                objTranscript.Grade = dr["ClassGrade"].ToString();
                colTranscript.Add(objTranscript);

            }

            cn.Close();

            return colTranscript;

        }

        public static int UpdateTranscript(Transcript original_Transcript, Transcript new_Transcript)
        {
            SqlConnection cn = new SqlConnection(GetConnectionString());

            string strUpdate = " update tblTranscripts " +
                               " set  ClassName = @new_CourseName, " +
                              " ClassCreditHours = @new_CourseCreditHours, " +
                              " ClassGrade = @new_CourseGrade " +
                              " where ID = @original_id and  " +
                              "  ClassName = @original_CourseName and  " +
                              "  ClassCreditHours = @original_CourseCreditHours and  " +
                              "  ClassGrade = @original_CourseGrade ";

            SqlCommand cmd = new SqlCommand(strUpdate, cn);

            cmd.Parameters.AddWithValue("new_CourseName", new_Transcript.ClassName);
            cmd.Parameters.AddWithValue("new_CourseCreditHours", new_Transcript.CreditHours);
            cmd.Parameters.AddWithValue("new_CourseGrade", new_Transcript.Grade);
            cmd.Parameters.AddWithValue("original_id", original_Transcript.ID);
            cmd.Parameters.AddWithValue("original_CourseName", original_Transcript.ClassName);
            cmd.Parameters.AddWithValue("original_CourseCreditHours", original_Transcript.CreditHours);
            cmd.Parameters.AddWithValue("original_CourseGrade", original_Transcript.Grade);

            cn.Open();
            int updateCount = cmd.ExecuteNonQuery();
            cn.Close();

            return updateCount;

        }

        public static int InsertTranscript(Transcript new_Transcript)
        {
            SqlConnection cn = new SqlConnection(GetConnectionString());

            string strUpdate = " insert into tblTranscripts " +
                               " (ClassName, ClassCreditHours, ClassGrade) " +
                              " values (@CourseName, @CourseCreditHours, @CourseGrade) ";

            SqlCommand cmd = new SqlCommand(strUpdate, cn);

            cmd.Parameters.AddWithValue("@CourseName", new_Transcript.ClassName);
            cmd.Parameters.AddWithValue("@CourseCreditHours", new_Transcript.CreditHours);
            cmd.Parameters.AddWithValue("@CourseGrade", new_Transcript.Grade);

            cn.Open();
            int updateCount = cmd.ExecuteNonQuery();
            cn.Close();

            return updateCount;

        }

        public static int DeleteTranscript(Transcript original_Transcript)
        {
            SqlConnection cn = new SqlConnection(GetConnectionString());

            string strUpdate = " delete tblTranscripts " +
                                " where ID = @original_id and  " +
                               "  ClassName = @original_CourseName and  " +
                               "  ClassCreditHours = @original_CourseCreditHours and  " +
                               "  ClassGrade = @original_CourseGrade ";

            SqlCommand cmd = new SqlCommand(strUpdate, cn);


            cmd.Parameters.AddWithValue("original_id", original_Transcript.ID);
            cmd.Parameters.AddWithValue("original_CourseName", original_Transcript.ClassName);
            cmd.Parameters.AddWithValue("original_CourseCreditHours", original_Transcript.CreditHours);
            cmd.Parameters.AddWithValue("original_CourseGrade", original_Transcript.Grade);


            cn.Open();
            int updateCount = cmd.ExecuteNonQuery();
            cn.Close();

            return updateCount;

        }


        public static string GetConnectionString()
        {
            return "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\dbTranscripts.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        }









    }
}
