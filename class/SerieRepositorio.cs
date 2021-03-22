using System;
using System.Collections.Generic;
using dio_project_crud_csharp.Interfaces;

namespace dio_project_crud_csharp
{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();
        public void Delete(int id)
        {
            listSerie[id].Remove();
        }

        public void Insert(Serie entity)
        {
            listSerie.Add(entity);
        }

        public List<Serie> List()
        {
            return listSerie;
        }

        public int NextId()
        {
            return listSerie.Count;
        }

        public Serie ReturnById(int id)
        {
            return listSerie[id];
        }

        public void Update(int id, Serie entity)
        {
            listSerie[id] = entity;
        }
    }
}