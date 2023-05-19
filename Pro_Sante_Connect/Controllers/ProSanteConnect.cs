using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pro_Sante_Connect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProSanteConnect : ControllerBase
    {
        // GET api/<ProSanteConnect>/Authorization
        [HttpGet("Authorization/{id}")]
        public string Authorization(int id)
        {
            return "value";
        }
        
        // POST api/<ProSanteConnect>/Token
        [HttpPost("Token/{id}")]
        public void Token([FromBody] string value)
        {
        }

        // GET api/<ProSanteConnect>/UserInfo
        [HttpGet("UserInfo/{id}")]
        public string UserInfo(int id)
        {
            return "value";
        }

        // POST api/<ProSanteConnect>/RefreshToken
        [HttpPost("RefreshToken/{id}")]
        public void RefreshToken([FromBody] string value)
        {
        }
    }
}
