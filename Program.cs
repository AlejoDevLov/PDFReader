using PDFReader;
using PDFReader.Services.PDFReaders;


//This path contains a set of PDFs with the right format compatible with this program.
var folderPath = "C:\\Users\\alejo\\Programming\\C#\\Resources\\Tickets\\";

try
{
    var pdfPaths = Directory.GetFiles(folderPath, "*.pdf");

    var program = new PDFReaderProgram(new PDFPig());
    program.Start(pdfPaths, folderPath);
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine($"The directory {folderPath} was not found. \n" +
        $"Validate the path of the files and try again.");
}
catch(Exception ex)
{
    Console.WriteLine($"An exception was thrown. Exception message: {ex.Message}." +
        $"\n StackTrace: {ex.StackTrace}");
}

Console.ReadKey();
