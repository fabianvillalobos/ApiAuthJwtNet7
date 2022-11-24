using ApiAuthJwt.Dtos.User;
using ApiAuthJwt.Models;

namespace ApiAuthJwt.Services.UserService
{
    public interface IUserService
    {
        Task<User> RegisterUser(User user);
        User RetornarUsuario(string email);
        void ActualizarRefreshToken(User user);
    }
}
