using System.Collections.Generic;

namespace RepositorioAdapter.Adapter
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity">Objeto de entidad de la base de datos</typeparam>
    /// <typeparam name="TModel">Objeto de tranferencia, es lo que mando al movil.............</typeparam>
    public interface IAdapter<TEntity,TModel>
    {
        TEntity FromViewModel(TModel model);
        TModel FroModel(TEntity model);

        ICollection<TEntity> FromViewModel(ICollection<TModel> model);
        ICollection<TModel> FroModel(ICollection<TEntity> model);
    }
}