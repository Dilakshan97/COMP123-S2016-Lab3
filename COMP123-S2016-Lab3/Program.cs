﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author : Dilakshan Packiyanathan
 * Student Number : 300843256

 */
namespace COMP123_Lab3
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {

        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
        

            Deck deck = new Deck(); // create a deck of cards
            deck.Display(); // display the initial state of the deck

            deck.Shuffle(); // shuffle the deck
            deck.Display(); // display shuffled deck
            

            Card cardDealt = deck.Deal();
            Console.WriteLine("Card dealt: {0} of {1}", cardDealt.Face, cardDealt.Suit);
            Console.WriteLine();
            deck.Display();


        }


    }
}