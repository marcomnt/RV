using System.Collections.Generic;

namespace VRConsoleApp.Models
{
    class Dic
    {
        private Dictionary<Mov, Act> dic;

        public Dic()
        {
            this.dic = new Dictionary<Mov, Act>();
        }

        public void Add(Mov mov, Act act)
        {
            this.dic.Add(mov, act);
        }

        public void Remove(Mov mov)
        {
            this.dic.Remove(mov);
        }

        public Act Find(Mov mov)
        {
            Act act;
            this.dic.TryGetValue(mov, out act);
            return act;
        }

        public void Clear()
        {
            this.dic.Clear();
        }
    }
}
