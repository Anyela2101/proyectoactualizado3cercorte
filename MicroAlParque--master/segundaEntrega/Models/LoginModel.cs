using System;
using Entidad;

namespace segundaEntrega.Models
{
    public class LoginInputModel
    {
        public string User {get;set;}
        public string Password {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Email {get;set;}
        public string Token {get;set;}

    }

    public class LoginViewModel : LoginInputModel{
        public LoginViewModel()
        {

        }
        public LoginViewModel(Usuario usuario){
            User = usuario.User;
            Password = usuario.Password;
            FirstName = usuario.FirstName;
            LastName = usuario.LastName;
            Email = usuario.Email;
            Token = usuario.Token;
        }

    }
}