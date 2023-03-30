

namespace Lesson3
{
    public class Patient
    {
        public Patient(string name, int age,string adress)
        {
            Name = name;
            Age= age;
            Adress= adress; 
        }
        public string Name { get; set;}
        public int Age { get; set;}        
        public string Adress { get; set;}
        public Disease disease = new Disease();
        
    }
}
