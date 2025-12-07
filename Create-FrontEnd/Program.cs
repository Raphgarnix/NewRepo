using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Neuen Folder mit (html/Javascript/css)-Datei erstellen?");
Console.WriteLine("(j)a");
Console.WriteLine("(n)ein");
var eingabe = Console.ReadLine();
if(eingabe == "j"){


    Console.WriteLine("Welche Name soll der Ordner haben?");
    var ordnerName = Console.ReadLine();
    
    // Ordner erstellen
    Directory.CreateDirectory(ordnerName);
    // HTML Datei erstellen
    File.WriteAllText(Path.Combine(ordnerName, "index.html"), "<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <link rel=\"stylesheet\" href=\"styles.css\">\n    <title>Document</title>\n</head>\n<body>\n    <script src=\"script.js\"></script>\n</body>\n</html>");
    // Javascript Datei erstellen
    File.WriteAllText(Path.Combine(ordnerName, "script.js"), "");
    // CSS Datei erstellen
    File.WriteAllText(Path.Combine(ordnerName, "styles.css"), "");

    //search for the created folder
    var fullPath = Path.GetFullPath(ordnerName);
    Console.WriteLine("Ordner und Dateien wurden erstellt unter: " + fullPath);

    Thread.Sleep(1000);

    System.Diagnostics.Process.Start("explorer.exe", fullPath);
    
    var visualStudioCodePath = @"C:\Microsoft VS Code\Code.exe";
    System.Diagnostics.Process.Start(visualStudioCodePath, fullPath);

    Environment.Exit(0);
}
else if (eingabe == "n"){

    Environment.Exit(0);

}
