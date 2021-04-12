using System.Collections.Generic;

namespace IntergenicResearchLibrary
{
    public class GenericDefaulterList<T> where T : IDefaulterList
    {
        List<T> Store { get; set; }

        public GenericDefaulterList()
        {
            Store = new List<T>();
        }

        public void Add(T entry)
        {
            Store.Add(entry);
        }

        public void Process()
        {
            if (Store.Count> 0)
            {
                foreach (var entity in Store)
                {
                    System.Console.WriteLine(entity.GetDefaulters());
                }
            }
        }
    }
}