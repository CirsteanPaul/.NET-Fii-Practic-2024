using Autovit.Models.Identity;
using Services.Features.Identity.DTOs;

namespace Autovit.Mappers;

public static class IdentityMapper
{
    public static RegisterDto ToDto(this IdentityRegisterRequest request)
    {
        if (request is null)
        {
            return null;
        }
        
        return new RegisterDto()
        {
            Username = request.Username,
            PhoneNumber = request.PhoneNumber,
            Password = request.Password,
            Email = request.Email
        };
    }   
}