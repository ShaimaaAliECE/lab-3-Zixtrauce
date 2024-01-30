

namespace Lab3App

{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Tool : Collectable
    {
        public Tool(string description) : base(description)
        {
        }
        public abstract void DoAction();
        override public void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
            Console.WriteLine(base.Description + " Collected! Congrats!");
            DoAction();
            
        }
    }
}