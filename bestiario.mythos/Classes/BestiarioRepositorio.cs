using System;
using System.Collections.Generic;
using bestiario.mythos.Interfaces;

namespace bestiario.mythos
{
    public class BestiarioRepositorio : IRepositorio<Bestiario>
    {
        private List<Bestiario> listaBestiario = new List<Bestiario>();
        
        public void Atualiza(int id, Bestiario besta)
        {
            listaBestiario[id] = besta;
        }
        public void Exclui(int id)
        {
            listaBestiario[id].Excluir();
        }
        public void Insere(Bestiario besta)
        {
            listaBestiario.Add(besta);
        }
        public List<Bestiario> Lista()
        {
            return listaBestiario;
        }
        public int ProximoID()
        {
            return listaBestiario.Count;
        }
        public Bestiario RetornaPorId(int id)
        {
            return listaBestiario[id];
        }
    }
}