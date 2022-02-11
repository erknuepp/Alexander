namespace Assets.Scripts
{
    using System.IO;

    public static class DataLayer
    {
        public static string GetDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        public static void CreateAndWriteFile(string text, string path = @".\score.txt")
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(text);
            }            
        }

        public static string ReadFile(string path = @".\score.txt")
        {
            // Open the file to read from.
            if (File.Exists(path)) {
                using (StreamReader sr = File.OpenText(path))
                {
                    return sr.ReadLine();
                }
            }
            else
            {
                return "0";
            }            
        }
    }
}