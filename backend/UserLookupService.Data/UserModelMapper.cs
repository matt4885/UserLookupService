using UserLookupService.Abstractions;

namespace UserLookupService.Data;

public static class UserModelMapper
{
    public static Abstractions.User ToBusiness(User user)
    {
        return new Abstractions.User
        {
            Address = user.Address,
            State = user.State,
            ZipCode = user.ZipCode,
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
            State = user.State,
            ZipCode =user.ZipCode,
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
            State = user.State,
            ZipCode= user.ZipCode,
            DateOfBirth = user.DateOfBirth,
            Email = user.Email,
            FamilyName = user.FamilyName,
            GivenName = user.GivenName,
            Id = user.Id  
        };
    }

    /// <summary>
    /// converts List<Data.User> to List<Abstractions.User>
    /// </summary>
    /// <param name="users"></param>
    /// <returns></returns>
    public static IList<Abstractions.User> ToBusiness(List<Data.User> users)
    {
        var abstractionUsers = new List<Abstractions.User>();

        foreach (var user in users)
        {
            abstractionUsers.Add(ToBusiness(user));
        }

        return abstractionUsers;
    }
}
