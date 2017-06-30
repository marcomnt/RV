using System.Collections.Generic;

namespace VRConsoleApp.Models
{
    class Mov
    {
        private List<Ges> gess;

        public Mov()
        {
            this.gess = new List<Ges>();
        }

        public void Add(Ges ges)
        {
            this.gess.Add(ges);
        }

        public void Remove(Ges ges)
        {
            this.gess.Remove(ges);
        }
        
    }
}
