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
    public partial class resultadosInversion : Form
    {
        double promedioProv, provAnual, provTrim, provMens;
        double promedioNac, nacAnual, nacTrim, nacMens;
        double promedioHip, hipAnual, hipTrim, hipMens;
        string mejorBanco, mejorModalidad;

        public resultadosInversion()
        {
            InitializeComponent();
        }

        public resultadosInversion(
            double promProv, double provAnual, double provTrim, double provMens,
            double promNac, double nacAnual, double nacTrim, double nacMens,
            double promHip, double hipAnual, double hipTrim, double hipMens,
            string mejorBanco, string mejorModalidad)
        {
            InitializeComponent();

            this.promedioProv = promProv;
            this.provAnual = provAnual;
            this.provTrim = provTrim;
            this.provMens = provMens;

            this.promedioNac = promNac;
            this.nacAnual = nacAnual;
            this.nacTrim = nacTrim;
            this.nacMens = nacMens;

            this.promedioHip = promHip;
            this.hipAnual = hipAnual;
            this.hipTrim = hipTrim;
            this.hipMens = hipMens;

            this.mejorBanco = mejorBanco;
            this.mejorModalidad = mejorModalidad;

            lblProvPromedio.Text = promedioProv.ToString("N2") + " %";
            lblProvMensual.Text = provMens.ToString("C2");
            lblProvTrimestral.Text = provTrim.ToString("C2");
            lblProvAnual.Text = provAnual.ToString("C2");

            lblNacPromedio.Text = promedioNac.ToString("N2") + " %";
            lblNacMensual.Text = nacMens.ToString("C2");
            lblNacTrimestral.Text = nacTrim.ToString("C2");
            lblNacAnual.Text = nacAnual.ToString("C2");

            lblHipoPromedio.Text = promedioHip.ToString("N2") + " %";
            lblHipoMensual.Text = hipMens.ToString("C2");
            lblHipoTrimestral.Text = hipTrim.ToString("C2");
            lblHipoAnual.Text = hipAnual.ToString("C2");

            lblOpcionRecomendada.Text = $"La mejor opción es {mejorBanco} ({mejorModalidad})";
        }
    }
}


