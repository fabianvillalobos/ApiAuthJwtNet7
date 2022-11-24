using ApiAuthJwt.Dtos.User;
using ApiAuthJwt.Models;

namespace ApiAuthJwt.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<User> RegisterUser(User user);
        User RetornarUsuario(string email);

        void ActualizarRefreshToken(User user);
    }
}
