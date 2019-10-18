using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Catedra
    {
        public Materia[] listaMaterias;

        public Catedra()
        {
            int i = 0;
            int cuatrimestre = 1;
            this.listaMaterias = new Materia[21];
            foreach (EMateria materia in Enum.GetValues(typeof(EMateria)))
            {
                this.listaMaterias[i] = new Materia(i, 0, materia.ToString(), (ECuatrimestre)cuatrimestre);

                if (i == 4)
                    cuatrimestre = 2;

                if (i == 10)
                    cuatrimestre = 3;

                if (i == 15)
                    cuatrimestre = 4;
                i++;
            }
            this.inicializarCorrelativades();
        }

        public int this[int index]
        {
            set
            {
                this.listaMaterias[index].estado = value;
            }
        }

        public Materia[] ListaMaterias
        {
            get
            {
                return this.listaMaterias;
            }

        }

        public void inicializarCorrelativades()
        {
            //SEGUNDO CUATRIMETRE
            this.listaMaterias[(int)EMateria.Programacion2].listaCorrelatividades.Add((int)EMateria.Programacion1);
            this.listaMaterias[(int)EMateria.Programacion2].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion1);

            this.listaMaterias[(int)EMateria.ArquitecturaYSistemasOperativos].listaCorrelatividades.Add((int)EMateria.SistemasDeProcesamientoDeDatos);

            this.listaMaterias[(int)EMateria.Estadistica].listaCorrelatividades.Add((int)EMateria.Matematica);

            this.listaMaterias[(int)EMateria.Ingles2].listaCorrelatividades.Add((int)EMateria.Ingles1);

            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion2].listaCorrelatividades.Add((int)EMateria.Programacion1);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion2].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion1);


            //TERCER CUATRIMESTRE
            this.listaMaterias[(int)EMateria.Programacion3].listaCorrelatividades.Add((int)EMateria.Programacion1);
            this.listaMaterias[(int)EMateria.Programacion3].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion1);
            this.listaMaterias[(int)EMateria.Programacion3].listaCorrelatividades.Add((int)EMateria.Programacion2);
            this.listaMaterias[(int)EMateria.Programacion3].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion2);

            this.listaMaterias[(int)EMateria.OrganizacionContableDeLaEmpresa].listaCorrelatividades.Add((int)EMateria.Matematica);

            this.listaMaterias[(int)EMateria.OrganizacionEmpresarial].listaCorrelatividades.Add((int)EMateria.Matematica);
            this.listaMaterias[(int)EMateria.OrganizacionEmpresarial].listaCorrelatividades.Add((int)EMateria.Estadistica);

            this.listaMaterias[(int)EMateria.ElementosDeInvestigacionOperativa].listaCorrelatividades.Add((int)EMateria.Matematica);
            this.listaMaterias[(int)EMateria.ElementosDeInvestigacionOperativa].listaCorrelatividades.Add((int)EMateria.Estadistica);

            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion3].listaCorrelatividades.Add((int)EMateria.Programacion1);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion3].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion1);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion3].listaCorrelatividades.Add((int)EMateria.Programacion2);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion3].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion2);

            
            //CUARTO CUATRIMESTRE
            this.listaMaterias[(int)EMateria.MetodologiaDeSistemas].listaCorrelatividades.Add((int)EMateria.MetodologiaDeLaInvestigacion);
            this.listaMaterias[(int)EMateria.MetodologiaDeSistemas].listaCorrelatividades.Add((int)EMateria.Matematica);
            this.listaMaterias[(int)EMateria.MetodologiaDeSistemas].listaCorrelatividades.Add((int)EMateria.OrganizacionContableDeLaEmpresa);
            this.listaMaterias[(int)EMateria.MetodologiaDeSistemas].listaCorrelatividades.Add((int)EMateria.Programacion1);
            this.listaMaterias[(int)EMateria.MetodologiaDeSistemas].listaCorrelatividades.Add((int)EMateria.Programacion2);
            this.listaMaterias[(int)EMateria.MetodologiaDeSistemas].listaCorrelatividades.Add((int)EMateria.Programacion3);
            this.listaMaterias[(int)EMateria.MetodologiaDeSistemas].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion1);
            this.listaMaterias[(int)EMateria.MetodologiaDeSistemas].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion2);
            this.listaMaterias[(int)EMateria.MetodologiaDeSistemas].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion3);

            this.listaMaterias[(int)EMateria.DiseñoYAdministracionDeBasesDeDatos].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion1);
            this.listaMaterias[(int)EMateria.DiseñoYAdministracionDeBasesDeDatos].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion2);
            this.listaMaterias[(int)EMateria.DiseñoYAdministracionDeBasesDeDatos].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion3);
            this.listaMaterias[(int)EMateria.DiseñoYAdministracionDeBasesDeDatos].listaCorrelatividades.Add((int)EMateria.Programacion1);
            this.listaMaterias[(int)EMateria.DiseñoYAdministracionDeBasesDeDatos].listaCorrelatividades.Add((int)EMateria.Programacion2);
            this.listaMaterias[(int)EMateria.DiseñoYAdministracionDeBasesDeDatos].listaCorrelatividades.Add((int)EMateria.Programacion3);

            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion4].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion1);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion4].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion2);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion4].listaCorrelatividades.Add((int)EMateria.LaboratorioDeComputacion3);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion4].listaCorrelatividades.Add((int)EMateria.Programacion1);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion4].listaCorrelatividades.Add((int)EMateria.Programacion2);
            this.listaMaterias[(int)EMateria.LaboratorioDeComputacion4].listaCorrelatividades.Add((int)EMateria.Programacion3);
        }

        public bool puedeCursarse(Materia materia)
        {
            bool retorno = true;
            if (materia.estado == 0)
            {
                foreach (int indice in materia.listaCorrelatividades)
                {
                    if (this.listaMaterias[indice].estado == 0)
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            return retorno;
        }
    }
}
