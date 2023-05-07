using Infrastructure.Entities;
using Infrastructure.Repository;
using System.Linq;

namespace Infrastructure.Service
{
    public interface IUserService
    {
        IQueryable<User> GetUsers();
        User GetUser(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }

    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IQueryable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public User GetUser(int id)
        {
            return userRepository.GetById(id);
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            userRepository.Delete(user);
        }
    }
}
