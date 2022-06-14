using System;
using System.IO;

namespace myForm.Classes
{
    class io
    {
        //The Log request method writes out the XML request setn to TREC to file
        public static void logRequest(string requestData, string xmlString, string theDateTime)
        {
            if (!Directory.Exists("c:\\TrecFiles"))
            {
                Directory.CreateDirectory("c:\\TrecFiles");
            }

            //requestData = requestData.Replace("&lt;","<");
            //requestData = requestData.Replace("&gt;", ">");
            //xmlString = xmlString.Replace("&lt;", "<");
            //xmlString = xmlString.Replace("&gt;", ">");

            //Save a file to for the request information so user can keep a history of XML submissions to the TREC service.
            using (StreamWriter writer = new StreamWriter("c:\\TrecFiles\\" + theDateTime + ".txt"))
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine("XML loaded into form: " + requestData);
                writer.WriteLine("REQUEST XML: " + xmlString);
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine();
            }
        }

        //Writes out header row for the data returned from TREC to log file
        public static void logHeaderRow(string theDateTime)
        {
            using (StreamWriter writer = new StreamWriter("c:\\TrecFiles\\" + theDateTime + ".txt", true))
            {
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("ID,Provider,Course,Completion,Start,License #,Name,Response");
            }
        }

        //Logs new line in log file
        public static void logNewLine(string theDateTime)
        {
            using (StreamWriter writer = new StreamWriter("c:\\TrecFiles\\" + theDateTime + ".txt", true))
            {
                writer.WriteLine();
            }
        }

        //Logs the data set to the log file
        public static void logDataSet(string responseData, string theDateTime)
        {
            using (StreamWriter writer = new StreamWriter("c:\\TrecFiles\\" + theDateTime + ".txt", true))
            {
                writer.Write(responseData);
            }
        }
        
        //Logs the XML response to the log file
        public static void logResponse(string responseData, string theDateTime)
        {
            responseData = responseData.Replace("&lt;", "<");
            responseData = responseData.Replace("&gt;", ">");

            using (StreamWriter writer = new StreamWriter("c:\\TrecFiles\\" + theDateTime + ".txt", true))
            {
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("Returned XML: " + responseData);
            }
        }
    }
}
