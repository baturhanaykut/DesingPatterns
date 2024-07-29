namespace DesignPattern.TemplateMethod.TemplatePattern
{
    public abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            PlantType(string.Empty);
            CountPerson(0);
            CountPerson(0);
            Resolution(string.Empty);
            Content(string.Empty);
        }
        public abstract string PlantType(string planType);
        public abstract int CountPerson(int countPerson);
        public abstract double Price(double price);
        public abstract string Resolution(string resolution);
        public abstract string Content(string content);
    }
}
