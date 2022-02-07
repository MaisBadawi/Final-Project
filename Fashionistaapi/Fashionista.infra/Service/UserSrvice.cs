using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using MailKit.Net.Smtp;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fashionista.infra.Service
{
    public class UserSrvice : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserSrvice(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool Changepass(Auth auth)
        {
            var result = userRepository.Changepass(auth);
            if (result != null)
            {
                MimeMessage message = new MimeMessage();
                MailboxAddress from = new MailboxAddress("Fashinista", "Khr25984@gmail.com");
                message.From.Add(from);
                MailboxAddress to = new MailboxAddress("Customer", result.Email);
                message.To.Add(to);
                message.Subject = "Password Code";
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = "<h1>Change Password</h1><p>Hello " + result.Username + " your new password :<strong>" + result.Password + "</strong></P>";
                message.Body = bodyBuilder.ToMessageBody();

                using (var item = new SmtpClient())
                {
                    item.Connect("smtp.gmail.com", 587, false);
                    item.Authenticate("Khr25984@gmail.com", "RAMAM97@97");
                    item.Send(message);
                    item.Disconnect(true);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Check_Username(Auth auth)
        {
            var result = userRepository.Check_Username(auth);
            if (result == null)
            {
                return false;
            }
            else

            {

                return true;
            }
        }

        public bool DELETEUSER(int Id)
        {
            return userRepository.DELETEUSER(Id);
        }

        public List<Customer> GetAllCustomer()
        {
            return userRepository.GetAllCustomer();
        }

        public List<Employee> GetAllEmployee()
        {
            return userRepository.GetAllEmployee();
        }

        public bool INSERTUSER(User user)
        {
            return userRepository.INSERTUSER(user);
        }

        public List<Customer> SearchCustomerByName(string CustName)
        {
            return userRepository.SearchCustomerByName(CustName);

        }

        public List<Employee> SearchEmployeeBYName(string EmpName)
        {
            return userRepository.SearchEmployeeBYName(EmpName);

        }

        public bool UPDATEUSER(User user)
        {
            return userRepository.UPDATEUSER(user);
        }

        public string Auth(User user)
        {
            var result = userRepository.Auth(user);
            if (result == null)
            {
                return null;
            }
            else

            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name,Convert.ToString(result.Id) ), new Claim(ClaimTypes.Role, Convert.ToString(result.Rol_Id))}),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
        }
    }
}
