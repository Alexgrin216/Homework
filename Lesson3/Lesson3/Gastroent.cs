

namespace Lesson3
{
    public class Gastroent:Doctor
    {
        public Gastroent(string name, int age, string spec, int workexp) : base(name, age, spec, workexp)
        {

        }
        public override void Cure(Disease disease)
        {
            if (disease.StomachDis)
            {
                disease.StomachDis = false;
            }
            else
            {
                Console.WriteLine($"Пациент {Name},у вас нет проблем с желудком");
            }
        }
    }
}
