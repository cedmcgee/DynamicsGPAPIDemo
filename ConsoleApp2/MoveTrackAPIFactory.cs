using System;
using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    public static class MoveTrackAPIFactory 
    {
        // private readonly string MoveTrackAPIUrl = ConfigurationManager.AppSettings["ineoUrl"];
        // public MoveTrackAPIFactory() { }



        /// <summary>
        /// Execute the service with the passed operation
        /// </summary>
        /// <param name="operation">Operation to be performed</param>
        /// <returns></returns>
        public static object ExecuteService(string operation, Type returnObject)
        {


            object deserializedObject = null;
            try
            {
                var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(String.Format("{0}:{1}", ConfigurationManager.AppSettings["mtusername"], ConfigurationManager.AppSettings["mtpassword"])));
                var webclient = new WebClient();

                //  { Credentials = new NetworkCredential(username, password) };

                webclient.Headers[HttpRequestHeader.Authorization] = String.Format("Basic {0}", credentials);
                var response = webclient.DownloadString(String.Format("{0}{1}", ConfigurationManager.AppSettings["ineoUrl"], operation));
               
                // webclient.DownloadStringAsync(new Uri(String.Format("{0}{1}", ConfigurationManager.AppSettings["ineoUrl"], operation)));

                deserializedObject = JsonConvert.DeserializeObject(response, returnObject);
                // deserializedObject = JsonConvert.DeserializeObject<returnObject.GetType>(response.);
            }
            catch (Exception e) { Console.Write(e.Message); }


            return deserializedObject;
        }


    }
}
