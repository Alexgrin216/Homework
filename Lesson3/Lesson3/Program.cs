
using Lesson3;


public class Programm
{
    public static void Main(string[] args)
    {
        Patient p1 = new Patient("Иван", 23, "Алеутская 4");
        p1.disease.StomachDis = false;
        p1.disease.EyeDis = true;
        p1.disease.HearthDis = false;

        Patient p2 = new Patient("Лиля", 18, "9 мая 34");
        p2.disease.StomachDis = true;
        p2.disease.EyeDis = false;
        p2.disease.HearthDis = false;

        Patient p3 = new Patient("Максим", 56, "Захарова 78");
        p3.disease.StomachDis = false;
        p3.disease.EyeDis = false;
        p3.disease.HearthDis = true;

        Ophtalm d1 = new Ophtalm("Олег", 42, "Окулист", 12);
        d1.Cure(p1.disease);
        Cardio d2 = new Cardio("Елена", 36, "Кардиолог", 9);
        d2.Cure(p3.disease);
        Gastroent d3 = new Gastroent("Глеб", 53, "Гастроэнтеролог", 23);
        d3.Cure(p2.disease);
    }

    
}
