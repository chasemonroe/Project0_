// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using MongoDB.Bson;
// using Project0.Interfaces;
// using Project0.Models;
//
// namespace Project0.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class UsersController : ControllerBase
//     {
//         // private readonly UserService
//         private readonly IUserService _userService;
//
//         public UsersController(IUserService userService)
//         {
//             _userService = userService;
//         }
//
//         [HttpGet]
//         // [Route("/getAll")]
//         public ActionResult<List<User>> Get()
//         {
//             return _userService.Get();
//         }
//
//         [HttpGet]
//         [Route("/{id}")]
//         public ActionResult <Task<User>> Get(string id)
//         {
//             var user = _userService.Get(id);
//             if (user == null)
//             {
//                 return NotFound();
//             }
//             return user;
//         }
//
//         [HttpPost]
//         [Route("create")]
//         public ActionResult<User> Create(User user)
//         {
//             _userService.Create(user);
//             return CreatedAtRoute("GetUser", new {id = user.Id}, user);
//         }
//
//         [HttpPut]
//         public IActionResult Update(string id, User userIn)
//         {
//             var user = _userService.Get(id);
//             if (user == null)
//             {
//                 return NotFound();
//             }
//             _userService.Update(id, userIn);
//             return NoContent();
//         }
//         
//         [HttpDelete]
//         public IActionResult Delete(string id)
//         {
//             var user = _userService.Get(id);
//
//             if (user == null)
//             {
//                 return NotFound();
//             }
//
//             _userService.Remove(user.Id.ToString());
//
//             return NoContent();
//         }
//         
//         
//
//
//     }
// }