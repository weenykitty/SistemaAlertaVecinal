using SistemaAlertaVecinal.Clases;

namespace SistemaAlertaVecinal
{
    public partial class FormAlertas : Form
    {
        public FormAlertas()
        {
            InitializeComponent();
        }

        private void FormAlertas_Load(object sender, EventArgs e)
        {
            List<Alerta> alertas = SistemaSeguridad.BuscarAlertasEnMiZona();
            foreach (var alerta in alertas)
            {
                ListViewItem item = new ListViewItem(alerta.Tipo);
                dgvAlertasVecinos.Rows.Add(
                    alerta.Tipo,
                    alerta.Descripcion,
                    alerta.Direccion,
                    alerta.Fecha.ToString("dd/MM/yyyy HH:mm:ss"),
                    alerta.ReportadoPor,
                    alerta.Zona
                );
            }
        }

        private void dgvAlertasVecinos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object valor = dgvAlertasVecinos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                txtContenido.Text = valor?.ToString() ?? "";
            }
        }
    }
}
