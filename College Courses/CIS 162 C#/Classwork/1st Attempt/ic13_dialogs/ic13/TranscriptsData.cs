using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ic13
{
    static class TranscriptsData
    {


        static public List<Transcript> readTranscripts(string strFileAndPath)
        {
            FileStream fsTranscripts = null;
            StreamReader srTranscripts = null;
            try
            {

                List<Transcript> colTranscripts = new List<Transcript>();

                fsTranscripts = new FileStream(strFileAndPath, FileMode.Open);
                srTranscripts = new StreamReader(fsTranscripts);

                string strLine;
                string[] aryLine;

                string strClass;
                int intCreditHrs;
                string strGrade;
                string strHonors;

                Transcript objTranscript;

                while (srTranscripts.Peek() != -1)
                {
                    strLine = srTranscripts.ReadLine();
                    aryLine = strLine.Split(';');

                    strClass = aryLine[0];
                    intCreditHrs = int.Parse(aryLine[1]);
                    strGrade = aryLine[2];
                    strHonors = aryLine[3];

                    if (strHonors == "H")
                    {
                        objTranscript = new HonorsTranscript(strClass,
                                    intCreditHrs, strGrade);

                    }
                    else
                    {
                        objTranscript = new Transcript(strClass,
                                    intCreditHrs, strGrade);
                    }

                    colTranscripts.Add(objTranscript);
                }



                return colTranscripts;

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (srTranscripts != null)
                {
                    srTranscripts.Close();
                }
                if (fsTranscripts != null)
                {
                    fsTranscripts.Close();
                }

            }


        }

        static public void writeTranscripts(List<Transcript> colTranscripts, string strFileAndPath)
        {
            FileStream fsTranscripts = null;
            StreamWriter swTranscripts = null;
            try
            {


                fsTranscripts = new FileStream(strFileAndPath, FileMode.Create);
                swTranscripts = new StreamWriter(fsTranscripts);

                foreach (Transcript objTranscript in colTranscripts)
                {

                    string strLine = objTranscript.Course + ';' +
                                        objTranscript.CreditHrs.ToString() + ';' +
                                        objTranscript.Grade + ';';

                    if (objTranscript.GetType().Name == "HonorsTranscript")
                    {
                        strLine += "H";
                    }

                    swTranscripts.WriteLine(strLine);

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (swTranscripts != null)
                {
                    swTranscripts.Close();
                }
                if (fsTranscripts != null)
                {
                    fsTranscripts.Close();
                }

            }

        }

    }
}
