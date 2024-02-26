namespace EvolveSettings
{
    class SqlConnectionHelper
    {
        public static string connectReturn()
        {
            return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("EvolveSettingsDb.mdf") + "; Integrated Security=True;Connect Timeout=30");
        }
    }
}
