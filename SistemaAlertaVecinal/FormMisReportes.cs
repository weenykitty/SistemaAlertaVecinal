using SistemaAlertaVecinal.Clases;

namespace SistemaAlertaVecinal
{
    public partial class FormMisReportes : Form
    {
        public FormMisReportes()
        {
            InitializeComponent();
        }

        private void FormMisReportes_Load(object sender, EventArgs e)
        {
            List<Alerta> misReportes = SistemaSeguridad.ObtenerMisReportes();
            foreach (var reporte in misReportes)
            {
                ListViewItem item = new ListViewItem(reporte.Tipo);
                dgvMisReportes.Rows.Add(
                    reporte.Tipo,
                    reporte.Descripcion,
                    reporte.Direccion,
                    reporte.Fecha.ToString("dd/MM/yyyy HH:mm:ss"),
                    reporte.ReportadoPor,
                    reporte.Zona
                );
            }
        }

        private void dgvMisReportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object valor = dgvMisReportes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                txtContenido.Text = valor.ToString();
            }
        }
    }
}
