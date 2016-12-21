# Files For Every Extension Creator

[![](https://img.shields.io/github/license/gittools/gitlink.svg)](https://github.com/GregTrevellick/FilesForEveryExtensionCreator/blob/master/LICENCE)
[![Build status](https://ci.appveyor.com/api/projects/status/b1t4vqmcjjoqos9u?svg=true)](https://ci.appveyor.com/project/GregTrevellick/filesforeveryextensioncreator)
[![Build Status](https://travis-ci.org/GregTrevellick/FilesForEveryExtensionCreator.svg?branch=master)](https://travis-ci.org/GregTrevellick/FilesForEveryExtensionCreator)

A C# .Net console app that will populate a directory with 70,252 tiny files, each with a unique extension, resulting in files on your file system such as xxx.AAA, xxx.AAB, xxx.AAC through to xxx.ZZZ.

The files created by this app can be found [here](https://github.com/GregTrevellick/FilesForEveryExtension).

![File1](winExpl.png)

## Who Is This For
* Anyone who needs a big variety of file types but hasn't the time to create by hand
* Developers who need files of many different types, typically for edge-case testing of code
* Authors of certain types of Visual Studio extensions
* Anyone who wants to see the associated file icon and/or program for every type of file on their system

## Features

This app will create two folders named ***ByLetter*** and ***All35K*** within <code>C:\Temp\FileForEveryExtensionCreator\Files</code>. 

The ***ByLetter*** folder contains 35,126 files, each 11 bytes, broken down into separate folders per letter of the alphabet. Each folder therefore contains 1,351 files. 

The ***All35K*** folder contains the exact same 35,126 files, but in a single folder rather than segregated by initial letter. This folder will therefore be slower to open than the ***ByLetter*** folder, but saves you copying all 26 x 1351 files into a single folder if that is what you desire.

The app has special case handling for the content of the following file types, in order to ensure their content is legal for MSBuild (e.g. within Visual Studio IDE):

* .EDMX
* .LICX
* .RESX

## Credits

The following [repo](https://github.com/jwbats/EdmxStuff) was particularly helpful whilst creating this app.

## License

[MIT](/LICENSE.txt)
