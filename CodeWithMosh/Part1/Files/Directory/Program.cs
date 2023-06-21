string pwd = @"/Users/lisa/Documents/LearningCSharp/CodeWithMosh/Part1/Files/Directory/";
string testDirectory = @"/Users/lisa/Documents/LearningCSharp/CodeWithMosh";

Directory.CreateDirectory(pwd + "ILikeCheese");

var files = Directory.GetFiles(testDirectory, "*.txt", SearchOption.AllDirectories);
foreach(string file in files)
    Console.WriteLine(file);


Console.WriteLine();

var directories = Directory.GetDirectories(testDirectory, "*.*", SearchOption.AllDirectories);
foreach (string dir in directories)
{
    Console.WriteLine(dir);
}

Console.WriteLine();

bool hasDocFolder = Directory.Exists(@"/Users/lisa/Documents");
Console.WriteLine(hasDocFolder);

var directoryInfo = new DirectoryInfo(pwd);
directoryInfo.GetFiles();
directoryInfo.GetDirectories();



