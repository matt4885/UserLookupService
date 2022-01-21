using UserLookupService.Abstractions;

namespace UserLookupService.Data;

public static class UserModelMapper
{
    public static Abstractions.User ToBusiness(User user)
    {
        return new Abstractions.User
        {
            Address = user.Address,
            DateOfBirth = user.DateOfBirth,
            Email = user.Email,
            FamilyName = user.FamilyName,
            GivenName = user.GivenName,
            Id = user.Id
        };
    }

    public static Abstractions.User ToBusiness(AddUser user)
    {
        return new Abstractions.User
        {
            Id = Guid.NewGuid(),
            Address = user.Address,
            DateOfBirth = user.DateOfBirth,
            Email = user.Email,
            FamilyName = user.FamilyName,
            GivenName = user.GivenName,
        };
    }

    public static Data.User ToDatabase(Abstractions.User user)
    {
        return new Data.User
        {
            Address = user.Address,
            DateOfBirth = user.DateOfBirth,
            Email = user.Email,
            FamilyName = user.FamilyName,
            GivenName = user.GivenName,
            Id = user.Id ?? Guid.Empty
        };
    }
}
