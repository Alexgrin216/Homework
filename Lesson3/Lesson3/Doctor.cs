

namespace Lesson3
{
    public abstract class Doctor : ICure
    {
        public Doctor(string name, int age, string spec,int workexp)
        {
            Name = name;
            Age = age;
            Spec = spec;
            WorkExp = workexp;
        }
        public int WorkExp { get; set; }
        public string Spec { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public abstract void Cure(Disease disease);
        
    }
}
