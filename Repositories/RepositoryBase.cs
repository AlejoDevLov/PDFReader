
namespace PDFReader.Repositories;

internal abstract class RepositoryBase(string path)
{
    protected readonly string Path = path;
    public abstract void Save(string data);
}
