[CharityWareURL]: https://github.com/GregTrevellick/MiscellaneousArtefacts/wiki/Charity-Ware
[WhyURL]: https://github.com/GregTrevellick/MiscellaneousArtefacts/wiki/Why

# Files For Every Extension Creator

<!--BadgesSTART-->
<!-- Powered by https://github.com/GregTrevellick/ReadMeSynchronizer -->
[![BetterCodeHub compliance](https://bettercodehub.com/edge/badge/GregTrevellick/FilesForEveryExtensionCreator?branch=master)](https://bettercodehub.com/results/GregTrevellick/FilesForEveryExtensionCreator)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/35560f38029b47258343156a1866f349)](https://www.codacy.com/project/gtrevellick/FilesForEveryExtensionCreator/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=GregTrevellick/FilesForEveryExtensionCreator&amp;utm_campaign=Badge_Grade_Dashboard)
[![CodeFactor](https://www.codefactor.io/repository/github/GregTrevellick/FilesForEveryExtensionCreator/badge)](https://www.codefactor.io/repository/github/GregTrevellick/FilesForEveryExtensionCreator)
[![GitHub top language](https://img.shields.io/github/languages/top/GregTrevellick/FilesForEveryExtensionCreator.svg)](https://github.com/GregTrevellick/FilesForEveryExtensionCreator)
[![Github language count](https://img.shields.io/github/languages/count/GregTrevellick/FilesForEveryExtensionCreator.svg)](https://github.com/GregTrevellick/FilesForEveryExtensionCreator)
[![GitHub pull requests](https://img.shields.io/github/issues-pr-raw/GregTrevellick/FilesForEveryExtensionCreator.svg)](https://github.com/GregTrevellick/FilesForEveryExtensionCreator/pulls)
[![Appveyor Build status](https://ci.appveyor.com/api/projects/status/0vwmtcboontemltq?svg=true)](https://ci.appveyor.com/project/GregTrevellick/FilesForEveryExtensionCreator)
[![Appveyor unit tests](https://img.shields.io/appveyor/tests/GregTrevellick/FilesForEveryExtensionCreator.svg)](https://ci.appveyor.com/project/GregTrevellick/FilesForEveryExtensionCreator/build/tests)
[![Access Lint github](https://img.shields.io/badge/a11y-checked-green.svg)](https://www.accesslint.com)
[![ImgBot](https://img.shields.io/badge/images-optimized-green.svg)](https://imgbot.net/)
[![Charity Ware](https://img.shields.io/badge/charity%20ware-thank%20you-brightgreen.svg)](https://github.com/GregTrevellick/MiscellaneousArtefacts/wiki/Charity-Ware)
[![License](https://img.shields.io/github/license/gittools/gitlink.svg)](/LICENSE.txt)
<!--BadgesEND-->




[![Build status](https://ci.appveyor.com/api/projects/status/b1t4vqmcjjoqos9u?svg=true)](https://ci.appveyor.com/project/GregTrevellick/filesforeveryextensioncreator)
[![Build Status](https://travis-ci.org/GregTrevellick/FilesForEveryExtensionCreator.svg?branch=master)](https://travis-ci.org/GregTrevellick/FilesForEveryExtensionCreator)

[CharityWare][CharityWareURL] 

A C# .Net console app that will populate a directory with 70,252 tiny files, each with a unique extension, resulting in files on your file system such as xxx.AAA, xxx.AAB, xxx.AAC through to xxx.ZZZ.

The files created by this app can be found [here](https://github.com/GregTrevellick/FilesForEveryExtension).

![](FilesForEveryExtensionCreator/Resources/ReadMeScreenShot_WindowsExplorer.png)

## Who Is This For
* Anyone who needs a big variety of file types but hasn't the time to create by hand
* Developers who need files of many different types, typically for edge-case testing of code
* Authors of certain types of Visual Studio extensions
* Anyone who wants to see the associated file icon and/or program for every type of file on their system

[Why?][WhyURL]

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

[MIT](/LICENCE.txt)
