using System;

namespace PracticalWork_2
{
    internal class Program
    {
        static void Main()
        {
            //Исходные данные
            string fullName = "Безгребельный Валерий Николаевич";
            string mail = "frostmols@gmail.com";

            int age = 27;

            float programmingScore = 85.2f;
            float mathematicsScore = 89.9f;
            float physicsScore = 69.6f;

            float averageScore = (programmingScore + mathematicsScore + physicsScore) / 3;

            //Паттерны для вывода результата
            string namePattern = $"Имя: {fullName}";
            string agePattern = $"Возраст: {age}";
            string mailPattern = $"Почта: {mail}";
            string programmingPatern = $"Програмирование: {programmingScore}";
            string mathematicsPattern = $"Математика: {mathematicsScore}";
            string physicsPattern = $"Физика: {physicsScore}";
            string averagePattern = $"Средний балл: {averageScore.ToString("#.##")}";

            string pattern = $"{namePattern} \n{agePattern} \n{mailPattern} \nБаллы: \n\t{programmingPatern} \n\t{mathematicsPattern} \n\t{physicsPattern} \n\n{averagePattern}";

            Console.WriteLine(pattern);
            Console.ReadLine();
        }
    }
}
