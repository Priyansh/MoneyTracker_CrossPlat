using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTracker_CrossPlat
{
    public class Tracker
    {
        public float Balance { get; set; }
        public List<Movement> lstMovements { get; set; }
        public Tracker()
        {
            lstMovements = new List<Movement>();
        }

        public void AddMovement(Movement movement)
        {
            lstMovements.Add(movement);
            Balance += (movement.Type) ? movement.Amount : -movement.Amount;
        }
    }
}
