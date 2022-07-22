using System;

namespace StringsAll
{
    class Program
    {
        public static object Date { get; private set; }

        static void Main(string[] args)
        {
        }
        static void GerarId()
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("a72fb5cf-068a-4d98-b189-09371ef75f56");
            Console.WriteLine(id.ToString().Substring(0, 8));
            var data = DateTime.Now;
            Console.WriteLine(data.DayOfYear);
        }
    }
}
