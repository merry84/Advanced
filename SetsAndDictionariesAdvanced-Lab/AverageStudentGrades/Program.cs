using System.Data;

namespace AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                string[] studetsInfo = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                string nameStudent = studetsInfo[0];
                decimal gradeStudent = decimal.Parse(studetsInfo[1]);
                if (!students.ContainsKey(nameStudent))//ако не съществува такъв -създай го
                {
                    students.Add(nameStudent, new List<decimal>());
                }
                // ако съществува добави оценката му

                students[nameStudent].Add(gradeStudent);
            }

            foreach (var grade in students)
            {
                Console.WriteLine($"{grade.Key} -> {string.Join(" ", grade.Value.Select(grade => $"{grade:F2}"))} (avg: {grade.Value.Average():f2})");
            }
        }
    }
}
