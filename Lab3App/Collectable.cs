using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
    class Collectable : Displayable
    {
        public CollectionBoard Board;
        public string Description;
        public Collectable(string description)
        {
            Description = description;
        }
        public virtual void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
        }
        public void Display()
        {
            Console.WriteLine(this.GetType().Name + " " + Description + " is displayed.");
        }
    }
}