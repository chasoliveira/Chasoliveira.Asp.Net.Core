using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Chasoliveira.Core.Application.Interfaces;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Application
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        readonly IUserService _userService;
        public UserAppService(IUserService userService) : base(userService)
        {
            _userService = userService;
        }

        public void Add(UserDTO item)
        {
            var user = MapperModelDTO.Map<User>(item);
            base.Add(user);
        }

        public new  UserDTO FindOne(int id)
        {
            var user = base.FindOne(id);
            var userDto = MapperModelDTO.Map<UserDTO>(user);
            return userDto;
        }
        public UserDTO FindOne(Expression<Func<UserDTO, bool>> predicate)
        {
            var userExpression = MapperModelDTO.Map<Expression<Func<User, bool>>>(predicate);
            var user = base.FindOne(userExpression);
            var userDto = MapperModelDTO.Map<UserDTO>(user);
            return userDto;
        }

        public new IEnumerable<UserDTO> All()
        {
            var users = base.All();
            var usersDto = MapperModelDTO.Map<IEnumerable<UserDTO>>(users);
            return usersDto;
        }
        public IEnumerable<UserDTO> All(Expression<Func<UserDTO, bool>> predicate)
        {
            var userExpression = MapperModelDTO.Map<Expression<Func<User, bool>>>(predicate);
            var users = base.All(userExpression);
            var usersDto = MapperModelDTO.Map<IEnumerable<UserDTO>>(users);
            return usersDto;
        }

        public int Authenticate(string username, string password)
        {
            return _userService.Authenticate(username, password);
        }

        public void Remove(UserDTO item)
        {
            var user = MapperModelDTO.Map<User>(item);
            base.Remove(user);
        }

        public void Update(UserDTO item)
        {
            var user = MapperModelDTO.Map<User>(item);
            base.Update(user);
        }

        public new int SaveChanges() => base.SaveChanges();
    }
}
