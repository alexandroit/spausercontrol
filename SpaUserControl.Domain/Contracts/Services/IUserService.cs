﻿using SpaUserControl.Domain.Models;
using System;

namespace SpaUserControl.Domain.Contracts.Services
{
    public interface IUserService : IDisposable
    {
        User Authenticate(string email, string password);
        User GetByEmail(string email);
        void Register(string name, string email, string password, string confirmPassword);
        void ChangeInformation(string email, string name);
        void ChangePassword(string email, string password, string newPassword, string confirmNewPassword);
        void ResetPassword(string email);
        void Delete(string email);
    }
}
