namespace Quiz.Utilies.Extentions
{
    public static class FileExtention
    {
        public static bool CheckType(this IFormFile file, string type)
            => file.ContentType.Contains(type);
        public static bool CheckSize(this IFormFile file, int kb)
            => kb * 1024 < file.Length;
        public static void SaveFile(this IFormFile file, string path)
        {
            string filename = ChangeFileName(file.FileName);
            using (FileStream fs = new FileStream(Path.Combine(path, filename), FileMode.Create))
            {
                file.CopyTo(fs);
            }
        }
        static string ChangeFileName(string oldname)
        {
            string extention = oldname.Substring(oldname.LastIndexOf("."));
            if (oldname.Length < 30)
            {
                oldname = oldname.Substring(0, oldname.LastIndexOf("."));
            }
            else
            {
                oldname = oldname.Substring(0, 29);
            }
            return Guid.NewGuid() + oldname + extention;
        }
    }
}
