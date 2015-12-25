using FeatureSwitcher.Configuration;
using FeatureSwitcher.Specs.Domain;
using Machine.Fakes;
using System.Collections.Generic;

namespace FeatureSwitcher.Specs.BehaviorConfigs
{
    public class DatabaseBehaviorConfig
    {
        OnEstablish context = fakeAccessor =>
        {
            var config1 = new FeatureConfiguration() { Id = 1, FeatureName = "Test1Feature", ClientId = 1 };
            var config2 = new FeatureConfiguration() { Id = 2, FeatureName = "Test1Feature", UseraccountId = 111 };
            var config3 = new FeatureConfiguration() { Id = 3, FeatureName = "Test2Feature", Role = UserRole.Normalo };
            var features = new List<FeatureConfiguration> { config1, config2, config3 };

            fakeAccessor.The<IFeatureConfigurationRepository>()
                .WhenToldTo(x => x.FeatureConfigurations)
                .Return(features);
        };

        OnCleanup clean = fakeAccessor => Features.Are.HandledByDefault();        
    }
}
