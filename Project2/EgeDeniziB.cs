using System.Collections.Generic;
namespace Project2
{
    internal class EgeDeniziB
    {
        public string name { get; set; }
        public string otherName { get; set; }
        public string size { get; set; }
        public List<string> EnvironmentList { get; set; }
        public string information { get; set; }

        //Constructor
        public EgeDeniziB()
        {
            name = null;
            otherName = null;
            size = null;
            EnvironmentList = new List<string>();
            information = null;
        }

        public override string ToString()
        {
            return $"Name: {name}\n" +
                   $"Other Name: {otherName}\n"+
                   $"Size: {size}\n" +
                   $"Environment: {string.Join(", ", EnvironmentList)}\n" +
                   $"Information: {information}\n";
        }
    }
}
