using System.Collections.Generic;

namespace FeatureSwitcher.Specs.Domain
{
    public interface IFeatureConfigurationRepository
    {
        IList<FeatureConfiguration> FeatureConfigurations { get; }
    }
}