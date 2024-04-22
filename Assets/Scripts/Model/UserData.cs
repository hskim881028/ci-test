using Hskim.Utility;

namespace Hskim.Model
{
    public class UserData : IUserData
    {
        public BindableProperty<string> Id { get; } = new();
        public BindableProperty<string> Password { get; } = new();
    }
}