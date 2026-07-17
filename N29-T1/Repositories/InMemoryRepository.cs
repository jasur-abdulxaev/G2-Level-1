using N29_T1.Interfaces;

namespace N29_T1.Repositories;

public class InMemoryRepository<T> : IRepository<T>
{
    private readonly List<T> _data = new();

    public void Add(T entity)
    {
        _data.Add(entity);
    }

    public T? Find(Func<T, bool> predicate)
    {
        return _data.FirstOrDefault(predicate);
    }

    public IEnumerable<T> GetAll()
    {
        return _data;
    }
}
