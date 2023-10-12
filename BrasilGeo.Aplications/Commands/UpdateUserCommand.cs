﻿using BrasilGeo.Domain.Commands;
using BrasilGeo.Domain.Commands.Interfaces;
using Flunt.Notifications;
using Flunt.Validations;

namespace BrasilGeo.Aplications.Commands
{
    public class UpdateuserCommand : Notifiable<Notification>, ICommand
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> Roles { get; set; }
        public void Valid()
        {
            AddNotifications(new Contract<CreateUserCommand>()
                 .Requires()
                 .IsEmail(Email, "E-mail", "Campo de Email")
                 .IsGreaterThan(Password, 8, "Passwors", "Deve conter mais de 8 caracteres"));
        }
    }
}
