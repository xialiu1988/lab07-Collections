using lab7_Collections;
using System;
using Xunit;

namespace CollectionsTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCard()
        {

            MyDeck<Card> myDeck = new MyDeck<Card>();
            Card card1 = new Card("7", Card.Suits.Diamonds);
            myDeck.Add(card1);
            int a = myDeck.Count();
            Assert.Equal(1, a);
        }



        [Fact]
        public void settersForcard()
        {

            MyDeck<Card> myDeck = new MyDeck<Card>();
            Card card1 = new Card("7", Card.Suits.Diamonds);
            card1.suit = Card.Suits.Clubs;
            myDeck.Add(card1);
            
            Assert.Equal(Card.Suits.Clubs, card1.suit );
        }


        [Fact]
        public void SettersForcardNumber()
        {

            MyDeck<Card> myDeck = new MyDeck<Card>();
            Card card1 = new Card("7", Card.Suits.Diamonds);
            card1.cardNum = "30";
            myDeck.Add(card1);

            Assert.Equal("30", card1.cardNum);
        }

        [Fact]
        public void GettersCardnumber()
        {
            MyDeck<Card> myDeck = new MyDeck<Card>();
            Card card1 = new Card("7", Card.Suits.Diamonds);
            myDeck.Add(card1);
            Assert.Equal("7", card1.cardNum);
        }
        [Fact]
        public void CanGetCardSuit()
        {
            MyDeck<Card> myDeck = new MyDeck<Card>();
            Card card1 = new Card("7", Card.Suits.Diamonds);
            myDeck.Add(card1);
            Assert.Equal(Card.Suits.Diamonds, card1.suit);
        }

        [Fact]
        public void CannotRemoveaItemNOtExsit()
        {
            MyDeck<Card> myDeck = new MyDeck<Card>();
            Card card1 = new Card("7", Card.Suits.Diamonds);
            Card card2 = new Card("2", Card.Suits.Hearts);

            myDeck.Add(card1);
            myDeck.Add(card2);

            myDeck.Remove(card1);
            myDeck.Remove(card1);

            Assert.Null(myDeck.Remove(card1));

        }


        [Fact]
        public void CanRemoveaItemWhenExsit()
        {
            MyDeck<Card> myDeck = new MyDeck<Card>();
            Card card1 = new Card("7", Card.Suits.Diamonds);
            Card card2 = new Card("2", Card.Suits.Hearts);
            Card card3 = new Card("Q", Card.Suits.Clubs);
            myDeck.Add(card1);
            myDeck.Add(card2);
            Card[] expected = new Card[] { card2 };
            Assert.Equal(expected[0].cardNum,myDeck.Remove(card1)[0].cardNum);

        }


        [Fact]
        public void CanGetCardInfo()
        {
            MyDeck<Card> myDeck = new MyDeck<Card>();
            Card card1 = new Card("7", Card.Suits.Diamonds);       
            myDeck.Add(card1);
            Assert.Equal("7", card1.cardNum);
            Assert.Equal(Card.Suits.Diamonds, card1.suit);
        }

    }
}
