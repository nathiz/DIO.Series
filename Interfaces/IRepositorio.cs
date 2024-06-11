using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Series.Interfaces
{
    //utilizada para abstrair o acesso aos dados de uma maneira genérica,
    //permitindo que diferentes tipos de entidades possam ser tratados
    public interface IRepositorio<T>
    {
        //Metodos
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}