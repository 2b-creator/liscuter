ffmpeg -i source.mp3 source2.mp3
ffmpeg -i source2.mp3  -vn -acodec copy -ss 1:12 -to 2:20 12.mp3
