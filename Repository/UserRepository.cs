using ConcertKanban.DBContext;
using KanBan.Models.DTOs.UserDTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace KanBan.Repository
{
    public class UserRepository
    {
        private readonly KanbanContext _context;
        public UserRepository(KanbanContext context)
        {
            _context = context;
        }

        public void AddUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public User UpdateUser(UpdateUserDTO updateUser, int id)
        {
            var user = _context.Users.Find(id);
            user.Name = updateUser.Name;
            _context.SaveChanges();
            return user;
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
      
            _context.Users.Remove(user);
            _context.SaveChanges();
            

        }

    }
}
