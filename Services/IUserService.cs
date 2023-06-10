using minimalAPI2.Models;

namespace minimalAPI2.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
