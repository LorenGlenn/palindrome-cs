# Palindrome Checker

#### By **Erik Killops, Loren Glenn**

## Description

Enter a sentence to check if it is a palindrome!

#### Specs

| Expected Behavior                                                      | Input                              | Output |
|------------------------------------------------------------------------|------------------------------------|--------|
| Check a one word lowercase palindrome                                  | "bob"                              | true   |
| Check a one word lowercase non-palindrome                              | "dog"                              | false  |
| Check a multi word lowercase palindrome with uniform spaces            | "hello olleh"                      | true   |
| Check a multi word lowercase palindrome with non-uniform spaces        | "a man a plan a canal panama"      | true   |
| Check a multi word case insensitive palindrome with non-uniform spaces | "Sore wAs I ere I saW Eros"        | true   |
| Remove punctuation and check for palindrome                            | "I, man, am regal; a German am I." | true   |

## Setup/Installation Requirements

Requires Windows and .Net

Clone repository, run ">dnx kestrel" in Powershell and visit "localhost:5004".

## Known Bugs

None.


## Technologies Used

HTML, C#, Nancy, Razor, Xunit.
