namespace ApiAuthJwt.Dtos.User
{
    public class UserRegisterDto
    {
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; } = string.Empty;

    }
}
