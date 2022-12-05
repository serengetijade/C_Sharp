using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//This class contains all the 'rules' for the TwentyOne Game: methods that can be called elsewhere.
//Because these methods/objects/properties are only going to be used inside of this class, they are all have the 'private' access modifier.

namespace ClassLibrary_Casino.TwentyOne
{
    public class TwentyOneRules
    {
        //Initialize a dictionary object:
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Ace] = 1,
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
        };

        //Define a Method Syntax: accessModifier optional:returnType Type functionName(dataType parameter){}
        private static int[] GetAllPossibleHandValues(List<Card> Hand)  //Type is an array of integers.
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);     //Count the number of a specific occurance, i.e. Property.Value
            int[] result = new int[aceCount + 1];                   //Initialize an Array Syntax: Type[] arrayName = new dataType[#length]; //Arrays MUST declare the length. 'result' is a count of how many possible outcomes there our for ace combinations. And there is ALWAYS one more possible combinations than the number of aces in a given hand, for example: With two aces in hand all possibilities are: (Ace=1, Ace=10) -or- (Ace=10, Ace=10) -or- (Ace=1, Ace=1)....There are 3 possibilities.
            int value = Hand.Sum(x => _cardValues[x.Face]);         //.Sum method summarizes the values for the given key (x.Face), for keys within the 'Hand' object
            result[0] = value;                                      //For each (new) Hand, set the value of the array object an index[0], the value is the value from the line above. 
            if (result.Length == 1) return result;                  //Shorthand way to write a single if statement. 
            for(int i = 1; i < result.Length; i++)                  //When there is more than one result (i.e. more than one ace in the hand), start at index 1, because result[0] is already defined above.
            {
                value += (i * 10);                                  //Shorthand for: value = value + (i * 10); When there is more than one ace in the hand, this will add 10 to the default value (1) of the ace, making 10+1 = 11.
                result[i] = value;                                  //Set result[i] as the value (where ace is worth 11).
            }
            return result;
        }

        //Define a Method Syntax: accessModifier optional:returnType Type functionName(dataType parameter){}
        public static bool CheckForBlackJack(List<Card> Hand)        //Pass in a list of Card objects, called Hand
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);   //Initialize an Array by calling a method and passing in 'Hand'
            int value = possibleValues.Max();                        //Find the max value of a hand.
            if (value == 21) return true;
            else return false;
        }

        //Define a Method Syntax: accessModifier optional:returnType Type functionName(dataType parameter){}
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        //Define a Method Syntax: accessModifier optional:returnType Type functionName(dataType parameter){}
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)      //Check each hand value to determine what to do:
                {
                    return true;
                }
            }
            return false;
        }

        //Define a Method Syntax: accessModifier optional:returnType Type functionName(dataType parameter){}
        //This method uses bool? which allows a bool to return true, false, OR null. 
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);
            //Get the max score that is less than 22:
            int playerScore = playerResults.Where(x => x < 22).Max(); //Use a lambda expression to find which possible hand values are less than 22. Then use .Max to get the largest possibility.  
            int dealerScore = dealerResults.Where(x => x < 22).Max();
            //Compare the player's score to the dealer:
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;  //Return null if neither condition is met; i.e. if they tie score.
        }
    }
}