﻿namespace NetCoreConf.BCN.API.API.Shared
{
    using Microsoft.AspNetCore.Mvc;

    [ApiVersionNeutral]
    [Route("api/[controller]")]

    [Microsoft.AspNetCore.Authorization.Authorize]
    public class SharedController : Controller
    {
        [HttpGet(Name ="Version")]
        public string Get()=> (HttpContext.GetRequestedApiVersion() != null) ?
                         HttpContext.GetRequestedApiVersion().ToString() :
                         "Not version in Request";
         
  
    }
}
