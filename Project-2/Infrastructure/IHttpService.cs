namespace Project_2.Infrastructure;

public interface IHttpService<T>
    where T : class
{
    Task<T> Get(int id);
    Task<T> Get();
    Task<List<T>> GetAll();
    // Task Delete(int id); //TODO needed or not?
    // Task Update(int id);
}
