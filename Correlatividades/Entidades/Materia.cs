using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Materia
    {
        public int indice;
        public int estado;
        public string nombre;
        public List<int> listaCorrelatividades = new List<int>();
        public ECuatrimestre cuatrimestre;

        public Materia(int indice, int estado, string nombre, ECuatrimestre cuatrimestre)
        {
            this.indice = indice;
            this.estado = estado;
            this.nombre = nombre;
            //this.listaCorrelatividades = new List<int>();
            this.cuatrimestre = cuatrimestre;
        }
    }
}
