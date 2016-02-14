using System;
using System.IO;
using System.Net;
using System.Xml;

namespace myForm.Classes
{
    class soap
    {

        public static string xmlString;

        //This method handles calling upon the sub methods to setup the soap request to TREC and making the webrequest.
        public static string CallWebService(string serviceUrl, string serviceMethod, string token, string requestData, string theDateTime)
        {
            string _url = serviceUrl;
            string _token = token;
            string _method = serviceMethod;
            string _requestData = requestData;

            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(_token,_method,_requestData);
            
            HttpWebRequest webRequest = CreateWebRequest(_url);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.Write(soapResult);
            }

            //Log the request information to the file that will be saved on users machine
            if (!soapResult.Contains("Cannot perform runtime binding on a null reference"))
            {
                io.logRequest(requestData, xmlString, theDateTime);
            }
            return soapResult;
        }

        //Creates the HTTP webrequest with all of the required properties to manage the soap request.
        private static HttpWebRequest CreateWebRequest(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope(string token, string method, string requestData)
        {
            XmlDocument soapEnvelop = new XmlDocument();

            requestData = requestData.Replace("<", "&lt;");
            requestData = requestData.Replace(">", "&gt;");
            
            xmlString = "<?xml version='1.0' encoding='UTF-8'?><soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'><soapenv:Header><ValidationSoapHeader xmlns='" + method + "'><DevToken>" + token + "</DevToken></ValidationSoapHeader></soapenv:Header><soapenv:Body><ProcessRoster xmlns='" + method + "'><xmlReq>&lt;?xml version='1.0' encoding='UTF-8'?&gt;&lt;Transmission xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'&gt;" + requestData + "&lt;/Transmission&gt;</xmlReq></ProcessRoster></soapenv:Body></soapenv:Envelope>";
            
            soapEnvelop.LoadXml(xmlString);
            
            return soapEnvelop;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }

    }
}
