string pwd = @"/Users/lisa/Documents/LearningCSharp/CodeWithMosh/Part1/Files/File/";

File.Copy(pwd + "Text.txt", pwd + "Text2.txt", true);
File.Copy(pwd + "Text2.txt", pwd + "Text3.txt", true);
File.Delete(pwd + "Text2.txt");

if (File.Exists(pwd + "Text3.txt")) {
    Console.WriteLine("File copied successfully!");
}

string content = File.ReadAllText(pwd + "Text3.txt");
Console.WriteLine(content);

var fileInfo = new FileInfo(pwd + "Text.txt");
fileInfo.CopyTo(pwd + "file_info.txt");