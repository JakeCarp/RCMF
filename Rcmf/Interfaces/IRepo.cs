namespace Rcmf.Interfaces;


public interface IRepo<T, Tid>
{
  List<T> Get();

  T GetById(Tid id);

  T Create(T data);

  T Update(T data);

  void Delete(Tid id);

}
