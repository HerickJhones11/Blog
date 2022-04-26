using BlogApi.Models;

namespace BlogApi.Services
{
    public interface IUserService 
    {
        public User Get(UserLogin userLogin);
    }
}
