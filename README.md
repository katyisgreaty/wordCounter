# Word Counter

#### _Count how many times a word appears_

#### By _**Katy Daviscourt**_

## Description

This web application will take an inputted word from the user and check how many times that word appears in a phrase also inputted by the user.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The program will return the inputted phrase and word.**
* Example Input: "this is a phrase", "pickle"
* Example Output: "this is a phrase", "pickle"
* Reasoning: At this stage it doesn't matter what's in the inputs, and it doesn't matter if they match or not.

**The program will return true if it finds the word inside the phrase.**
* Example Input: "I like rowing", "rowing"
* Example Output: true
* Reasoning: I want to test if it can recognize a word match in a simple, short sentence. One match is enough to test this spec. Also, I don't care yet about counting the number of matches, just that the program can recognize if there have been any matches.

**The program will return true if it finds the word inside the phrase, regardless of punctuation and case.**
* Example Input: "I !like r-owing.", "rowing"
* Example Output: true
* Reasoning: I want to test if it can recognize a word match in a simple, short sentence, regardless of punctuation and if letters are upper or lower case. One match is enough to test this spec. Also, I don't care yet about counting the number of matches, just that the program can recognize if there have been any matches.

**The program will count the number of times it finds the word inside the phrase.**
* Example Input: "Every dog is cute but my favorite kind of dog is a happy dog", "dog"
* Example Output: 3
* Reasoning: I want to test if the program can count how many times the inputted word shows up, so I wrote an example sentence that contains the word several times, instead of just once.

## Ice Box
* Add option to search/count for multiple words at once

## Support and contact details

Please contact Katy Daviscourt at katy.daviscourt@gmail.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Katy Daviscourt_**
