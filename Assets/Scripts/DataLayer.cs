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

            //// Open the file to read from.
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s;
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
        }
        
    }
}