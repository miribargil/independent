using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using BL;
using DTO.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace independent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBL _userBL;
        public UserController(IUserBL userBL)
        {
            _userBL = userBL;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}/{password}")]
        public UserDTO Get(string id, string password)
        {
            return _userBL.GetUser(id, password);
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("AddUSer")]
        public bool AddUser([FromBody] UserDTO user)
        {
            var x = _userBL.AddUser(user);
            return x;
        }

        // DELETE api/<UserController>
        [HttpDelete]
        [Route("DeleteUser")]
        public bool DeleteUser(string id)
        {
            return _userBL.DeleteUser(id);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        [Route("Update/{id}")]
        public ActionResult<bool> UpdateUser(string id, [FromBody] UserDTO user)
        {
            if (user.Id != id)

                return StatusCode(400, "");
            return Ok(_userBL.UpdateUser(id, user));
        }
        // PUT api/<UserController>/5
        [HttpPut]
        [Route("Update{id}/{mail}")]
        public ActionResult<bool> UpdatePassword(string id,string mail)
        {
           
            return Ok(_userBL.UpdatePassword(id, mail));
        }
    }
}
