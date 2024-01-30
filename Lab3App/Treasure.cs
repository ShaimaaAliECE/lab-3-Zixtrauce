using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        private int score;
        public Treasure(string description, int score) : base(description)
        {
            this.score = score;
        }
        public void UpdateTotalScore()
        {
            base.Board.TotalScore += score;
        }

       
        public override void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
            UpdateTotalScore();
            Console.WriteLine(base.Description + " Collected! Congrats!");
            Console.WriteLine("Total Score is updated to: " + base.Board.TotalScore);
        }
    }
}