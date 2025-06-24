namespace BuilderPattern
{
    //Concrete Builder: ConcreteVenderProfileBuilder
    public class ConcreteVenderProfileBuilder : VenderProfileBuilder
    {
        public override void SetBasicInfo(string firstName, string lastName, string email)
        {
            VenderProfile.FirstName = firstName;
            VenderProfile.LastName = lastName;
            VenderProfile.Email = email;
        }

        public override void SetAddress(string street, string city, string state, string zip)
        {
            VenderProfile.StreetAddress = street;
            VenderProfile.City = city;
            VenderProfile.State = state;
            VenderProfile.ZipCode = zip;
        }

        public override void SetPreferences(bool newsletter, string theme)
        {
            VenderProfile.IsSubscribedToNewsletter = newsletter;
            VenderProfile.ThemePreference = theme;
        }
    }
}
