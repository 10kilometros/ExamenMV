using System.Threading.Tasks;

namespace Examen.Caso3.Domain
{
    public interface IUnitOfWork
    {
        int Commit();
        Task<int> CommitAsync();
    }
}
