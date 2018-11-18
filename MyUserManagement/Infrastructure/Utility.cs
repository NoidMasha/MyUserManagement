//namespace MyApplication.Infrastructure
namespace Infrastructure
{
    public static class Utility
    {
        static Utility()
        {
        }

        // **************************************************
        //public static System.Guid UserId { get; set; }

        public static Models.User AuthenticatedUser { get; set; }
        // **************************************************

        // **************************************************
        // **************************************************
        // **************************************************
        private static MyUserManagement.MainForm mainForm;
        // **************************************************

        // **************************************************
        /// <summary>
        /// Lazy Loading = Lazy Initialization
        /// </summary>
        public static MyUserManagement.MainForm MainForm
        {
            get
            {
                if (mainForm == null)
                {
                    mainForm =
                        new MyUserManagement.MainForm();
                    mainForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                }

                return mainForm;
            }
        }
        // **************************************************
        // **************************************************
        // **************************************************

        // **************************************************
        // **************************************************
        // **************************************************
        private static MyUserManagement.LoginForm loginForm;
        // **************************************************

        // **************************************************
        /// <summary>
        /// Lazy Loading = Lazy Initialization
        /// </summary>
        public static MyUserManagement.LoginForm LoginForm
        {
            get
            {
                if (loginForm == null)
                {
                    loginForm =
                        new MyUserManagement.LoginForm();
                }

                return loginForm;
            }
        }
        // **************************************************
        // **************************************************
        // **************************************************

        // **************************************************
        // **************************************************
        // **************************************************
        private static MyUserManagement.RegisterForm registerForm;
        // **************************************************

        // **************************************************
        /// <summary>
        /// Lazy Loading = Lazy Initialization
        /// </summary>
        public static MyUserManagement.RegisterForm RegisterForm
        {
            get
            {
                if (registerForm == null)
                {
                    registerForm =
                        new MyUserManagement.RegisterForm();
                    registerForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                }

                return registerForm;
            }
        }
        // **************************************************
        // **************************************************
        // **************************************************


        /// <summary>
        /// Checks a string and returns true if it doesn't contains invalid characters for username
        /// </summary>
        /// <param name="text">String to check</param>
        /// <param name="min">Minimum characters</param>
        /// <param name="max">Maximum characters</param>
        /// <returns></returns>
        public static bool validUsername(string text,int min,int max)
        {
            if (text.Length >= min && text.Length <= max)
            {
                System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex("[^A-Z0-9_]",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                return !r.IsMatch(text);
            }
            else { return false; }
        }

        /// <summary>
        /// Checks a string and returns true if it doesn't contains invalid characters for username
        /// </summary>
        /// <param name="text">String to check</param>
        /// <param name="min">Minimum characters</param>
        /// <param name="max">Maximum characters</param>
        /// <returns></returns>
        public static bool validPassword(string text, int min, int max)
        {
            if (text.Length >= min && text.Length <= max)
            {
                System.Text.RegularExpressions.Regex r1 = new System.Text.RegularExpressions.Regex("[0-9]",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                System.Text.RegularExpressions.Regex r2 = new System.Text.RegularExpressions.Regex("[A-Z]");
                System.Text.RegularExpressions.Regex r3 = new System.Text.RegularExpressions.Regex("[a-z]");
                System.Text.RegularExpressions.Regex r4 = new System.Text.RegularExpressions.Regex("[^A-Z0-9]",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                return (r1.IsMatch(text) & r2.IsMatch(text) & r3.IsMatch(text) & !r4.IsMatch(text));
            }
            else { return false; }
        }

        public static string getHashSha256(string text)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);
            System.Security.Cryptography.SHA256Managed hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += System.String.Format("{0:x2}", x);
            }
            return hashString;
        }

        ///// <summary>
        ///// Checks a string and returns true if it doesn't contain invalid chars for username
        ///// </summary>
        ///// <param name="text">String to check</param>
        ///// <returns></returns>
        //public static bool validUsername(string text)
        //{
        //    System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
        //        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
        //    if (r.IsMatch(text))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
        //public static bool userTextCheck(System.Windows.Forms.TextBox textBox)
        //{
        //    if (textBox.Text.Length>5 &&
        //        textBox.Text.Length<=20 &&
        //        !)
        //    return true;
        //}
    }
}
