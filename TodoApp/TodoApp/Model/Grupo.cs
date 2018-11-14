using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Model
{
    public class Grupo
    {
        public int IdGrupo { get; set; }
        public string Nombre { get; set; }
        public int Parent { get; set; }
        public List<Grupo> childs { get; set; }

        public List<Grupo> retrive()
        {
            Grupo Grupo2 = new Grupo()
            {
                IdGrupo = 2,
                Nombre = "Segundo",
                Parent = 1,
                childs = null
            };

            Grupo Grupo6 = new Grupo() {
                IdGrupo = 6,
                Nombre = "Sexto",
                Parent = 3,
                childs = null
            };

            Grupo Grupo3 = new Grupo()
            {
                IdGrupo = 3,
                Nombre = "tercero",
                Parent = 1,
                childs = new List<Grupo> {
                    Grupo6
                }
            };

            Grupo Grupo1 = new Grupo()
            {
                IdGrupo = 1,
                Nombre = "Primero",
                Parent = -1,
                childs = new List<Grupo> {
                    Grupo2, Grupo3
                }
            };

            Grupo Grupo4 = new Grupo()
            {
                IdGrupo = 4,
                Nombre = "Cuarto",
                Parent = 5,
                childs = null
            };

            Grupo Grupo5 = new Grupo()
            {
                IdGrupo = 5,
                Nombre = "Quinto",
                Parent = -1,
                childs = new List<Grupo> {
                    Grupo4
                }
            };

            return new List<Grupo>() {
                Grupo1,
                Grupo2,
                Grupo3,
                Grupo4,
                Grupo5,
                Grupo6
            };
        }
    }
}
