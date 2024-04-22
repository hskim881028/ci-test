using Hskim.Utility;

namespace Hskim.Model
{
    public interface IUserData
    {
        public BindableProperty<string> Id { get; }
        public BindableProperty<string> Password { get; }
    }
}