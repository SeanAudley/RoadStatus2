using System;
using System.Collections.Generic;
using RestSharp;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Configuration;
using System.Net;

namespace RoadStatus
{
    
    public class TfLRoadStatus
    {

        public List<RoadStatus.TflRoadStatus_DTO> result;
        public RoadStatus.TfLRoadStatus_ErrorDTO errorResult;
        public HttpStatusCode responseCode { get; set; }

        private string route {get;set;}


        // constuctors

        public TfLRoadStatus() { }

        public TfLRoadStatus(string routeName)
        {
            route = routeName;
        }

        
        // public functions

        public HttpStatusCode Retrieve()
        {
            if (route == null )
            {
                return HttpStatusCode.NotFound;
            }
            else
            {

                
                //create the client
                var client =  MakeClient();

                //create the request
                var request = MakeRequest();


                // execute 
                var response = client.Get(request);

                if (response.IsSuccessful)
                {
                    // convert the JSON data
                    result = TflRoadStatus_DTO.FromJson(response.Content);
                    responseCode = HttpStatusCode.OK;
                    return responseCode;
                }
                else
                {
                    errorResult = TfLRoadStatus_ErrorDTO.FromJson(response.Content);
                    responseCode = HttpStatusCode.NotFound;
                    return responseCode;
                }

            }


        }

        private IRestClient MakeClient()
        {
            var url = ConfigurationManager.AppSettings["url"];
            var client = new RestClient(url);

            return client;
        }

        private IRestRequest MakeRequest()
        {
            //retrieve config settings
            string app_id = ConfigurationManager.AppSettings["app_id"];
            string app_key = ConfigurationManager.AppSettings["app_key"];

            var Request = new RestRequest("Road/{id}", Method.GET);

            //add params and header
            Request.AddParameter("app_id", app_id);
            Request.AddParameter("app_key", app_key);
            Request.AddUrlSegment("id", route);

            return Request;

        }
    }

}
