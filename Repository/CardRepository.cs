using ConcertKanban.DBContext;
using KanBan.Models.DTOs.CardDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto;

namespace KanBan.Repository
{
    public class CardRepository 
    {
        private readonly KanbanContext _context;
        public CardRepository(KanbanContext context)
        {
            _context = context;
        }

        public Card GetCardById(int id)
        {
            return _context.Cards.Include(x => x.Sprint).Include(x => x.User).Where(x =>x.Id == id).FirstOrDefault();
        }

        public void AddCard(Card newCard)
        {
            _context.Cards.Add(newCard);
            _context.SaveChanges();
        }

        public void DeleteCard(int id)
        {
            var card = _context.Cards.Find(id);

            if (card == null) return;

            _context.Cards.Remove(card);
            _context.SaveChanges();

        }

        public Card UpdateCard(UpdateCardDTO updateCard, int id)
        {
            var card = _context.Cards.Find(id);
            card.Title = updateCard.Title;
            card.Description = updateCard.Description;
            _context.SaveChanges();
            return card;
        }
       

    }
}
