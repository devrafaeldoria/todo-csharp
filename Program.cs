using Todo.Screens;
using ToDo.Screens.ToDoScreens;
using ToDo.Screens.UserScreens;

namespace ToDo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Login = new Login();
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
                        if(Login.IsLogged)
                        {
                            ToDoScreen.CreateListScreen();
                        } else 
                        {
                            Console.WriteLine("Nao autorizado, realize o login primeiro");
                        }
                        
                        break;
                    case 4:
                        ToDoScreen.ListAllScreen();
                        break;
                    case 5:
                        ToDoScreen.RemoveList();
                        break;
                    case 6:
                        ToDoScreen.UpdateList();
                        break;
                    case 7:
                        ToDoScreen.FinishList();
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