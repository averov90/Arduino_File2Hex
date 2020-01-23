# Arduino File to Hex
[![License](https://img.shields.io/badge/LICENSE-The%20Unlicense-green?style=flat-square&logo=Arduino)](/LICENSE)  [![Version](https://img.shields.io/badge/VERSION-RELEASE%20--%201.0-green?style=flat-square)](https://github.com/averov90/Arduino_File2Hex/releases/tag/1.0)
### :small_orange_diamond: [Русская версия](https://github.com/averov90/Arduino_File2Hex/blob/master/README.md)
#### Represents a binary file as a set of bytes in the C array format.
Example of the work result:

    #include <avr/pgmspace.h>
    
    const char* binSomeFilename PROGMEM = {0x3C,0x3F,0x78,0x6D,0x6C,0x20};
### Using

1. Place the binary files that you want to represent as an array of bytes in the folder with the Arduino File2Hex program;
2. Run the program, after which it will immediately start converting, and at the end will display in the console "Complete!";
3. Add a file result.info in your project. This file contains views of all files that were in the program folder at the time of launch, with the exception of files with extensions ".exe" and ".ino" (files with these extensions are ignored by the program).