namespace Padre
{
    public abstract class AbstractPersona
    {
        public string Name { get; set;}
        public string Surname { get;set; }
        public double Id { get;set;}
        
        public AbstractPersona(string name,string surname , double id)
        {
            Name = name;
            Surname = surname;
            Id = id;
        }
        public abstract void Print();
    }
} 