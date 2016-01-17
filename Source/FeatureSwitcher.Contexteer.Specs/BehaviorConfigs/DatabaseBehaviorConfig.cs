using Contexteer.Configuration;
using FeatureSwitcher.Configuration;
using FeatureSwitcher.Contexteer.Specs.Domain;
using Machine.Fakes;
using System.Collections.Generic;

namespace FeatureSwitcher.Contexteer.Specs.BehaviorConfigs
{
    public class DatabaseBehaviorConfig
    {
        OnEstablish context = fakeAccessor =>
        {
            var config1 = new Domain.FeatureConfiguration() { Id = 1, FeatureName = "Test1Feature", ClientId = 1 };
            var config2 = new Domain.FeatureConfiguration() { Id = 2, FeatureName = "Test1Feature", UseraccountId = 111 };
            var config3 = new Domain.FeatureConfiguration() { Id = 3, FeatureName = "Test2Feature", Role = UserRole.Normalo };
            var features = new List<Domain.FeatureConfiguration> { config1, config2, config3 };

            var dbConfiguration = new ConfigureByDatabase(features);
            In<User>.Contexts.FeaturesAre().
                ConfiguredBy.Custom(dbConfiguration.IsEnabled).And.
                NamedBy.Custom(dbConfiguration.AreNamed);
        };

        OnCleanup clean = fakeAccessor => In<User>.Contexts.FeaturesAre().HandledByDefault();
    }
}