using System.Collections.Generic;

namespace FeatureSwitcher.Contexteer.Specs.Domain
{
    //class FeatureConfigurationRepository
    public class FeatureConfigurationRepository : IFeatureConfigurationRepository
    {
        /// <summary>
        /// Constructs the list of existent features
        /// </summary>
        /// <param name="featureConfigurations"></param>
        public FeatureConfigurationRepository(IList<FeatureConfiguration> featureConfigurations)
        {
            FeatureConfigurations = featureConfigurations;
        }

        /// <summary>
        /// Existent features
        /// </summary>
        public IList<FeatureConfiguration> FeatureConfigurations { get; private set; }
    }
}