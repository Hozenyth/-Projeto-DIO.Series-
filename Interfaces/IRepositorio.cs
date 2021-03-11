using System.Collections.Generic;

namespace DIO.Series.Interfaces

{
    public interface IRepositorio<T>
    {
        List<T> Lista(); // Metodo que se chama lista, retorna lista de T.
        T RetornaPorId(int  id);
        
        void Insere(T  entidade);

        void Exclui( int id);

        void Atualizar(int id, T entidade);

        int ProximoId();
    }
}