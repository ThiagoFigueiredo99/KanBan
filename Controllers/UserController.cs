using AutoMapper;
using ConcertKanban.DBContext;
using KanBan.Models.DTOs;
using KanBan.Models.DTOs.UserDTO;
using KanBan.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KanBan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _context;
        private IMapper _mapper;
        public UserController(UserRepository userRepository, IMapper mapper)
        {
            _context = userRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserDTO userCreate)
        {
            User user = _mapper.Map<User>(userCreate);
            try
            {
                _context.AddUser(user);
                return Created("", user);
            }
            
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            
        }

        [HttpGet("{id}")]
        public IActionResult TimeOfAppointment(int id)

        {
            var user = _context.GetUserById(id);

            if (user == null)
                return NotFound("User Not Found");

            var mappedUser = _mapper.Map<ReadUserDTO>(user);
            mappedUser.TimeOfAppointment = DateTime.Now;

            return Ok(mappedUser);
        }



        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] int id, [FromBody] UpdateUserDTO updateUser)
        {
            var user = _context.UpdateUser(updateUser, id);
            if ( user == null)
                
            try
            {
                if(id != null)
                return Ok(user);
                
            }

            catch (Exception ex)
            {
                return BadRequest();
            }

            return NotFound();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                if (id != null)
                {
                    _context.DeleteUser(id);
                    return NoContent();
                }
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NotFound();
        }





    }
}
