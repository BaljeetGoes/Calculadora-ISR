using System.Reflection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToInt32(txtSalario.Text);
            double sfs = salario * 0.0304;
            double afp = salario * 0.0287;
            double tss = sfs + afp;
            double SalarioTSS = salario - tss;
            double SalAnual = SalarioTSS * 12;


            lblAnual.Text = SalAnual.ToString("N2") + "$";
            lblSFS.Text = sfs.ToString("N2") + "$";
            lblAFP.Text = afp.ToString("N2") + "$";
            lblTOTAL.Text = tss.ToString("N2") + "$";
            lblTSS.Text = SalarioTSS.ToString("N2") + "$";

            if (SalAnual <= 416220)
            {
                lblESC.Text = "0,00$";
            } else if (SalAnual > 416220 && SalAnual <= 624329)
            {
                double ginger = SalAnual - 416220;
                lblESC.Text = (ginger * 0.15).ToString("N2") + "$";
                lblISR.Text = ((ginger * 0.15) / 12).ToString("N2") + "$";
            } else if (SalAnual > 624329 && SalAnual <= 867123)
            {
                double arbol = (SalAnual - 624329) + 31216;
                lblESC.Text = (arbol * 0.20).ToString("N2") + "$";
                lblISR.Text = ((arbol * 0.20) / 12).ToString("N2") + "$";
            } else if (SalAnual > 867123)
            {
                double ElReloc = (SalAnual - 867123) + 79776;
                lblESC.Text = (ElReloc * 0.25).ToString("N2") + "$";
                lblISR.Text = ((ElReloc * 0.25) / 12).ToString("N2") + "$";
            }
        }
    }
}
