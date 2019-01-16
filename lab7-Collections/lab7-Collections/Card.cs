using System;
using System.Collections.Generic;
using System.Text;

namespace lab7_Collections
{
    public class Card
    {
        public string cardNum { get; set; }
        public string suit { get; set;}
     

        public Card(string cardN,string suitName)
        {
           
            cardNum=cardN;
            suit = suitName;
        }
    }
}
