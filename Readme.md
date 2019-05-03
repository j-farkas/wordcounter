# _Word Counter_

#### _Counts number of times a word repeats in a given phrase_

#### By _**Jared Farkas**_

## Description

_This checks how many times a given word is repeated in a phrase. It also checks for partial matches eg("cat" is found in "cathedral"). Punctuation and spacing is ignored in the phrase, and not accepted in the input_

## Setup/Installation Requirements

* _Clone from https://github.com/j-farkas/wordcounter.git_
* _Use dotnet run and load it from localhost_

## Specs

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| A single letter is compared to a single letter | "a", "a"  | 1 |
| A single letter is compared to a word | "a", "bat" | 1 |
| A word is compared to a sentence | "hat", "I even don't wear a hat every day" | 1 |
| A word is compared to a sentence that has words that contain the given word | "how", "I don't know how to do that, however, I have some ideas on how to proceed" | 3 |
| A word is compared to a phrase that contains the word, but there are spaces or punctuation in between | "hot",  "Both other people think we should go" | 1 |
| A phrase containing punctuation is entered | "hot/",  "Both other people think we should go" | 0(input is ignored) |

## Known Bugs

_None as of last update_

## Support and contact details

_Contact jaredmfarkas@gmail.com for support._

## Technologies Used

_C#, .Net, Razor_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2019 **_Jared Farkas_**
