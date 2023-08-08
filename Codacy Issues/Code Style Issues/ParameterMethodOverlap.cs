
namespace Codacy_Issues.Code_Style_Issues
{
    internal class ParamterMethodOverlap
    {

        public static void Attack(string attackType, string person)
        {
            Console.WriteLine($"{person} has been attacked with the {attackType} attack");
        }
    }
}
