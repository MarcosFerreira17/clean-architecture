namespace Template.Application.Services.Interfaces;

public interface IBaseService<T, Tid>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(Tid id);
    Task Create(T entity);
    Task Update(Tid id, T entity);
    Task Delete(Tid id);
}
