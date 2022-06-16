using ConcertKanban.DBContext;
using KanBan.Models.DTOs.SprintDTO;
using Projeto;

namespace KanBan.Repository
{
    public class SprintRepository
    {
        private readonly KanbanContext _context;
        public SprintRepository(KanbanContext context)
        {
            _context = context;
        }

        public void AddSprint(Sprint newSprint)
        {
            _context.Sprints.Add(newSprint);
            _context.SaveChanges();
        }

        public Sprint GetSprintById(int id)
        {
            return _context.Sprints.Find(id);
        }

        public Sprint UpdateSprint(UpdateSprintDTO updateSprint, int id)
        {
            var sprint = _context.Sprints.Find(id);
            sprint.Name = updateSprint.Name;
            _context.SaveChanges();
            return sprint;
        }

        public void DeleteSprint(int id)
        {
            var sprint = _context.Sprints.Find(id);

            _context.Sprints.Remove(sprint);
            _context.SaveChanges();


        }

    }
}
