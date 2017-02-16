# Scrabble Score Determiner

#### _An application to determine the scrabble score for a word._

#### By _**Alexandra Holcombe && Jiwon Kang**_

## Description

This website takes a word and returns the Scrabble score for that word.  

> A, E, I, O, U, L, N, R, S, T --> 1  
> D, G --> 2  
> B, C, M, P --> 3  
> F, H, V, W, Y --> 4  
> K --> 5  
> J, X --> 8  
> Q, Z --> 10  

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The user enters non-alphabetic characters and the program returns a value of 0.**
* Example Input: "42"
* Example Output: 0

**The user enters a one-letter word and the program determines the value for that word.**
* Example Input: "A"
* Example Output: 1

**The user enters a two-letter word with letter values of 2 and 1, and the program returns a value of 3.**
* Example Input: "do"
* Example Output: 3

**The user enters a three-letter word with values of 3, 2, and 1 and the program returns a value of 6.**
* Example Input: "bad"
* Example Output: 6

**The user enters a four-letter word with values of 4, 3, 2, and 1 and the program returns a value of 10.**
* Example Input: "body"
* Example Output: 10

**The user enters a five-letter word with values of 5, 4, 3, 2, and 1 and the program returns a value of 15.**
* Example Input: "abdfk"
* Example Output: 15

**The user enters a six-letter word with values of 8, 5, 4, 3, 2, and 1 and the program returns a value of 23.**
* Example Input: "adbfkj"
* Example Output: 23

**The user enters a seven-letter word with values of 10, 8, 5, 4, 3, 2, and 1 and the program returns a value of 33.**
* Example Input: "adbfkjq"
* Example Output: 33

**The user enters a capitalized word and the program returns a value.**
* Example Input: "Jiwon"
* Example Output: 15

## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Jiwon Kang jiwonk42@gmail.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe & Jiwon Kang_**
