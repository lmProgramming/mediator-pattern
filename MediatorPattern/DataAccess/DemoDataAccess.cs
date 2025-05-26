using MediatorPattern.Models;

namespace MediatorPattern.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = [];

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 0, FirstName = "Mikolaj", LastName = "Kubs" });
            people.Add(new PersonModel { Id = 1, FirstName = "Adam", LastName = "Bobo" });
            people.Add(new PersonModel { Id = 2, FirstName = "Ewa", LastName = "Kopeć" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            var person = new PersonModel { Id = people.Max(p => p.Id) + 1, FirstName = firstName, LastName = lastName };
            people.Add(person);
            return person;
        }
    }
}
