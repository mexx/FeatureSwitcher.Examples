using System.Collections.Generic;
using System.Linq;

namespace FeatureSwitcher.Specs.Domain
{
    public class Test1Feature : IFeature
    {
    }

    public class Test2Feature : IFeature
    {
    }

    public static class ConfigureByDatabase
    {
        //user in context

        public static Feature.Behavior IsEnabled(IList<FeatureConfiguration> configurations
, User user)
        {
            return name => Ask(name, configurations, user);
        }

        private static bool? Ask(Feature.Name name, IList<FeatureConfiguration> configurations
, User user)
        {
            var x = configurations.Where(f => f.FeatureName == name.Value);
            if (!x.Any())
                return null;

            return x.Any(f => f.UseraccountId == user.Id) || x.Any(f => f.UseraccountId == null && f.Role == user.Role);
        }

        public static Feature.NamingConvention NamingConvention
        {
            get
            {
                return type => new Feature.Name(type, type.Name.Replace(type.Namespace + ".", ""));
            }
        }
    }
}
