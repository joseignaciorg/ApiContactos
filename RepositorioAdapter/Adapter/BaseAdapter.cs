using System.Collections.Generic;
using System.Linq;

namespace RepositorioAdapter.Adapter
{
    public abstract class BaseAdapter<TEntity,TModel>:IAdapter<TEntity,TModel>
    {
        public abstract TEntity FromViewModel(TModel model);

        public abstract TModel FromModel(TEntity model);
        
        public ICollection<TEntity> FromViewModel(ICollection<TModel> model)
        {
            return model.Select(FromViewModel).ToList();
        }

        public ICollection<TModel> FromModel(ICollection<TEntity> model)
        {
            //Se podria hacer tb de esta forma
            //var retorno=new List<TModel>();
            //foreach (var entity in model)
            //{
            // retorno.Add(FroModel(entity));
            //}
            //return retorno;

            return model.Select(FromModel).ToList();
        }
    }
}