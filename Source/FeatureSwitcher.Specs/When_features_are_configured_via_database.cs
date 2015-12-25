using FeatureSwitcher.Configuration;
using FeatureSwitcher.Specs.BehaviorConfigs;
using FeatureSwitcher.Specs.Domain;
using Machine.Specifications;
using Machine.Fakes;

namespace FeatureSwitcher.Specs
{
    [Subject("ConfigureByDatabase")]
    public class When_features_configurations_are_verified_for_a_normal_user : WithSubject<User>
    {
        Establish context = () => With<DatabaseBehaviorConfig>();

        Because of = () =>
        {
            Subject = new User(UserRole.Normalo, 2, 2);
            Features.Are.ConfiguredBy.Custom(
               ConfigureByDatabase.IsEnabled(The<IFeatureConfigurationRepository>().FeatureConfigurations, Subject)).And.NamedBy.Custom(ConfigureByDatabase.NamingConvention);
        };

        It should_have_feature_1_disabled = () => Feature<Test1Feature>.Is().Enabled.ShouldBeFalse();
        It should_have_feature_2_enabled = () => Feature<Test2Feature>.Is().Enabled.ShouldBeTrue();        
    }

    [Subject("ConfigureByDatabase")]
    public class When_features_configurations_are_verified_for_an_exact_user_id : WithSubject<User>
    {
        Establish context = () => With<DatabaseBehaviorConfig>();

        Because of = () =>
        {
            Subject = new User(UserRole.Admin, 111, null);
            Features.Are.ConfiguredBy.Custom(
               ConfigureByDatabase.IsEnabled(The<IFeatureConfigurationRepository>().FeatureConfigurations, Subject)).And.NamedBy.Custom(ConfigureByDatabase.NamingConvention);
        };

        It should_have_feature_1_disabled = () => Feature<Test1Feature>.Is().Enabled.ShouldBeTrue();
        It should_have_feature_2_disabled = () => Feature<Test2Feature>.Is().Enabled.ShouldBeFalse();
    }
}
