using Todo.Screens;
using ToDo.Screens.UserScreens;

namespace ToDo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                HomeScreen.Home();

                choice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch(choice)
                {
                    case 1:
                        UserScreen.CreateUserScreen();
                        break;
                    case 2:
                        UserScreen.MatchEmailAndPassword();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Numero invalido, apenas 1 - 8");
                        break;
                }

            } while(choice != 8);
        }
    }
}