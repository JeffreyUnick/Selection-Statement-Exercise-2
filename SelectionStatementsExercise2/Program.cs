using System.Threading.Channels;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heyyy what's up !!? What was your favorite subject at school ?");
            string favSchoolSubject = Console.ReadLine()?.Trim().ToLower();


            switch(favSchoolSubject)
            {
                case "math" :
                Console.WriteLine("Good choice. Math is a very interesting subject.");
                break;

                case "physics" :
                Console.WriteLine("Physics is so wide and the applications so diverse. I use to love it.");
                break;

                case "biology" :
                Console.WriteLine(" Humm Biology my second favorite subject. Love it !!");
                break;

                case "english" :
                Console.WriteLine("Oooh no English !? Really ? It use to be so boring to me. " +
                                  "But it's ok ");
                break;

                case "history" :
                Console.WriteLine(" Who do not like History ? It's literally the most interesting subject.");
                break;

                default:
                Console.WriteLine($"{favSchoolSubject} is definitely a good subject. What do you like about it ?");
                break;
            }
            
        

        }
    }
}