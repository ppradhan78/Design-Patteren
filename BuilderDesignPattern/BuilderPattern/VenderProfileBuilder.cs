namespace BuilderPattern
{
    //Builder (Abstract Builder)
    public abstract class VenderProfileBuilder
    {
        protected VenderProfile VenderProfile { get; private set; } = new VenderProfile();

        public abstract void SetBasicInfo(string firstName, string lastName, string email);
        public abstract void SetAddress(string street, string city, string state, string zip);
        public abstract void SetPreferences(bool newsletter, string theme);

        public VenderProfile GetUserProfile() => VenderProfile;
    }
}
