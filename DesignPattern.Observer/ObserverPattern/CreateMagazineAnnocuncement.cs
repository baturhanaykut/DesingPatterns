using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnocuncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        Context context = new Context();
        public CreateMagazineAnnocuncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim Dergimizin Mart Sayısı 1 Martta evinize ulaştırılacaktır. Konular Jupite GEzeni ve Mars olacaktır."
            });

            context.SaveChanges();
        }
    }
}
