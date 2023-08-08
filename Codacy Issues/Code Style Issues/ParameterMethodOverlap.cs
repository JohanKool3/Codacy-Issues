
namespace Codacy_Issues.Code_Style_Issues
{
    internal class ParameterMethodOverlap
    {

        public static void Attack(string attackType, string person)
        {
            Console.WriteLine($"{person} has been attacked with the {attackType} attack");
        }
    }
}
