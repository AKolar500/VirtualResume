using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ic13_041713
{
    class DataTier
    {
        const string strFileAndPath = "transcripts.txt";
        const char DELIMITER = '|';

        public List<Transcript> readData()
        {
            FileStream fs = null;
            StreamReader sr = null;
            string inputString;
            string[] aryInput;
            Transcript objTranscript;
            List<Transcript> colTranscripts = new List<Transcript>();

            try
            {
                fs = new FileStream(strFileAndPath, FileMode.OpenOrCreate);
                sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    inputString = sr.ReadLine();

                    aryInput = inputString.Split(DELIMITER);

                    if (aryInput[0] == "H")
                    {
                        objTranscript = new Honors();
                    }
                    else
                    {
                        objTranscript = new Transcript();
                    }
                    objTranscript.ClassName = aryInput[1];
                    objTranscript.CreditHours = int.Parse(aryInput[2]);
                    objTranscript.Grade = aryInput[3];

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
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        public void writeData(List<Transcript> colTranscripts)
        {
            string strWriteLine;
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(strFileAndPath, FileMode.Create);
                sw = new StreamWriter(fs);

                foreach (Transcript objTranscript in colTranscripts)
                {
                    if (objTranscript is Honors)
                    {
                        strWriteLine = "H" + DELIMITER;
                    }
                    else
                    {
                        strWriteLine = "T" + DELIMITER;
                    }

                    strWriteLine += objTranscript.ClassName + DELIMITER +
                        objTranscript.CreditHours + DELIMITER +
                        objTranscript.Grade;
                    sw.WriteLine(strWriteLine);

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
