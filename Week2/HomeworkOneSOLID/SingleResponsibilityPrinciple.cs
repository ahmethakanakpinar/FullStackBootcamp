using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOneSOLID.SingleResponsibilityPrinciple
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
    public interface IUserService
    {
        void RegisterUser(string username, string password, string email);
    }
    public class UserService(UserRepository _userRepository, EmailService _emailService) : IUserService
    {
        public void RegisterUser(string username, string password, string email)
        {
            var user = new User { UserName = username, Password = password, Email = email};
            _userRepository.AddUser(user);
            _emailService.SendEmail(email, "Başarıyla Kayıt Oldunuz Giriş Yapabilirsiniz.");
        }
    }

    public class EmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"{email} Kullanıcıya Başarıyla Mesaj Gönderildi");
            // E-posta gönderme işlemi
        }
    }
    public class UserRepository
    {
        public void AddUser(User user)
        {
            Console.WriteLine($"{user.UserName} Kullanıcı Başarıyla Eklendi");
            // Kullanıcı Ekleme işlemi
        }
    }

}
