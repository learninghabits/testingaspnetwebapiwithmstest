﻿using System.Web.Http;

namespace testing_asp_web_api_mstest.Controllers
{
    public class RootController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "API is ready to receive requests";
        }        
    }
}