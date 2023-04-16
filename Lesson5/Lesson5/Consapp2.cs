namespace Lesson5
{
    class Program2
    {
        public static List<(string name, DateTime creationTime, string type)> Parse(string str)
        {
            string[] rawStrings = str.Split("\t");
            var result = new List<(string name, DateTime creationTime, string type)>();

            for (int i = 0; i < rawStrings.Length - 1; i += 3)
            {
                result.Add((rawStrings[i], Convert.ToDateTime(rawStrings[i + 1]), rawStrings[i + 2]));
            }

            var orderresult=result.OrderBy(x => x.creationTime).ToList();
              
            return result;
        }

        
      
    }

}
