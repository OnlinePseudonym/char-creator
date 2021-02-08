using CharacterCreation.Data.Entities;
using CharacterCreation.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreation.Logic.Mapper
{
    public static class UserMapper
    {
        public static UserDto ToDto(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                CreatedDate = user.CreatedDate,
                UpdatedDate = user.UpdatedDate
            };
        }
        public static User ToDb(UserDto userDto)
        {
            return new User
            {
                Id = userDto.Id,
                Email = userDto.Email,
                UserName = userDto.UserName,
                CreatedDate = userDto.CreatedDate,
                UpdatedDate = userDto.UpdatedDate
            };
        }
    }
}
