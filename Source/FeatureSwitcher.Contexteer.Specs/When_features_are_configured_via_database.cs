using FeatureSwitcher.Contexteer.Specs.BehaviorConfigs;
using FeatureSwitcher.Contexteer.Specs.Domain;
using Machine.Specifications;
using Machine.Fakes;

namespace FeatureSwitcher.Contexteer.Specs
{
    [Subject("ConfigureByDatabase")]
    public class When_features_configurations_are_verified_for_a_normal_user : WithSubject<User>
    {
        Establish context = () => With<DatabaseBehaviorConfig>();

        Because of = () =>
        {
            Subject = new User(UserRole.Normalo, 2, 2);
        };

        It should_have_feature_1_disabled = () => Feature<Test1Feature>.Is().EnabledInContextOf(Subject).ShouldBeFalse();
        It should_have_feature_2_enabled = () => Feature<Test2Feature>.Is().EnabledInContextOf(Subject).ShouldBeTrue();
    }

    [Subject("ConfigureByDatabase")]
    public class When_features_configurations_are_verified_for_an_exact_user_id : WithSubject<User>
    {
        Establish context = () => With<DatabaseBehaviorConfig>();

        Because of = () =>
        {
            Subject = new User(UserRole.Admin, 111, null);
        };

        It should_have_feature_1_disabled = () => Feature<Test1Feature>.Is().EnabledInContextOf(Subject).ShouldBeTrue();
        It should_have_feature_2_disabled = () => Feature<Test2Feature>.Is().EnabledInContextOf(Subject).ShouldBeFalse();
    }
}