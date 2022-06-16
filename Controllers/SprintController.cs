using AutoMapper;
using KanBan.Models.DTOs.SprintDTO;
using KanBan.Repository;
using Microsoft.AspNetCore.Mvc;
using Projeto;

namespace KanBan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SprintController : ControllerBase
    {
        private readonly SprintRepository _context;
        private IMapper _mapper;
        public SprintController(SprintRepository sprintRepository, IMapper mapper)
        {
            _context = sprintRepository;
            _mapper = mapper;

        }

        [HttpPost]
        public IActionResult CreateSprint([FromBody] CreateSprintDTO sprintCreate)
        {
            Sprint sprint = _mapper.Map<Sprint>(sprintCreate);
            try
            {
                _context.AddSprint(sprint);
                return Created("", sprint);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpGet("{id}")]
        public IActionResult TimeOfAppointment(int id)

        {
            var sprint = _context.GetSprintById(id);

            if (sprint == null)
                return NotFound("Sprint Not Found");

            var mappedCard = _mapper.Map<ReadSprintDTO>(sprint);
            mappedCard.TimeOfAppointment = DateTime.Now;

            return Ok(mappedCard);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSprint([FromRoute] int id, [FromBody] UpdateSprintDTO updateSprint)
        {
            var sprint = _context.UpdateSprint(updateSprint, id);
            if (sprint == null)

                try
                {
                    if (id != null)
                        return Ok(sprint);

                }

                catch (Exception ex)
                {
                    return BadRequest();
                }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSprint(int id)
        {
            try
            {
                if (id != null)
                {
                    _context.DeleteSprint(id);
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
