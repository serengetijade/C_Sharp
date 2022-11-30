using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOne
{
    //Inherit from Game Class: 
    public class TwentyOneGame : Game, IWalkAway
    {
        //Define any properties unique to the TwentyOneGame:
        public TwentyOneDealer Dealer { get; set; }

        //Define Play method to be one round of the game: 
        public override void Play()                 //Because methods from the parent class are defined as abstract in Game.cs, MUST apply the OVERRIDE keyword to use and modify it
        {
            //To begin each round, instantiate player and dealer hands:
            Dealer = new TwentyOneDealer();         //Instantiate the 'Dealer' object as a new instance of the 'TwentyOneDealer' class 
            foreach (Player player in Players)      //Player is a class defined in Player.cs. player is the programmer chosen name for each iteration. Players is a list property defined in Game.cs
            {
                //Syntax to define a property value: instanceName.propertyName = value;
                player.Hand = new List<Card>();     //Define the property value for this instance as a new (empty) List of Card objects.
                player.Stay = false;                //Define the property value for this instance as false, it is now the default value.
            }
            //Syntax to define a property value: instanceName.propertyName = value;
            Dealer.Hand = new List<Card>();         //Create a new Dealer 'Hand' for each round.
            Dealer.Stay = false;                    //Define the property value for this instance as false, it is now the default value.
            Dealer.Deck = new Deck();               //Refresh the deck for each round. Define the property value for this instance to be the result of the Deck method (defined in Deck.cs). 
            Dealer.Deck.Shuffle();                  //Apply the .Shuffle method to the Deck property.

            //Collect bet information from the player and add it to Bets dictionary:
            Console.WriteLine("Place your bet!");
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);     //Pass the amount the player enters into the Bet method (defined in Player.cs)
                if (!successfullyBet)
                {
                    return;                         //Use return to end this method if the player did not successfully bet.
                }
                Bets[player] = bet;                 //Add to the Bets dictionary (defined in Game.cs) 
            }

            //Deal two cards (by performing two loop iterations) and check for blackjack:
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    //Apply .Deal method to player.Hand:
                    Console.Write("{0}:", player.Name);
                    Dealer.Deal(player.Hand);      //Pass in the player.Hand property, which was defined above and before the first iteration, existed as an empty list. Because .Deal (defined in Dealer.cs) is a void method, it must be called as Dealer.Deal. By passing in player.Hand, the .Deal method affects that object, see Dealer.cs.
                                        //After the second iteration (note: int i=0 is the first iteration, then int i=1 is the second), check for blackjack:
                    if (i == 1) 
                    {
                        //Call a static method and pass in player.Hand
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}!", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32(Bets[player] * 1.5 + Bets[player]);     //If a player gets blackjack, they get this added to their player.Balance
                            //Bets.Remove(player);    //Remove him from the list of players to ensure he doesn't get paid out again if the dealer busts.
                            return;                 //End the round if the player gets blackjack.
                        }
                    }

                    //Apply .Deal method to Dealer.Hand:
                    Console.Write("Dealer: ");
                    Dealer.Deal(Dealer.Hand);
                    if (i == 1)
                    {
                        //Call a static method and pass in the Dealer.Hand
                        bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                        if (blackJack) 
                        {
                            Console.WriteLine("Dealer has Blackjack! Everyone loses.");
                            foreach (KeyValuePair<Player, int> obj in Bets)
                            {
                                Dealer.Balance += obj.Value;
                            }
                            //After the dealer gets blackjack, ask the player if they want to keep playing: 
                            Console.WriteLine("Play again?");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                            {
                                player.isActivelyPlaying = true;
                                return;
                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                                return;           
                            }
                        }
                    }
                }
            }

            //Ask player to hit or stay, then check isBusted:
            foreach (Player player in Players)
            {
                while (!player.Stay)  //While loop if the player is NOT player.Stay, 
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay") 
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);     //Call this method (defined in TwentyOneGame.cs) and pass in player.Hand
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];     //If busted = true, add the balance of the player's bet (defined in Player.cs) to Dealer.Balance (defined in Dealer.cs)
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance); ;
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }

            //Define the dealer's actions: 
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)   //If Neither condition is met, the dealer gets another card then checks the conditions again: 
            {
                Console.WriteLine("Dealer is hitting....");
                Dealer.Deal(Dealer.Hand);   //Deal method is defined in Dealer.cs - it adds the next card in the deck to the hand.
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);  //Overrides the value of this method by defining the value as the result of the ShouldDealerStay method (defined in TwentyOneRules.cs).
            }
            if (Dealer.Stay)       //If this method (defined just above and in TwentyoneRules.cs) is true, do this:
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)   //If this method (defined just above and in TwentyoneRules.cs) returns true, do this: 
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)    //Bets is a dictionary defined as a property of Game class in Game.cs. The key value pair is created when the player makes a bet (defined abvoe)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);   //Use a lambda expression to add value to the appropriate balance.
                    //This lambda expression loops through each KVP in Players and find those that match a given Name property. Then it takes the first (and only) KVP, and add to its balance.
                    Dealer.Balance -= entry.Value;   //Subtract the value of the bet from the dealer's balance.
                }
                //After the dealer busts, ask the player if they want to keep playing: 
                foreach (Player player in Players)
                {
                    Console.WriteLine("Play again?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                    {
                        player.isActivelyPlaying = true;
                        return;
                    }
                    else
                    {
                        player.isActivelyPlaying = false;
                        return;
                    }
                }
            }

            //If no one busted, compare hand values and dispense winnings:
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];     //Bets is a dictionary defined above to track what the player bets. [player] is the key, and the value is what gets added to Balance.
                    Bets.Remove(player);                //Remove the KVP with key 'player' from the Bets dictionary. This serves to clear it out/reset it before the next round.
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}.", player.Name, Bets[player]);  //Recall: Bets[player] is the key to acces the value of the Bets dictionary, which is the amount the player bet above.
                    player.Balance += (Bets[player] * 2);  //Add the winnings to the player's .Balance.
                    Dealer.Balance -= Bets[player];        //Subtract the winnings from the dealer's .Balance.
                }
                else
                {
                    Console.WriteLine("The Dealer wins {0}.", Bets[player]);       //Recall: Bets[player] is the key to acces the value of the Bets dictionary, which is the amount the player bet above.
                    Dealer.Balance += Bets[player];        //Add the bet value to the dealer's .Balance.
                }

                //Ask the player if they want to keep playing: 
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        //To inherit an interface method, MUST implement it (and it must match the interface definition): 
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
