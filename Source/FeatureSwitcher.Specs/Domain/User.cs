using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeatureSwitcher.Specs.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        /// <summary>
        /// Logged on user
        /// </summary>
        public User(UserRole role, long? userId, long? clientId)
        {
            Role = role;
            Id = userId;
            ClientId = clientId;
        }

        /// <summary>
        /// 
        /// </summary>
        public long? ClientId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public UserRole Role { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Id { get; private set; }
    }
}
