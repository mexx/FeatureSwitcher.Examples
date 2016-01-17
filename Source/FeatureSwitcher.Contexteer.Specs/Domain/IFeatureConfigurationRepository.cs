using System.Collections.Generic;

namespace FeatureSwitcher.Contexteer.Specs.Domain
{
    public interface IFeatureConfigurationRepository
    {
        IList<FeatureConfiguration> FeatureConfigurations { get; }
    }
}