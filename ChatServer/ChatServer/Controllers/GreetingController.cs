using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using ChatServer.Models;

namespace ChatServer.Controllers
{
    public class GreetingController : ApiController
    {
        public static List<Greeting> greetings = new List<Greeting>();

        public string GetGreeting(string id)
        {
            Greeting greeting;
            try                           
            {
                greeting = greetings.FirstOrDefault(g => null != g && g.Name == id);
            }
            catch (ArgumentNullException)
            {
                return null;
            }
            
            return greeting.Message;
        } 
        
        public HttpResponseMessage PostGreeting(Greeting greeting)
        {
            greetings.Add(greeting);
            var greetingLocation = new Uri(this.Request.RequestUri, "greeting/" + greeting.Name);
            var response = this.Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = greetingLocation;

            return response;
        }
    }
}
