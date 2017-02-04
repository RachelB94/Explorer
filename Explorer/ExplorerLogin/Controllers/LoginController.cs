using ExplorerLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExplorerLogin.Controllers
{
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        ExplorersDbsEntities db = new ExplorersDbsEntities();

        [HttpPost]
        [Route("XAMARIN_REG")]
        //POST: api/Login
        public HttpResponseMessage Register(string username, string password)
        {
            Login login = new Models.Login();
            login.Username = username;
            login.Password = password;
            db.Logins.Add(login);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Accepted, "Successfully Created");
        }


        // GET: api/Login
        [HttpGet]
        [Route("XAMARIN_Login")]
        public HttpResponseMessage Login(string username, string password)
        {
            var user = db.Logins.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            if(user == null)
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Please Enter Valid Username and Password");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Accepted, "Success");
            }
        }

    }
}
