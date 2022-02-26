@echo off
ffmpeg -i F:\Csharp\liscuter\bin\Debug\source.mp3 temp.mp3
ffmpeg -i temp.mp3  -vn -acodec copy -ss 1:10 -to 1:50 123.mp3
Finish.vbs
