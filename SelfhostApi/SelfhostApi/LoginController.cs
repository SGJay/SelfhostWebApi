﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfhostApi
{
    public class LoginController : ApiController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        /// <summary>
        /// get id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ActionName("sss")]
        [HttpGet]
        public string Get(int id)
        {
            return id.ToString();
        }

        public string SayHi(string user)
        {
            return user + " say hi";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
