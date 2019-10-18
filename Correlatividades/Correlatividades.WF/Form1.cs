using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Correlatividades.WF
{
    public partial class FrmCorrelatividades : Form
    {
        Catedra catedra;
        CheckBox[] listaCheckBox = new CheckBox[6];

        public FrmCorrelatividades()
        {
            InitializeComponent();

            this.catedra = new Catedra();

            List<CheckBox> aux;
            int j = 0;
            aux = Controls.OfType<CheckBox>().ToList(); //AGREGA TODOS LOS BOTONOES A LA LISTA
            for (int i = 5; i >= 0; i--) //SE AGREGA RECORRIENDO LA LISTA A LA IVERSA PORQUE LOS BOTONES ASI FUERON AGREGADOS
            {
                listaCheckBox[j] = aux.ElementAt(i);
                j++;
            }

            foreach  (ECuatrimestre item in Enum.GetValues(typeof(ECuatrimestre)))
            {
                this.cmbBoxCuatrimestre.Items.Add(item);
            }

            this.cmbBoxCuatrimestre.SelectedItem = ECuatrimestre.PrimerCuatrimestre;
            this.cambioDeIndex();
            
        }

        private void BtnCorrelatividades_Click(object sender, EventArgs e)
        {
            this.limpiarLista();
            foreach (Materia materia in this.catedra.listaMaterias)
            {
                if(materia.estado == 0)
                {
                    if (this.catedra.puedeCursarse(materia))
                        this.listCursada.Items.Add(materia.nombre);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarLista();
        }

        private void CmbBoxCuatrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cambioDeIndex();
        }

        private void cambioDeIndex()
        {
            this.limpiarCheckBox();
            this.crearCheckBox((ECuatrimestre)this.cmbBoxCuatrimestre.SelectedItem);
        }

        private void limpiarLista()
        {
            this.listCursada.Items.Clear();
        }

        private void limpiarCheckBox()
        {
            foreach (CheckBox item in this.listaCheckBox)
            {
                item.Text = "";
                item.Visible = false;
                item.Checked = false;
            }
        }

        private void crearCheckBox(ECuatrimestre cuatrimestre)
        {
            int index = 0;
            foreach (Materia item in this.catedra.listaMaterias)
            {
                if (item.cuatrimestre == cuatrimestre)
                {
                    this.listaCheckBox[index].Text = item.nombre;
                    this.listaCheckBox[index].Visible = true;
                    if(item.estado == 1)
                    {
                        this.listaCheckBox[index].Checked = true;
                    }
                    index++;
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            foreach (Materia item in this.catedra.listaMaterias)
            {
                if(item.nombre == checkBox.Text)
                {
                    if(checkBox.Checked == true)
                    {
                        item.estado = 1;
                    }
                    else
                    {
                        item.estado = 0;
                    }
                    break;
                }
            }
        }
    }
}
