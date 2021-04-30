using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ic13
{
    class TranscriptsData
    {
        public List<Transcript> readTranscripts()
        {
            List<Transcript> colTranscripts = new List<Transcript>();

            FileStream fsTranscripts = new FileStream("Transcripts.txt", FileMode.Open);
            StreamReader srTranscripts = new StreamReader(fsTranscripts);
            string strLine;
            string[] aryLine;

            string strClass;
            string strGrade;
            string strHonors;

            int intCreditHrs;

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
                    objTranscript = new HonorsTranscript(strClass, intCreditHrs, strGrade);
                }
                else
                {
                    objTranscript = new Transcript(strClass, intCreditHrs, strGrade);
                }

                colTranscripts.Add(objTranscript);
            }
            fsTranscripts.Close();
            srTranscripts.Close();

            return colTranscripts;
        }

        public void writeTranscripts(List<Transcript> colTranscripts)
        {
            FileStream fsTranscripts = new FileStream("Transcripts.txt", FileMode.Create);
            StreamWriter swTranscripts = new StreamWriter(fsTranscripts);

            foreach (Transcript objTranscript in colTranscripts)
            {
                string strLine = objTranscript.Course + ';' + objTranscript.CreditHrs.ToString() + ';' +
                    objTranscript.Grade + ';';

                if (objTranscript.GetType().Name == "HonorsTranscript")
                {
                    strLine += "H";
                }
                swTranscripts.WriteLine(strLine);
            }
            swTranscripts.Close();
            fsTranscripts.Close();
        }
    }
}
