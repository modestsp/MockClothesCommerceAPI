using ErrorOr;

namespace MockClothesCommerceAPI.ServiceErrors;

public class Errors
{
    public static class User
    {
        public static Error NotFound => Error.NotFound(
            code: "User.NotFound",
            description: "User was not found");
    }
}
