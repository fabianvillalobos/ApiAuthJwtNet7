using ApiAuthJwt.Dtos.User;
using ApiAuthJwt.Models;
using ApiAuthJwt.Repositories.UserRepository;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuthJwt.Services.UserService
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> RegisterUser(User user)
        {
            var save = await _userRepository.RegisterUser(user);

            return save;
        }

        public User RetornarUsuario(string email)
        {
            var usuario = _userRepository.RetornarUsuario(email);
            return usuario;
        }

        public void ActualizarRefreshToken(User user)
        {
            _userRepository.ActualizarRefreshToken(user);
        }
    }
}
