namespace CharterSampleApp.Services
{
    public class Repository : IRepository
    {
        public Repository()
        {
                
        }

        public bool GetSignInStatus()
        {
            App.UserSignedIn = true;
            return true;
        }
    }
}
