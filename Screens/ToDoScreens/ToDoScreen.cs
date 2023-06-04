namespace ToDo.Screens.ToDoScreens
{
    public class ToDoScreen
    {
        public static void CreateListScreen()
        {
            string? name, description;

            Console.Clear();

            Console.Write("Digite o nome da lista: ");
            name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Digite a descrição da lista");
            description = Console.ReadLine();
        }
        public static void ListAllScreen()
        {
            int choice;

            Console.Clear();

            Console.WriteLine("1 - Todas");
            Console.WriteLine("2 - Finalizadas");
            Console.WriteLine("3 - Nao finalizadas");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

        public static void RemoveList()
        {
            int id;

            Console.Clear();

            Console.Write("Digite o id da Lista: ");
            id = int.Parse(Console.ReadLine());
        }
        public static void UpdateList()
        {
            int id;

            Console.Clear();

            Console.Write("Digite o id da Lista: ");
            id = int.Parse(Console.ReadLine());
        }
        public static void FinishList()
        {
            int id;

            Console.Clear();

            Console.Write("Digite o id da Lista: ");
            id = int.Parse(Console.ReadLine());
        }
        
    }
}