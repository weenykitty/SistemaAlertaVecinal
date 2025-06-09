using SistemaAlertaVecinal.Clases;

namespace SistemaAlertaVecinal
{
    public partial class FormMisAlertas : Form
    {
        public FormMisAlertas()
        {
            InitializeComponent();
        }

        private void FormMisAlertas_Load(object sender, EventArgs e)
        {
            List<Alerta> misReportes = SistemaSeguridad.ObtenerMisAlertas();
            foreach (var reporte in misReportes)
            {
                ListViewItem item = new ListViewItem(reporte.Tipo);
                dgvMisAlertas.Rows.Add(
                    reporte.Tipo,
                    reporte.Descripcion,
                    reporte.Direccion,
                    reporte.Fecha.ToString("dd/MM/yyyy HH:mm:ss"),
                    reporte.ReportadoPor,
                    reporte.Zona
                );
            }
        }
        private void dgvMisAlertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object valor = dgvMisAlertas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                txtContenido.Text = valor.ToString();
            }
        }
    }
}
