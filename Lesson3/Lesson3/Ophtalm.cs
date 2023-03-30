

namespace Lesson3

{
    public class Ophtalm : Doctor
    {
        public Ophtalm(string name, int age, string spec, int workexp) : base(name, age, spec, workexp)
        {

        }
        public override void Cure(Disease disease)
        {
            if (disease.EyeDis)
            {
                disease.EyeDis = false; 
            }
            else
            {
                Console.WriteLine($"Пациент {Name},у вас нет проблем с зрением");
            }
        } 
    }
} 
