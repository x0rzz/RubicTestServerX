﻿using AutoMapper;
using RubicX_PS223020.BusinesLogic.Core.Interfaces;
using RubicX_PS223020.BusinesLogic.Core.Models;
using RubicX_PS223020.DataAccess.Core.Interfaces.DbContext;
using RubicX_PS223020.DataAccess.Core.Models;
using Shared.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicX_PS223020.BusinesLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IRubicContext _context;

        public UserService(IMapper mapper, IRubicContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Task<UserInformationBlo> AuthWithEmail(string email, string password)
        {
            UserRto user = _context.Users.FirstOrDefault(p => p.Email == email && p.Password == password);

            if (user == null)
                throw new NotFoundException($"Пользователь с почтой {email} не найден");

            return ConvertToUserInformation(user);
        }

        public Task<UserInformationBlo> AuthWithLogin(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> AuthWithPhone(string numberPrefix, string number, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(string numberPrefix, string number)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string number, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(string numberPrefix, string number, string password, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }

        private async Task<UserInformationBlo> ConvertToUserInformation(UserRto userRto)
        {
            if (userRto == null) throw new ArgumentNullException(nameof(userRto));

            var userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);

            return userInformationBlo;
        }
    }
}
