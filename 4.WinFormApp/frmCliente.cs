using CEntities;
using CNegocio;
using PagedList;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _4.WinFormApp
{
    public partial class frmCliente : Form
    {
        private NCliente objCliente = new NCliente();
        int pagNumber = 1, rowIndice = 0;
        public static string busqueda;
        IPagedList<Cliente> list, listInactivos;
        bool IsEdit;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            loadgridCliente();
            loadgridClienteActivos();
           
        }

        #region General

        #region Methods

        public void loadgridCliente()
        {
            list = IPGetClientes();
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            this.dgvCliente.DataSource = list.ToList();
            dgvCliente.Columns["Cliente_ID"].Visible = false;
            dgvCliente.Columns["Cliente_Direccion"].Visible = false;
           // dgvCliente.Columns["Cliente_Status"].Visible = false;
            dgvCliente.Columns[1].HeaderCell.Value = "Codigo";
            dgvCliente.Columns[2].HeaderCell.Value = "Nombre";
            dgvCliente.Columns[3].HeaderCell.Value = "Apellido";
            dgvCliente.Columns[4].HeaderCell.Value = "Teléfono";
            dgvCliente.Columns[6].HeaderCell.Value = "Estado";
            lblTotalPaginas.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
            lblRecords.Text = $"Total de registros: {objCliente.GetTotalAmountOfClientes().ToString()}";
        }

        public IPagedList<Cliente> IPGetClientes(int pagNumber=1, int pageSize=10)
        {
         return objCliente.GetClientes().ToPagedList(pagNumber,pageSize);
        }

        public void loadgridClienteSearch(string search = "",int pagNumber = 1, int pageSize = 10)
        {
            if (search != string.Empty) {
                IPagedList<Cliente> listaFiltrada = objCliente.GetClientes().Where(q => (q.Cliente_Nombre + " " + q.Cliente_Apellido + " " + q.Cliente_Telefono)
               .ToLower()
               .Contains(search.ToLower()))
               .ToPagedList(pagNumber, pageSize);

                list = listaFiltrada;

            }
            else
            {
                list = IPGetClientes();
            }
            
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            this.dgvCliente.DataSource = list.ToList();
            lblTotalPaginas.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
        }


        public void limpiarInputs()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        public void guardarCliente()
        {
            int response = 0;
            Cliente tempCliente = new Cliente()
            {
                Cliente_ID = Convert.ToInt32(lblID.Text),
                Cliente_Codigo = txtCodigo.Text,
                Cliente_Nombre = txtNombre.Text,
                Cliente_Apellido = txtApellido.Text,
                Cliente_Telefono = txtTelefono.Text,
                Cliente_Direccion = txtDireccion.Text,
                Cliente_Status = chbStatus.Checked
            };

            if (tempCliente != null)
            {
                if (IsEdit)
                {
                     response = objCliente.EditCliente(tempCliente);
                }
                else
                {
                     response = objCliente.AddCliente(tempCliente);
                }
                 
                if (response > 0)
                {
                    MessageBox.Show("Se guardo correctamente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
        }

        public string uniqueUUID()
        {
            Guid myuuid = Guid.NewGuid();
            string myuuidAsString = myuuid.ToString();
            return myuuidAsString;
        }

        #endregion


        #region Events

        private void btnNew_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 3;
            txtNombre.Focus();
            txtCodigo.Text = uniqueUUID();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 0;
            IsEdit = false;
            limpiarInputs();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!IsEdit)
            {
                if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtTelefono.Text == string.Empty || txtDireccion.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor llenar todos los campos.", ",Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    guardarCliente();
                    loadgridCliente();
                    tabControlCliente.SelectedIndex = 2;
                    limpiarInputs();
                }
            }
            guardarCliente();
            loadgridCliente();
            tabControlCliente.SelectedIndex = 2;
            limpiarInputs();


        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = IPGetClientes(--pagNumber);
                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                this.dgvCliente.DataSource = list.ToList();
                lblTotalPaginas.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = IPGetClientes(++pagNumber);
                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                this.dgvCliente.DataSource = list.ToList();
                lblTotalPaginas.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadgridClienteSearch(txtSearch.Text);
        }

        private void tabControlCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCliente.SelectedIndex == 1)
            {
                loadgridClienteInactivos();
              //  txtNombre.Focus();
              //  txtCodigo.Text = uniqueUUID();
            }
        }

        private void dgvCliente_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            IsEdit = true;
            lbltitulo.Text = "Editando Cliente";

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                lblID.Text = row.Cells[0].Value.ToString();
                txtCodigo.Text = row.Cells[1].Value.ToString();
                txtNombre.Text = row.Cells[2].Value.ToString();
                txtApellido.Text = row.Cells[3].Value.ToString();
                txtTelefono.Text = row.Cells[4].Value.ToString();
                txtDireccion.Text = row.Cells[5].Value.ToString();
                chbStatus.Checked = (bool)row.Cells[6].Value;
            }
            tabControlCliente.SelectedIndex = 3;

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        #endregion


        #region Activados

        #region Methods

        public void loadgridClienteActivos()
        {
            list = IPGetClientesActivos();
            btnPreviousActivos.Enabled = list.HasPreviousPage;
            btnNextActivos.Enabled = list.HasNextPage;
            this.dgvClienteActivados.DataSource = list.ToList();
            dgvClienteActivados.Columns["Cliente_ID"].Visible = false;
            dgvClienteActivados.Columns["Cliente_Direccion"].Visible = false;
            dgvClienteActivados.Columns["Cliente_Status"].Visible = false;
            dgvClienteActivados.Columns[1].HeaderCell.Value = "Codigo";
            dgvClienteActivados.Columns[2].HeaderCell.Value = "Nombre";
            dgvClienteActivados.Columns[3].HeaderCell.Value = "Apellido";
            dgvClienteActivados.Columns[4].HeaderCell.Value = "Teléfono";
            lblTotalPaginasActivos.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
            lblRecordsActivos.Text = $"Total de registros: {objCliente.GetClientesActivos().Count}";
        }

        public IPagedList<Cliente> IPGetClientesActivos(int pagNumber = 1, int pageSize = 10)
        {
            return objCliente.GetClientesActivos().ToPagedList(pagNumber, pageSize);
        }

        public void loadgridClienteSearchActivados(string search = "", int pagNumber = 1, int pageSize = 10)
        {
            if (search != string.Empty)
            {
                IPagedList<Cliente> listaFiltrada = objCliente.GetClientes().Where(q => (q.Cliente_Nombre + " " + q.Cliente_Apellido + " " + q.Cliente_Telefono)
               .ToLower()
               .Contains(search.ToLower()))
               .ToPagedList(pagNumber, pageSize);

                list = listaFiltrada;

            }
            else
            {
                list = IPGetClientesActivos();
            }

            btnPreviousActivos.Enabled = list.HasPreviousPage;
            btnNextActivos.Enabled = list.HasNextPage;
            this.dgvClienteActivados.DataSource = list.ToList();
            lblTotalPaginasActivos.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
        }

        #endregion

        #region Events
        private void btnPreviousActivos_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = IPGetClientesActivos(--pagNumber);
                btnPreviousActivos.Enabled = list.HasPreviousPage;
                btnNextActivos.Enabled = list.HasNextPage;
                this.dgvClienteActivados.DataSource = list.ToList();
                lblTotalPaginasActivos.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
            }
        }

        private void btnNextActivos_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = IPGetClientesActivos(++pagNumber);
                btnPreviousActivos.Enabled = list.HasPreviousPage;
                btnNextActivos.Enabled = list.HasNextPage;
                this.dgvClienteActivados.DataSource = list.ToList();
                lblTotalPaginasActivos.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
            }
        }

        private void txtSearchActivados_TextChanged(object sender, EventArgs e)
        {
            loadgridClienteSearchActivados(txtSearchActivados.Text);
        }

        private void dgvClienteActivados_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IsEdit = true;
            lbltitulo.Text = "Editando Cliente";

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvClienteActivados.Rows[e.RowIndex];
                lblID.Text = row.Cells[0].Value.ToString();
                txtCodigo.Text = row.Cells[1].Value.ToString();
                txtNombre.Text = row.Cells[2].Value.ToString();
                txtApellido.Text = row.Cells[3].Value.ToString();
                txtTelefono.Text = row.Cells[4].Value.ToString();
                txtDireccion.Text = row.Cells[5].Value.ToString();
                chbStatus.Checked = Convert.ToBoolean(row.Cells[6].Value);
            }
            tabControlCliente.SelectedIndex = 3;
        }

        #endregion

        #endregion


        #region Inactivos

        #region Methods

        public void loadgridClienteInactivos()
        {
            listInactivos = IPGetClientesInactivos();
            btnPreviousInactivos.Enabled = list.HasPreviousPage;
            btnNextInactivos.Enabled = list.HasNextPage;
            this.dgvClientesInactivos.DataSource = listInactivos.ToList();
           // dgvClientesInactivos.Columns["Cliente_ID"].Visible = false;
            dgvClientesInactivos.Columns["Cliente_Direccion"].Visible = false;
            dgvClientesInactivos.Columns["Cliente_Status"].Visible = false;
            dgvClientesInactivos.Columns["Cliente_ID"].Visible = false;
            dgvClientesInactivos.Columns[0].HeaderCell.Value = "ID";
            dgvClientesInactivos.Columns[1].HeaderCell.Value = "Codigo";
            dgvClientesInactivos.Columns[2].HeaderCell.Value = "Nombre";
            dgvClientesInactivos.Columns[3].HeaderCell.Value = "Apellido";
            dgvClientesInactivos.Columns[4].HeaderCell.Value = "Teléfono";

         /*   DataGridViewButtonColumn buttonColumnDel = new DataGridViewButtonColumn();
            dgvClientesInactivos.Columns.Insert(7, buttonColumnDel);
            buttonColumnDel.HeaderText = "Eliminar";
            buttonColumnDel.Width = 100;
            buttonColumnDel.UseColumnTextForButtonValue = true;*/

            lblTotalPaginasInactivos.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
            lblRecordsInactivos.Text = $"Total de registros: {objCliente.GetClientesInactivos().Count}";
        }

        public IPagedList<Cliente> IPGetClientesInactivos(int pagNumber = 1, int pageSize = 10)
        {
            return objCliente.GetClientesInactivos().ToPagedList(pagNumber, pageSize);
        }

        public void loadgridClienteSearchInactivos(string search = "", int pagNumber = 1, int pageSize = 10)
        {
            if (search != string.Empty)
            {
                IPagedList<Cliente> listaFiltrada = objCliente.GetClientes().Where(q => (q.Cliente_Nombre + " " + q.Cliente_Apellido + " " + q.Cliente_Telefono)
               .ToLower()
               .Contains(search.ToLower()))
               .ToPagedList(pagNumber, pageSize);

                list = listaFiltrada;

            }
            else
            {
                list = IPGetClientesActivos();
            }

            btnPreviousInactivos.Enabled = list.HasPreviousPage;
            btnNextInactivos.Enabled = list.HasNextPage;
            this.dgvClientesInactivos.DataSource = list.ToList();
            lblTotalPaginasInactivos.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
        }


    








        #endregion

        #region Events


        private void dgvClientesInactivos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IsEdit = true;
            lbltitulo.Text = "Editando Cliente";

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvClientesInactivos.Rows[e.RowIndex];
                lblID.Text = row.Cells[0].Value?.ToString();
                txtCodigo.Text = row.Cells[1].Value.ToString();
                txtNombre.Text = row.Cells[2].Value.ToString();
                txtApellido.Text = row.Cells[3].Value.ToString();
                txtTelefono.Text = row.Cells[4].Value.ToString();
                txtDireccion.Text = row.Cells[5].Value.ToString();
                chbStatus.Checked = (bool)row.Cells[6].Value;
            }
            tabControlCliente.SelectedIndex = 3;
        }

        private void txtSearchInactivos_TextChanged(object sender, EventArgs e)
        {
            loadgridClienteSearchInactivos(txtSearchInactivos.Text);
        }

        private void btnPreviousInactivos_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = IPGetClientesInactivos(--pagNumber);
                btnPreviousInactivos.Enabled = list.HasPreviousPage;
                btnNextInactivos.Enabled = list.HasNextPage;
                this.dgvClientesInactivos.DataSource = list.ToList();
                lblTotalPaginasInactivos.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
            }
        }

        private void btnNextInactivos_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = IPGetClientesInactivos(++pagNumber);
                btnPreviousInactivos.Enabled = list.HasPreviousPage;
                btnNextInactivos.Enabled = list.HasNextPage;
                this.dgvClientesInactivos.DataSource = list.ToList();
                lblTotalPaginasInactivos.Text = string.Format("Page {0}/{1}", pagNumber, list.PageCount);
            }
        }

        private void dgvClientesInactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex == 8)
            {
                DataGridViewRow row = new DataGridViewRow();
                if (MessageBox.Show(string.Format("Confirmar Eliminación: ",row.Cells[1].Value), "Confirmar",MessageBoxButtons.YesNo)== DialogResult.Yes) {
                    Cliente tempID = new Cliente()
                    {
                        Cliente_ID = Convert.ToInt32(lblID.Text)
                    };
                    objCliente.DeleteCliente(tempID);
                    loadgridClienteInactivos();
                }
            }*/
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

            Cliente tempCliente = new Cliente() { 
            Cliente_ID = Convert.ToInt32(dgvClientesInactivos.SelectedRows[0].Cells[0].Value)
            };
            string queryLastName = objCliente.GetClientesInactivos().Where(a => a.Cliente_ID == tempCliente.Cliente_ID).Select(a => a.Cliente_Apellido).FirstOrDefault();
            string queryName = objCliente.GetClientesInactivos().Where(a => a.Cliente_ID == tempCliente.Cliente_ID).Select(a => a.Cliente_Nombre).FirstOrDefault();
            string FullName = queryName +" "+ queryLastName;
            if (MessageBox.Show(string.Format("Eliminar Cliente: {0}", FullName), "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
             objCliente.DeleteCliente(tempCliente);
            }
            loadgridClienteInactivos();
        }

        private void dgvClientesInactivos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvClientesInactivos.Rows[e.RowIndex].Selected = true;
                this.rowIndice = e.RowIndex;
                this.dgvClientesInactivos.CurrentCell = this.dgvClientesInactivos.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgvClientesInactivos, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        #endregion

        #endregion


    }
}
