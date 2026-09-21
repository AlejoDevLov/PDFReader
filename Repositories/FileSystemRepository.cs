
namespace PDFReader.Repositories;

internal class FileSystemRepository(string path, string fileName) : RepositoryBase(path)
{
    public string FullPathName { get; } = System.IO.Path.Combine(path, fileName);

    public override void Save(string data)
    {
        File.WriteAllText(FullPathName, data);  
    }
}
