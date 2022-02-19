# Liscuter使用手册

## 文本追加

目前功能有bug，预计在1.0正式版本修复。

## 你是一个英语老师

上课是否有过划听力进度条不小心“手残”划多了，有时无法精确定位，如果如此，There you go，liscuter将给出一个解决方案来为你的英语课提供支持。

### 原理

Liscuter的工作原理是通过裁切音频一个时间戳到另一个时间戳为区间生成的音频文件，你可以指定题号让你的讲解更加清晰。

## How to use it

双击运行liscuter.exe即可.

首先，如果你无法运行liscuter，请在电脑上安装微软的运行库，（不过我保证绝大部分电脑都有）为.NET Framework，运行后，你会发现这是一个控制台程序。

![image](https://user-images.githubusercontent.com/81023606/154804993-89d8fc6b-f848-4028-bd8f-85a262b4e568.png)

第一次打开需要确认追加，我们可以使用追加功能，如果不追加的话，也是可以的，区别在于如果要讲解的题目少，你可以输入 ”n” 回车，反之亦然。

我这里以y为例。

![image](https://user-images.githubusercontent.com/81023606/154805011-8499c790-da51-4aef-8b65-1cc544768944.png)

这里的话直接运行即可，无需管他是否需要设置：），选3后回车，注意，运行之后会删除历史的run记录，请谨慎操作！

请将您的音频文件放入根目录内，然后请将其重命名为"source.mp3"，像这样

![image](https://user-images.githubusercontent.com/81023606/154805051-d6db272f-99d2-4c56-b520-9df596e38e2f.png)

注意，如果你没有文件后缀名，请在这里打开！否则程序无效！

![image](https://user-images.githubusercontent.com/81023606/154805060-e07bba2e-9a1f-4c10-bc86-e2885aea6fc5.png)

点击“是”

![image](https://user-images.githubusercontent.com/81023606/154805065-60f26754-c734-4aba-867e-fb3ad8d57704.png)

完成之后可以继续操作，老师可以将听力题目起始时间戳和终止时间戳记在纸上方便后续输出。

![image](https://user-images.githubusercontent.com/81023606/154805079-8874c4dd-8e42-41d5-a54e-b3c1a0c03436.png)

图示为从1分12秒到2分20秒为第12题，回车即可。

![image](https://user-images.githubusercontent.com/81023606/154805090-ec708101-a99e-4495-8bfc-71cea709a722.png)

老师可以继续选题，输入y继续，输入n直接结束程序，这里我就直接n退出程序。

此时，根目录会出现一个run.bat的文件：

![image](https://user-images.githubusercontent.com/81023606/154805097-9cbf61dc-4950-40c9-961f-9a689fff5ef8.png)

我们双击运行它，会出现一个黑漆漆的窗口

![image](https://user-images.githubusercontent.com/81023606/154805104-167ea654-0993-4664-a328-ee2bfa04256c.png)

等它消失，你就成功了，你会发现根目录内多了一个12.MP3文件

![image](https://user-images.githubusercontent.com/81023606/154805113-e2fc4fc8-c23b-415b-bfb5-e456a971e979.png)

这样你就能带着裁剪好的音频上课啦。是不是很实（无）用呢？

## 我无法使用……

在问题发生之前，首先看看自己有没有和教程做过一遍，如果如此，那请看下面的解决方案：

* 可能是你没有微软的框架，可以通过这里下载 https://dotnet.microsoft.com/zh-cn/download/dotnet-framework
* 可能你没有显示文件扩展名，可以通过这里打开
![image](https://user-images.githubusercontent.com/81023606/154805195-3b689135-16c1-413a-a42a-aa6167383246.png)

* 可能你不会用电脑……
## 参与开发
如果想要在GitHub上做贡献，请pull request

我的GitHub主页: https://github.com/2b-creator

编写软件为C#，保留所有权利

## 许可协议
![image](https://user-images.githubusercontent.com/81023606/154805281-a00ce0e2-ad7b-4abc-adef-6aa57ec9af34.png)

Copyright © 2021-2022, Timothy Starman.

This program is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License along with this program. If not, see <https://www.gnu.org/licenses/>.

该程序是免费软件：您可以根据自由软件基金会发布的 GNU 宽通用公共许可证的条款重新分发和/或修改它，许可证的第 3 版或（由您选择）任何更高版本。

分发此程序的目的是希望它有用，但不提供任何保证； 甚至没有对适销性或特定用途适用性的默示保证。 有关更多详细信息，请参阅 GNU 通用公共许可证。

您应该已经收到了一份 GNU 宽通用公共许可证的副本以及这个程序。 如果没有，请参阅 <https://www.gnu.org/licenses/>。
