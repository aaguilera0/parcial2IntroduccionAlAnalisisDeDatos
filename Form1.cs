using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundoParcialAnalisisDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double capital = 850000;

                double p1 = double.Parse(txtBPA1.Text);
                double p2 = double.Parse(txtBPA2.Text);
                double p3 = double.Parse(txtBPA3.Text);
                double promedioProv = (p1 + p2 + p3) / 3;
                double provAnual = capital * (1 + promedioProv / 100);
                double provTrim = capital * Math.Pow((1 + (promedioProv / 4) / 100), 4);
                double provMens = capital * Math.Pow((1 + (promedioProv / 12) / 100), 12);

                double n1 = double.Parse(txtBNA1.Text);
                double n2 = double.Parse(txtBNA2.Text);
                double n3 = double.Parse(txtBNA3.Text);
                double promedioNac = (n1 + n2 + n3) / 3;
                double nacAnual = capital * (1 + promedioNac / 100);
                double nacTrim = capital * Math.Pow((1 + (promedioNac / 4) / 100), 4);
                double nacMens = capital * Math.Pow((1 + (promedioNac / 12) / 100), 12);

                double h1 = double.Parse(txtBHA1.Text);
                double h2 = double.Parse(txtBHA2.Text);
                double h3 = double.Parse(txtBHA3.Text);
                double promedioHip = (h1 + h2 + h3) / 3;
                double hipAnual = capital * (1 + promedioHip / 100);
                double hipTrim = capital * Math.Pow((1 + (promedioHip / 4) / 100), 4);
                double hipMens = capital * Math.Pow((1 + (promedioHip / 12) / 100), 12);

                double mejorMonto = provAnual;
                string banco = "Banco Provincia";
                string modalidad = "Anual";

                if (provTrim > mejorMonto)
                {
                    mejorMonto = provTrim;
                    banco = "Banco Provincia";
                    modalidad = "Trimestral";
                }
                if (provMens > mejorMonto)
                {
                    mejorMonto = provMens;
                    banco = "Banco Provincia";
                    modalidad = "Mensual";
                }
                if (nacAnual > mejorMonto)
                {
                    mejorMonto = nacAnual;
                    banco = "Banco Nación";
                    modalidad = "Anual";
                }
                if (nacTrim > mejorMonto)
                {
                    mejorMonto = nacTrim;
                    banco = "Banco Nación";
                    modalidad = "Trimestral";
                }
                if (nacMens > mejorMonto)
                {
                    mejorMonto = nacMens;
                    banco = "Banco Nación";
                    modalidad = "Mensual";
                }
                if (hipAnual > mejorMonto)
                {
                    mejorMonto = hipAnual;
                    banco = "Banco Hipotecario";
                    modalidad = "Anual";
                }
                if (hipTrim > mejorMonto)
                {
                    mejorMonto = hipTrim;
                    banco = "Banco Hipotecario";
                    modalidad = "Trimestral";
                }
                if (hipMens > mejorMonto)
                {
                    mejorMonto = hipMens;
                    banco = "Banco Hipotecario";
                    modalidad = "Mensual";
                }

                resultadosInversion resultados = new resultadosInversion(
                    promedioProv, provAnual, provTrim, provMens,
                    promedioNac, nacAnual, nacTrim, nacMens,
                    promedioHip, hipAnual, hipTrim, hipMens,
                    banco, modalidad
                );

                resultados.Show();
            }
            catch
            {
                MessageBox.Show("VERIFICA QUE LOS CAMPOS ESTEN BIEN COMPLETADOS.");
            }
        }
    }
}

