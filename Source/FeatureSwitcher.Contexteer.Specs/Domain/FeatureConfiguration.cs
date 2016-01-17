namespace FeatureSwitcher.Contexteer.Specs.Domain
{
    public class FeatureConfiguration
    {
        public long Id { get; set; }
        public string FeatureName { get; set; }
        public long? ClientId { get; set; }
        public long? UseraccountId { get; set; }
        public UserRole Role { get; set; }
    }
}