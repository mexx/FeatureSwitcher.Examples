using System;
using System.Collections.Generic;
using System.Linq;

namespace FeatureSwitcher.Contexteer.Specs.Domain
{
    public class Test1Feature : IFeature
    {
    }

    public class Test2Feature : IFeature
    {
    }

    public class ConfigureByDatabase
    {
        private readonly IList<FeatureConfiguration> _configurations;

        public ConfigureByDatabase(IList<FeatureConfiguration> configurations)
        {
            _configurations = configurations;
        }

        //user in context
        public Feature.Behavior[] IsEnabled(User user)
        {
            return new Feature.Behavior[] { name => Ask(name, user) };
        }

        private bool? Ask(Feature.Name name, User user)
        {
            var x = _configurations.Where(f => f.FeatureName == name.Value);
            if (!x.Any())
                return null;

            return x.Any(f => f.UseraccountId == user.Id)
                || x.Any(f => f.UseraccountId == null && f.Role == user.Role);
        }

        public Feature.Name AreNamed(Type type)
        {
            return new Feature.Name(type, type.Name.Replace(type.Namespace + ".", ""));
        }
    }
}