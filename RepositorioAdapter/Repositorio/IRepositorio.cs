using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositorioAdapter.Repositorio
{
    public interface IRepositorio<TEntity, TModel,TAdapter>
    {
        TModel Add(TModel model);//me das un modelo y lo añado
        int Delete(params object[] keys);
        int Delete(TModel model);//me pasas un modelo y lo borro
        int Delete(Expression<Func<TModel, bool>> consulta);//me das una expresion la busco y todos los que devuelva que exiten borrados
        int Update(TModel model);//me das un modelo y lo actualizo
        TModel Get(params object[] keys);//
        ICollection<TModel> Get(Expression<Func<TModel, bool>> consulta);//
        ICollection<TModel> Get();//


    }
}