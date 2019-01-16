﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7_Collections
{
   // enum CardSuits{ Hearts, Diamonds, Spades, Clubs};

    class MyDeck<T> : IEnumerable<T>
    {

        T[] cards = new T[56];

        int currentIndex = 0;
        int counter = 0;
        public void Add(T item)
        {
            if (currentIndex > cards.Length - 1)
            {
                Array.Resize(ref cards, cards.Length * 3);
            }

          cards[currentIndex]=item;
            currentIndex++;
            counter++;
        }



        public IEnumerator<T> GetEnumerator()
        {
           for(int i = 0; i < currentIndex; i++)
            {
                yield return cards[i];
            }
        }

        //remove one card from deck

        public T[] Remove(T item)
        {
            int index = Array.IndexOf(cards,item);

            T[]  cardsNew = cards.Where((val, idx) => idx != index).ToArray();
            counter--;
            return cardsNew;
        }

        //count how many cards in the deck

            public int Count()
        {

            return counter;

        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}

