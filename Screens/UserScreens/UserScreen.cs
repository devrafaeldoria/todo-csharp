using ToDo.Models;
using ToDo.Repositories;

namespace ToDo.Screens.UserScreens
{
    public static class UserScreen
    {
        public static void CreateUserScreen()
        {
            var repository = new Repository<User>(Database.connection);
            string? email, password;

            Console.Clear();

            Console.Write("Digite o email do usuário: ");
            email = Console.ReadLine();

            Console.Clear();

            Console.Write("Digite a senha do usuário: ");
            password = Console.ReadLine();

            var user = new User 
            {
                Email = email,
                Password = password
            };

            repository.Create(user);
        }
        public static void MatchEmailAndPassword()
        {
            string? email, password;

            Console.Clear();

            Console.Write("Digite o email do usuário: ");
            email = Console.ReadLine();

            Console.Clear();

            Console.Write("Digite a senha do usuário: ");
            password = Console.ReadLine();
        }
    }
}