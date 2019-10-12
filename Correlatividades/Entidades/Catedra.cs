using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Catedra 
    {
        Materia[] listaMaterias;
        
        public Catedra()
        {
            int i = 0;
            this.listaMaterias = new Materia[21];
            Materia auxMateria;
            foreach(EMateria materia in Enum.GetValues(typeof(EMateria)))
            {
                auxMateria = new Materia(i, 0, materia.ToString());
                this.listaMaterias[i] = auxMateria;
                i++;
            }
        }

        public int this[int index]
        {
            set
            {
                this.listaMaterias[index].estado = value;
            }
        }

        public void Mostrar()
        {
            foreach (Materia item in this.listaMaterias)
            {
                Console.WriteLine(item.indice + " " + item.estado + " " +item.nombre);
            }
        }

        public void inicializarCorrelativades()
        {
            this.listaMaterias[(int)EMateria.Programacion2].listaCorrelatividades.Add((int)EMateria.Programacion1);
            this.listaMaterias[(int)EMateria.Programacion2].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion1);

            this.listaMaterias[(int)EMateria.ArquitecturaYSistemasOperativos].listaCorrelatividades.Add((int)EMateria.SistemasDeProcesamientoDeDatos);

            this.listaMaterias[(int)EMateria.Estadistica].listaCorrelatividades.Add((int)EMateria.Matematica);

            this.listaMaterias[(int)EMateria.Ingles2].listaCorrelatividades.Add((int)EMateria.Ingles1);

            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion2].listaCorrelatividades.Add((int)EMateria.Programacion1);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion2].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion1);
        }

        public void printCursadadaPosible()
        {
            int exit = 0;
            bool imprimir = true;
            foreach(Materia item in this.listaMaterias)
            {
                if (item.estado == 0)
                {
                    foreach (int indice in item.listaCorrelatividades)
                    {
                        if (this.listaMaterias[indice].estado == 0)
                        {
                            imprimir = false;
                        }
                    }
                    if (imprimir == true)
                    {
                        Console.WriteLine(item.nombre);
                    }
                    else
                    {
                        imprimir = true;
                    }
                }
                if (exit == 10)
                        break;
                exit++;
            }
        }
    }
}
