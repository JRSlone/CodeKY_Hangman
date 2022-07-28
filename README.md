# CodeKY_Hangman

This project opens up a game of Hangman to play with predetermined words from a List inside the program.

---Project requirments---
1. You must create at least one class, then create at least one object of that class and populate it with data. You must use or display the data in your application.
* "public static class RandomNumber" that is located in my RandomNumber.cs

2. Create and call at least 3 functions or methods, at least one of which must return a value that is used in your application.
* "public void buttonClick()" Line 116, "public static int CalculateGuesses()" Line 157 and returns a value for total guesses for message box in Line 146 and Line 226, "public void hangmanAppear()" Line 162.

---Feature List---
1. Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program.
* "List<String> wordDictionary = new List<string> { "APPLE", "SNOW", "MARSHMALLOW", "SHARP", "FOX", "DISCORD", "DEVELOPMENT", "OVERFLOW", "AURORA" };" Line 31.

2. Analyze text and display information about it (ex: how many words in a paragraph).
*  "public void setWord()", this method will take the the dictionary words and produce blank spaces in my wordDisplayTB that are later filled in by pressing the correct letter.

3. Visualize data in a graph, chart, or other visual representation of data.
* The UI will display the word after it is guessed incorrectly and also displays a Hangman text image that changes depending on the amount of incorrect guesses given.
