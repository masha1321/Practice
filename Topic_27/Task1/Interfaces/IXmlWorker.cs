using Task1.Models;

namespace Task1.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Sweet sweet);
        void Delete(string type);
        Sweet FindBy(string type);
        List<Sweet> GetAll();
    }
}
