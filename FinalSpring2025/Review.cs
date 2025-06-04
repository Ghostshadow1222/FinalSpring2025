using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSpring2025
{
    internal class Review
    {
        // Implemented C# properties written out, allowing for more modularity and future changes
        private int reviewId;

        public int ReviewId
        {
            get { return reviewId; }
            set { reviewId = value; }
        }

        private int customerId;

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        private int dessertId;
        
        public int DessertId
        {
            get { return dessertId; }
            set { dessertId = value; }
        }

        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
