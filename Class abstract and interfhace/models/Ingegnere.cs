using My;
using Padre;

namespace Ingegnere
{
    public class Ingegnere : AbstractPersona , IIngegnere
    {   
        public string City {get; set;}
        public string Team {get; set;}
        public Ingegnere(string name, string surname, double id, string city, string team) : base(name, surname, id)
        {
            City = city;
            Team = team;
        }
        public override void Print()
        {
             Console.WriteLine(@"Nome: {1}, Surname:{2}, Id: {3}", Name,Surname, Id);
        }

        public void ElencoProgetto()
        {
            Console.WriteLine($"Questi sono i progetti dell' ingenere{Name}, {Surname}");
        }
    }
}