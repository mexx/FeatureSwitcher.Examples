using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeatureSwitcher.Specs.Domain
{
    /// <summary>
    /// Repository DTO
    /// </summary>
    public class FeatureConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FeatureName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? ClientId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? UseraccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public UserRole Role { get; set; }
    }
}
