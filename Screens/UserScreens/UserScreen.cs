namespace ToDo.Screens.UserScreens
{
    public static class UserScreen
    {
        public static void CreateUserScreen()
        {
            string? email, password;

            Console.Clear();

            Console.Write("Digite o email do usuário: ");
            email = Console.ReadLine();

            Console.Clear();

            Console.Write("Digite a senha do usuário: ");
            password = Console.ReadLine();
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