using AutoMapper;
using KanBan.Models.DTOs.CardDTO;
using KanBan.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto;

namespace KanBan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : ControllerBase
    {
        private readonly CardRepository _context;
        private IMapper _mapper;

        public CardController(CardRepository cardRepository, IMapper mapper)
        {
            _context = cardRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateCard([FromBody] CreateCardDTO cardCreate)
        {
            Card card = _mapper.Map<Card>(cardCreate);


            try
            {
                _context.AddCard(card);
                return Created("", card);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("{id}")]
        public IActionResult TimeOfAppointment(int id)

        {
            var card = _context.GetCardById(id);

            if (card == null) 
                return NotFound("Card Not Found");

            var mappedCard = _mapper.Map<ReadCardDTO>(card);
            mappedCard.TimeOfAppointment = DateTime.Now;

            return Ok(mappedCard);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateCard([FromRoute] int id, [FromBody] UpdateCardDTO updateCard)
        {
            var card = _context.UpdateCard(updateCard, id);
            if (card == null)

                try
                {
                    if (id != null)
                        return Ok(card);

                }

                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCard(int id)
        {
            try
            {
                if (id != null)
                {
                    _context.DeleteCard(id);
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
