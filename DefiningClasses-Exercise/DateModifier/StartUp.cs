using DateModifier;
namespace DateModifier
{
    public class StartUp
    {
        static void Main()
        {
            var startDate = DateTime.Parse(Console.ReadLine());
            var endDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(DateModifier.GetDiff(startDate,endDate));
        }
    }
}
