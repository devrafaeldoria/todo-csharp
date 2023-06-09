namespace ToDo
{
    public class Login
    {
        private static bool logged = false;

        public static void IsLogged(bool isValid)
        {
            logged = isValid;
        }

        public static bool GetLogged()
        {
            return logged;
        }
    }
}