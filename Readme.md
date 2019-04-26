# _Word Counter_

#### _Counts number of times a word repeats in a sentence_

#### By _**Jared Farkas**_

## Description

_This checks how many times a given word is repeated in a phrase. It also checks for partial matches eg("cat" is found in "cathedral")_

## Setup/Installation Requirements

* _Clone from https://github.com/j-farkas/wordcounter.git_
* _Include the class in a c# project_

## Specs

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| A single letter is compared to a single letter | "a", "a"  | 1 |
| A single letter is compared to a word | "a" "bat" | 1 |
| A word is compared to a sentence | "hat" "I don't wear a hat every day" | 1 |
| A word is compared to a sentence that has words that contain the given word | "how", "I don't know how to do that, however, I have some ideas on how to proceed" | 3 |
| A word is compared to a phrase that contains the word, but there are spaces or punctuation in between | "hot",  "Both other people think we should go" | 1 |

## Known Bugs

_None as of last update_

## Support and contact details

_Contact jaredmfarkas@gmail.com for support._

## Technologies Used

_C#_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2019 **_Jared Farkas_**
