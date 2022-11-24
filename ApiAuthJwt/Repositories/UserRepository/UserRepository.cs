
using ApiAuthJwt.Data;
using ApiAuthJwt.Dtos.User;
using ApiAuthJwt.Models;

namespace ApiAuthJwt.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }


        public Task<User> RegisterUser(User userRegister)
        {
            User userModel = new User();
            userModel.Email = userRegister.Email;
            userModel.Name = userRegister.Name;
            userModel.LastName = userRegister.LastName;
            userModel.Role = "User";
            userModel.PasswordHash = userRegister.PasswordHash;
            userModel.PasswordSalt = userRegister.PasswordSalt;
            userModel.RefreshToken = userRegister.RefreshToken;

            try
            {
                _context.Users.Add(userModel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return Task.FromResult(userModel);
            
        }

        public User RetornarUsuario(string email)
        {
            User usuario = new User();
            usuario = _context.Users.FirstOrDefault(a => a.Email == email);
            if (usuario is not null)
            {
                return usuario;
            }
            else
            {
                return usuario;
            }

            
        }

        public void ActualizarRefreshToken(User user)
        {
            var usuario = _context.Users.FirstOrDefault(a =>a.Email == user.Email);
            if (usuario is not null)
            {
                usuario = user;
                _context.Users.Update(usuario);
                _context.SaveChanges();
            }
        }
    }
}
