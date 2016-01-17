using Contexteer;

namespace FeatureSwitcher.Contexteer.Specs.Domain
{
    public class User : IContext
    {
        public User(UserRole role, long? userId, long? clientId)
        {
            Role = role;
            Id = userId;
            ClientId = clientId;
        }

        public long? ClientId { get; private set; }

        public UserRole Role { get; private set; }

        public long? Id { get; private set; }
    }
}