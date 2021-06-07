using System.Collections.Generic;

namespace bestiario.mythos.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T besta);
        void Exclui(int id);
        void Atualiza(int id, T besta);
        int ProximoID();
    }
}