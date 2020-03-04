using System;
using System.IO;
using Game.Views;


namespace File.Models
{
  public class MakeFiles
  {
    public static void Start(string projName, string nameSpace)
    {
      //run getDir
      //run MakeOutput
      string dir = GetDirectory();
      MakeOutput(dir, projName, nameSpace);
    }
    public static string GetDirectory()
    {
      string path = Directory.GetCurrentDirectory();
      int homePathIndex = path.IndexOf(".Solutions") + 10;
      string homePath = path.Substring(0, homePathIndex);

      return homePath;
    }

    public static void MakeOutput(string filePath, string projName, string nameSpace)
    {
      string OutputPath = Path.Combine(filePath, projName + ".Solutions");
      Directory.CreateDirectory(OutputPath);
      System.Console.WriteLine($"Writing outPut {OutputPath}");

      string gitignore = Path.Combine(OutputPath, ".gitignore");
      System.IO.File.Create(gitignore);
      System.Console.WriteLine($"Writing gitignore {gitignore}");

      string README = Path.Combine(OutputPath, "README.md");
      System.IO.File.Create(README);
      System.Console.WriteLine($"Writing gitignore {README}");

      //Program
      string programPath = Path.Combine(OutputPath, projName);
      Directory.CreateDirectory(programPath);
      System.Console.WriteLine($"Writing programPath {programPath}");

      string csproj = Path.Combine(programPath, $"{projName}.csproj");
      System.IO.File.Create(csproj);
      System.Console.WriteLine($"Writing csproj {csproj}");

      string programcs = Path.Combine(programPath, $"Program.cs");
      System.IO.File.Create(programcs);
      System.Console.WriteLine($"Writing programcs {programcs}");

      string modelsPath = Path.Combine(programPath, "Models");
      Directory.CreateDirectory(modelsPath);
      System.Console.WriteLine($"Writing modelsPath {modelsPath}");

      string modelcs = Path.Combine(modelsPath, $"{projName}.cs");
      System.IO.File.Create(modelcs);
      System.Console.WriteLine($"Writing modelcs {modelcs}");



      //Test section
      string testPath = Path.Combine(OutputPath, projName + ".Tests");
      Directory.CreateDirectory(testPath);
      string modeltestPath = Path.Combine(testPath, "ModelTests");
      Directory.CreateDirectory(modeltestPath);
      string testcsproj = Path.Combine(testPath, $"{projName}.Tests.csproj");
      System.IO.File.Create(testcsproj);
      string modelTestcs = Path.Combine(modeltestPath, $"{projName}Tests.cs");
      System.IO.File.Create(modelTestcs);

    }
  }

}