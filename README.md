# Files For Every Extension Creator

A C# .Net console app that will populate a directory with 70,252 tiny files, each with a unique extension, resulting in files on your file system such as xxx.AAA, xxx.AAB, xxx.AAC through to xxx.ZZZ.

![File1](winExpl.png)

## Who Is This For
* Anyone who needs a big variety of file types but hasn't the time to create by hand.
* Developers who need files of many different types, typically for edge-case testing of code.
* May be of benefit to authors of certain types of Visual Studio extensions.
* Anyone who wants to see the associated file icon and/or program for every type of file on their system.

## Features

This app will create two folders named 'ByLetter' and 'All35K' within 'C:\Temp\FileForEveryExtensionCreator\Files'. 

'ByLetter' contains 35,126 files, each 11 bytes, broken down into separate folders per letter of the alphabet. Each folder therefore contains 1,351 files. 

'All35K' contains the exact same 35,126 files, but in a single folder rather than segregated by initial letter. This may mean that opening this folder on some systems may be relatively slow.

Special case handling for the content of the following file types (ensure content is valid for a Visual studio build):
* .EDMX
* .LICX
* .RESX

## Credits

Thanks to [jwbats](https://github.com/jwbats/EdmxStuff)

## License

All software included is bundled with own license

The MIT License (MIT)

Copyright (c) 2016 Greg Trevellick

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

 
  