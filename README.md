# C-Sharp-Tarot-Program
This program was originally created for a Course which gave this prompt:

**Cards**

*The API will deliver a data structure representing a random draw from a deck of fifty-two standard playing cards. 
The structure will contain the numerical value of the card, the face value, the suit and a representation of the image of the card.
The application will simulate a card game of your choice. Since the API will not 'remember' what card it dealt last, 
your application must keep track of what cards have been dealt. If it receives a card that has already been dealt, 
it must request a new card.*

After talking with my Professor, I altered the project to shuffle a deck of Tarot cards and deal 13 of the 78 cards into a layout
like the one seen below:
```
                                |11|  |12|  |13|
           |4|                  |10|
 |6|  |3|  |1|  |2|  |7|        |9|
           |5|                  |8|
```

It was fairly straightforward and didn't even begin to delve into the intricacies of what the program could be. Each
position represents a meaning, and each card has an individual meaning.

1. This card represents the inquirer.
2. This card represenets the helpful forces around the inquirer.
3. This card represenets the opposing forces around the inquirer.
4. This card represenets the present happenings/frame of mind.
5. This card represenets the subconcious feelings of the inquirer.
6. This card represenets the past influences on the question.
7. This card represenets the possible immediate future.
8. This card represenets the fears and attitudes of the inquirer.
9. This card represenets the influences and opinions of family and friends.
10. This card represenets the results of actions and thoughts.
11. This card represenets the final outcome at this time.
12. This card represenets extra clarification for card 11.
13. This card represenets extra clarification for card 11.

Recently I've tried implementing the meanings of the cards and have since completely destroyed the program and I had to comment 
out most of the additions I implemented.

**Things that need to be implemented:**
- I would like to shift the program to be object oriented around the cards.
- The card positions need to be implemented.
- Card images need to be added(difficult to find free use tarot cards)
- A position method needs to call the card objects to a predetermined layout similar to the one above.
- The 13 cards need to be randomly generated using the numbers 1-78 while also calling the matching 13 card meaning .txt files to be displayed.
- More ideas to come.
