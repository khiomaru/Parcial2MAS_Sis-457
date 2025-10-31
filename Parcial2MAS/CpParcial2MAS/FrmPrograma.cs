using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CadParcial2MAS;
using ClnParcial2MAS;

namespace CpParcial2MAS
{
    public partial class FrmPrograma : Form
    {
        private bool esNuevo = false;

        public FrmPrograma()
        {
            InitializeComponent();
        }

        private void listar()
        {
            dgvLista.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLista.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            var lista = ClnPrograma.Listar(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;

            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idCanal"].Visible = false;

            dgvLista.Columns["titulo"].HeaderText = "Título";
            dgvLista.Columns["descripcion"].HeaderText = "Sinopsis";
            dgvLista.Columns["productor"].HeaderText = "Director";
            dgvLista.Columns["duracion"].HeaderText = "Duración";
            dgvLista.Columns["fechaEstreno"].HeaderText = "Fecha de Estreno";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["titulo"];
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
        }

        private void FrmPrograma_Load(object sender, EventArgs e)
        {
            Size = new Size(860, 450);
            listar();
        }

        private void limpiar()
        {
            txtTitulo.Clear();
            txtSinopsis.Clear();
            txtDirector.Clear();
            nudEpisodios.Value = 0;
            dtpFechaEstreno.Value = DateTime.Now;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(860, 652);
            txtTitulo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(860, 450);
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(860, 652);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var serie = ClnPrograma.ObtenerPorId(id);

            txtTitulo.Text = serie.titulo;
            txtSinopsis.Text = serie.descripcion;
            txtDirector.Text = serie.productor;
            nudEpisodios.Value = serie.duracion;
            dtpFechaEstreno.Value = serie.fechaEstreno;

            txtTitulo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool validar()
        {
            bool esValido = true;

            erpTitulo.SetError(txtTitulo, "");
            erpSinopsis.SetError(txtSinopsis, "");
            erpDirector.SetError(txtDirector, "");
            erpEpisodios.SetError(nudEpisodios, "");
            erpFechaEstreno.SetError(dtpFechaEstreno, "");

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                erpTitulo.SetError(txtTitulo, "El campo Título es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtSinopsis.Text))
            {
                erpSinopsis.SetError(txtSinopsis, "El campo Sinopsis es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDirector.Text))
            {
                erpDirector.SetError(txtDirector, "El campo Director es obligatorio");
                esValido = false;
            }
            if (nudEpisodios.Value < 1)
            {
                erpEpisodios.SetError(nudEpisodios, "El campo Duración no puede ser menor a 1");
                esValido = false;
            }
            if (dtpFechaEstreno.Value.Date > DateTime.Today)
            {
                erpFechaEstreno.SetError(dtpFechaEstreno, "La fecha de estreno no puede ser futura");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var serie = new Programa
                {
                    titulo = txtTitulo.Text.Trim(),
                    descripcion = txtSinopsis.Text.Trim(),
                    productor = txtDirector.Text.Trim(),
                    duracion = Convert.ToInt32(nudEpisodios.Value),
                    fechaEstreno = dtpFechaEstreno.Value
                };

                if (esNuevo)
                {
                    serie.estado = 1;
                    ClnPrograma.Insertar(serie);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    serie.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    ClnPrograma.Actualizar(serie);
                }

                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Programa guardado correctamente", "::: Parcial 2 - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string titulo = dgvLista.Rows[index].Cells["titulo"].Value.ToString();

            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el programa {titulo}?",
                "::: Parcial 2 - Mensaje :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                ClnPrograma.Eliminar(id);
                listar();
                MessageBox.Show("Programa dado de baja correctamente", "::: Parcial 2 - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
