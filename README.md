# Project: BaiTapThucHanh - Môn học: Lập trình trong môi trường Windows
## Author
> **Name: Vi Anh Tuan**<br>
> **Student Id: K185480106029**<br>
> **Class: K54KMT.01**<br>
> **Major: Computer Engineering**<br>
> **Lecturer: ThS.Do Duy Cop**<br>
> **Email: <k185480106029@tnut.edu.vn>**

## Install libraries for python
- ```pip install playsound==1.2.2```
> this project doesn't work at latest library ersion
- ```pip install gTTS```
- ```pip install translate```
## Download and install the JDK for java
- [oracle.com](https://www.oracle.com/java/technologies/downloads/)
## Setup project for running
```csharp
string scriptPath = @"direct to \data folder";
string fileName = @"direct to java.exe and python.exe file" // example: "C:\Program Files\Java\jdk-20\bin\java.exe"
```
## Project structure
* 📂 BaiTapThucHanh
  * 📁 Properties
  *  📂 data
      *  📁 Sound               → `sounds was created are save here`
      *  📄 [script.java](https://github.com/viants/BaiTapThucHanh_CSharp/blob/master/BaiTapThucHanh/data/script.java)         → `java file for summing two values from agruments`
      *  📄 [script.py](https://github.com/viants/BaiTapThucHanh_CSharp/blob/master/BaiTapThucHanh/data/script.py)           → `python file for creating message voice files`
      *  📄 [translateModule.py](https://github.com/viants/BaiTapThucHanh_CSharp/blob/master/BaiTapThucHanh/data/translateModule.py)  → `python file using google translate API for translating messages`
* 📄 App.config
* 📄 BaiTapThucHanh.csproj
* 📄 Form1.Designer.cs
* 📄 Form1.cs
* 📄 Form1.resx
* 📄 Program.cs
* 🖼️ [Screenshot.png](https://github.com/viants/BaiTapThucHanh_CSharp/blob/master/BaiTapThucHanh/Screenshot.png)
