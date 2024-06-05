# OldPhonePad

## Overview

This repository contains the implementation of the `OldPhonePad` method in C#. The method translates input sequences from an old phone keypad into their corresponding text messages. The implementation handles special characters such as backspace (`*`) and send (`#`) buttons, as well as multi-press input for letter selection.

## Challenge Description

Here is an old phone keypad with alphabetical letters, a backspace key, and a send button. Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter. For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’. You must pause for a second in order to type two characters from the same button after each other: “222 2 22” -> “CAB”.

Keypad Layout:

### Examples

- `OldPhonePad("33#")` => Output: `E`
- `OldPhonePad("227*#")` => Output: `B`
- `OldPhonePad("4433555 555666#")` => Output: `HELLO`
- `OldPhonePad("8 88777444666*664#")` => Output: `???`

## Implementation

The implementation involves parsing the input string to identify sequences of key presses and converting them into corresponding characters. Special handling is required for backspace (`*`) and send (`#`) buttons.

### Files

- `Program.cs`: Contains the `Main` method for testing the `OldPhonePad` function.
- `OldPhonePad.cs`: Contains the implementation of the `OldPhonePad` method and helper functions.

### Code Explanation

#### Main Method
The `Main` method contains test cases to demonstrate the functionality of the `OldPhonePad` method.
```csharp
static void Main(string[] args)
{
    Console.WriteLine(OldPhonePad("33#")); // E
    Console.WriteLine(OldPhonePad("227*#")); // B
    Console.WriteLine(OldPhonePad("4433555 555666#")); // HELLO
    Console.WriteLine(OldPhonePad("8 88777444666*664#"));
}


OldPhonePad Method
The OldPhonePad method processes the input string and returns the corresponding text message.

csharp
Copy code
public static String OldPhonePad(string input)
{
    List<char> charList = new List<char>();
    string output = "";
    string[] substrings = input.Split(' ');

    foreach (string substring in substrings)
    {
        string[] sublist = divide(substring);
        foreach (string miniSubstring in sublist)
        {
            char tempChar = converter(miniSubstring);
            if (tempChar == '*' && charList.Count > 0)
            {
                charList.RemoveAt(charList.Count - 1);
            }
            else if (tempChar != '#')
            {
                charList.Add(converter(miniSubstring));
            }
        }
    }

    foreach (char outChar in charList)
    {
        output += outChar;
    }

    return output;
}

Running the Code
Clone the repository.
Open the project in your preferred IDE (e.g., Visual Studio).
Run the Program.cs file to see the output for the provided test cases.
Conclusion
This implementatio
n correctly translates input sequences from an old phone keypad into text messages, considering backspace and send functionalities. The code is modular, with helper methods to divide input sequences and convert them into characters.
