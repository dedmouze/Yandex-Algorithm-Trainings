using System;
using System.Collections.Generic;

string[] player1 = Console.ReadLine().Split(' ');
string[] player2 = Console.ReadLine().Split(' ');

Queue<int> deck1 = new Queue<int>();
Queue<int> deck2 = new Queue<int>();

for(int i = 0; i < 5; i++)
{
    deck1.Enqueue(int.Parse(player1[i]));
    deck2.Enqueue(int.Parse(player2[i]));
}

int j = 0;
while(deck1.Count != 0 && deck2.Count != 0)
{
    if (j == 1000000)
    {
        Console.WriteLine("botva");
        return;
    }
    
    int card1 = deck1.Dequeue();
    int card2 = deck2.Dequeue();

    if(card1 == 0 && card2 == 9)
    {
        deck1.Enqueue(card1);
        deck1.Enqueue(card2);
    }
    else if(card1 == 9 && card2 == 0)
    {
        deck2.Enqueue(card1);
        deck2.Enqueue(card2);
    }
    else if(card1 > card2)
    {
        deck1.Enqueue(card1);
        deck1.Enqueue(card2);
    }
    else
    {
        deck2.Enqueue(card1);
        deck2.Enqueue(card2);
    }

    j++;
}

if (deck1.Count == 0) Console.WriteLine("second " + j);
if (deck2.Count == 0) Console.WriteLine("first " + j);