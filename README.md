# Arduino File to Hex
[![License](https://img.shields.io/badge/LICENSE-The%20Unlicense-green?style=flat-square&logo=Arduino)](/LICENSE)  [![Version](https://img.shields.io/badge/VERSION-RELEASE%20--%201.0-green?style=flat-square)](https://github.com/averov90/Arduino_File2Hex/releases/tag/1.0)
### :small_orange_diamond: [English version](https://github.com/averov90/Arduino_File2Hex/blob/master/README-eng.md)
#### Представляет двоичный файл в виде набора байтов в формате массива C.
Пример результата работы:

    #include <avr/pgmspace.h>
    
    const char* binSomeFilename PROGMEM = {0x3C,0x3F,0x78,0x6D,0x6C,0x20};
### Использование

1. Поместите двоичные файлы, которые надо представить массивом байт, в папку с программой Arduino File2Hex;
2. Запустите программу, после чего она сразу начнёт преобразование, а по окончанию выведет в консоль "Complete!";
3. Добавьте файл result.ino в ваш проект. В этом файле находятся представления всех файлов, которые были в папке с программой в момент запуска за исключением файлов с расширениями ".exe" и ".ino" (файлы с данными расширениями игнорируются программой).
