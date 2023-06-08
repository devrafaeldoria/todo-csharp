namespace ToDo
{
    public class Login
    {
        private bool logged = false;

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