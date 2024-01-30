using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        private int value;
        public Coin(string description, int score, int value) : base(description, score)
        {
            this.value = value;
        }
        public void UpdateTotalValue()
        {
            base.Board.TotalValue += value;
        }
        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);
            UpdateTotalValue();
        }
    }
}