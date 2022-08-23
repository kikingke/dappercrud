namespace _4.WinFormApp
{
    partial class frmCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlCliente = new System.Windows.Forms.TabControl();
            this.Activos = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRecordsActivos = new System.Windows.Forms.Label();
            this.txtSearchActivados = new System.Windows.Forms.TextBox();
            this.btnNextActivos = new System.Windows.Forms.Button();
            this.btnPreviousActivos = new System.Windows.Forms.Button();
            this.lblTotalPaginasActivos = new System.Windows.Forms.Label();
            this.dgvClienteActivados = new System.Windows.Forms.DataGridView();
            this.Inactivos = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRecordsInactivos = new System.Windows.Forms.Label();
            this.txtSearchInactivos = new System.Windows.Forms.TextBox();
            this.btnNextInactivos = new System.Windows.Forms.Button();
            this.btnPreviousInactivos = new System.Windows.Forms.Button();
            this.lblTotalPaginasInactivos = new System.Windows.Forms.Label();
            this.dgvClientesInactivos = new System.Windows.Forms.DataGridView();
            this.Lista = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.Datos = new System.Windows.Forms.TabPage();
            this.panelNewForm = new System.Windows.Forms.Panel();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlCliente.SuspendLayout();
            this.Activos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteActivados)).BeginInit();
            this.Inactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesInactivos)).BeginInit();
            this.Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.Datos.SuspendLayout();
            this.panelNewForm.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCliente.Controls.Add(this.Activos);
            this.tabControlCliente.Controls.Add(this.Inactivos);
            this.tabControlCliente.Controls.Add(this.Lista);
            this.tabControlCliente.Controls.Add(this.Datos);
            this.tabControlCliente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControlCliente.ItemSize = new System.Drawing.Size(130, 30);
            this.tabControlCliente.Location = new System.Drawing.Point(-4, 57);
            this.tabControlCliente.Name = "tabControlCliente";
            this.tabControlCliente.SelectedIndex = 0;
            this.tabControlCliente.Size = new System.Drawing.Size(800, 521);
            this.tabControlCliente.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlCliente.TabIndex = 8;
            this.tabControlCliente.SelectedIndexChanged += new System.EventHandler(this.tabControlCliente_SelectedIndexChanged);
            // 
            // Activos
            // 
            this.Activos.Controls.Add(this.label10);
            this.Activos.Controls.Add(this.lblRecordsActivos);
            this.Activos.Controls.Add(this.txtSearchActivados);
            this.Activos.Controls.Add(this.btnNextActivos);
            this.Activos.Controls.Add(this.btnPreviousActivos);
            this.Activos.Controls.Add(this.lblTotalPaginasActivos);
            this.Activos.Controls.Add(this.dgvClienteActivados);
            this.Activos.Location = new System.Drawing.Point(4, 34);
            this.Activos.Margin = new System.Windows.Forms.Padding(0);
            this.Activos.Name = "Activos";
            this.Activos.Size = new System.Drawing.Size(792, 483);
            this.Activos.TabIndex = 3;
            this.Activos.Text = "Activos";
            this.Activos.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(8, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Buscar:";
            // 
            // lblRecordsActivos
            // 
            this.lblRecordsActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsActivos.AutoSize = true;
            this.lblRecordsActivos.Location = new System.Drawing.Point(12, 446);
            this.lblRecordsActivos.Name = "lblRecordsActivos";
            this.lblRecordsActivos.Size = new System.Drawing.Size(63, 25);
            this.lblRecordsActivos.TabIndex = 14;
            this.lblRecordsActivos.Text = "label6";
            // 
            // txtSearchActivados
            // 
            this.txtSearchActivados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchActivados.Location = new System.Drawing.Point(75, 17);
            this.txtSearchActivados.Name = "txtSearchActivados";
            this.txtSearchActivados.PlaceholderText = "Buscar por Nombre, Apellido o Telefono";
            this.txtSearchActivados.Size = new System.Drawing.Size(466, 29);
            this.txtSearchActivados.TabIndex = 13;
            this.txtSearchActivados.TextChanged += new System.EventHandler(this.txtSearchActivados_TextChanged);
            // 
            // btnNextActivos
            // 
            this.btnNextActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextActivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextActivos.Location = new System.Drawing.Point(691, 441);
            this.btnNextActivos.Name = "btnNextActivos";
            this.btnNextActivos.Size = new System.Drawing.Size(98, 35);
            this.btnNextActivos.TabIndex = 12;
            this.btnNextActivos.Text = "Despues =>";
            this.btnNextActivos.UseVisualStyleBackColor = true;
            this.btnNextActivos.Click += new System.EventHandler(this.btnNextActivos_Click);
            // 
            // btnPreviousActivos
            // 
            this.btnPreviousActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousActivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousActivos.Location = new System.Drawing.Point(508, 441);
            this.btnPreviousActivos.Name = "btnPreviousActivos";
            this.btnPreviousActivos.Size = new System.Drawing.Size(93, 36);
            this.btnPreviousActivos.TabIndex = 11;
            this.btnPreviousActivos.Text = " <= Antes";
            this.btnPreviousActivos.UseVisualStyleBackColor = true;
            this.btnPreviousActivos.Click += new System.EventHandler(this.btnPreviousActivos_Click);
            // 
            // lblTotalPaginasActivos
            // 
            this.lblTotalPaginasActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPaginasActivos.AutoSize = true;
            this.lblTotalPaginasActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPaginasActivos.Location = new System.Drawing.Point(631, 452);
            this.lblTotalPaginasActivos.Name = "lblTotalPaginasActivos";
            this.lblTotalPaginasActivos.Size = new System.Drawing.Size(33, 15);
            this.lblTotalPaginasActivos.TabIndex = 10;
            this.lblTotalPaginasActivos.Text = "total";
            this.lblTotalPaginasActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvClienteActivados
            // 
            this.dgvClienteActivados.AllowUserToAddRows = false;
            this.dgvClienteActivados.AllowUserToDeleteRows = false;
            this.dgvClienteActivados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClienteActivados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClienteActivados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClienteActivados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteActivados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClienteActivados.Location = new System.Drawing.Point(1, 66);
            this.dgvClienteActivados.Name = "dgvClienteActivados";
            this.dgvClienteActivados.ReadOnly = true;
            this.dgvClienteActivados.RowTemplate.Height = 25;
            this.dgvClienteActivados.Size = new System.Drawing.Size(791, 369);
            this.dgvClienteActivados.TabIndex = 9;
            this.dgvClienteActivados.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClienteActivados_RowHeaderMouseDoubleClick);
            // 
            // Inactivos
            // 
            this.Inactivos.Controls.Add(this.label11);
            this.Inactivos.Controls.Add(this.lblRecordsInactivos);
            this.Inactivos.Controls.Add(this.txtSearchInactivos);
            this.Inactivos.Controls.Add(this.btnNextInactivos);
            this.Inactivos.Controls.Add(this.btnPreviousInactivos);
            this.Inactivos.Controls.Add(this.lblTotalPaginasInactivos);
            this.Inactivos.Controls.Add(this.dgvClientesInactivos);
            this.Inactivos.Location = new System.Drawing.Point(4, 34);
            this.Inactivos.Name = "Inactivos";
            this.Inactivos.Padding = new System.Windows.Forms.Padding(3);
            this.Inactivos.Size = new System.Drawing.Size(792, 483);
            this.Inactivos.TabIndex = 2;
            this.Inactivos.Text = "Inactivos";
            this.Inactivos.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(8, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Buscar:";
            // 
            // lblRecordsInactivos
            // 
            this.lblRecordsInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsInactivos.AutoSize = true;
            this.lblRecordsInactivos.Location = new System.Drawing.Point(6, 442);
            this.lblRecordsInactivos.Name = "lblRecordsInactivos";
            this.lblRecordsInactivos.Size = new System.Drawing.Size(63, 25);
            this.lblRecordsInactivos.TabIndex = 14;
            this.lblRecordsInactivos.Text = "label6";
            // 
            // txtSearchInactivos
            // 
            this.txtSearchInactivos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchInactivos.Location = new System.Drawing.Point(75, 22);
            this.txtSearchInactivos.Name = "txtSearchInactivos";
            this.txtSearchInactivos.PlaceholderText = "Buscar por Nombre, Apellido o Telefono";
            this.txtSearchInactivos.Size = new System.Drawing.Size(466, 29);
            this.txtSearchInactivos.TabIndex = 13;
            this.txtSearchInactivos.TextChanged += new System.EventHandler(this.txtSearchInactivos_TextChanged);
            // 
            // btnNextInactivos
            // 
            this.btnNextInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextInactivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextInactivos.Location = new System.Drawing.Point(690, 440);
            this.btnNextInactivos.Name = "btnNextInactivos";
            this.btnNextInactivos.Size = new System.Drawing.Size(98, 35);
            this.btnNextInactivos.TabIndex = 12;
            this.btnNextInactivos.Text = "Despues =>";
            this.btnNextInactivos.UseVisualStyleBackColor = true;
            this.btnNextInactivos.Click += new System.EventHandler(this.btnNextInactivos_Click);
            // 
            // btnPreviousInactivos
            // 
            this.btnPreviousInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousInactivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousInactivos.Location = new System.Drawing.Point(498, 441);
            this.btnPreviousInactivos.Name = "btnPreviousInactivos";
            this.btnPreviousInactivos.Size = new System.Drawing.Size(93, 34);
            this.btnPreviousInactivos.TabIndex = 11;
            this.btnPreviousInactivos.Text = " <= Antes";
            this.btnPreviousInactivos.UseVisualStyleBackColor = true;
            this.btnPreviousInactivos.Click += new System.EventHandler(this.btnPreviousInactivos_Click);
            // 
            // lblTotalPaginasInactivos
            // 
            this.lblTotalPaginasInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPaginasInactivos.AutoSize = true;
            this.lblTotalPaginasInactivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPaginasInactivos.Location = new System.Drawing.Point(621, 452);
            this.lblTotalPaginasInactivos.Name = "lblTotalPaginasInactivos";
            this.lblTotalPaginasInactivos.Size = new System.Drawing.Size(33, 15);
            this.lblTotalPaginasInactivos.TabIndex = 10;
            this.lblTotalPaginasInactivos.Text = "total";
            this.lblTotalPaginasInactivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvClientesInactivos
            // 
            this.dgvClientesInactivos.AllowUserToAddRows = false;
            this.dgvClientesInactivos.AllowUserToDeleteRows = false;
            this.dgvClientesInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientesInactivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientesInactivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientesInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesInactivos.Location = new System.Drawing.Point(0, 73);
            this.dgvClientesInactivos.Name = "dgvClientesInactivos";
            this.dgvClientesInactivos.ReadOnly = true;
            this.dgvClientesInactivos.RowTemplate.Height = 25;
            this.dgvClientesInactivos.Size = new System.Drawing.Size(792, 361);
            this.dgvClientesInactivos.TabIndex = 9;
            this.dgvClientesInactivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesInactivos_CellContentClick);
            this.dgvClientesInactivos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientesInactivos_CellMouseUp);
            this.dgvClientesInactivos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientesInactivos_RowHeaderMouseDoubleClick);
            // 
            // Lista
            // 
            this.Lista.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Lista.Controls.Add(this.label12);
            this.Lista.Controls.Add(this.lblRecords);
            this.Lista.Controls.Add(this.txtSearch);
            this.Lista.Controls.Add(this.btnNext);
            this.Lista.Controls.Add(this.btnPrevious);
            this.Lista.Controls.Add(this.lblTotalPaginas);
            this.Lista.Controls.Add(this.dgvCliente);
            this.Lista.Location = new System.Drawing.Point(4, 34);
            this.Lista.Name = "Lista";
            this.Lista.Padding = new System.Windows.Forms.Padding(3);
            this.Lista.Size = new System.Drawing.Size(792, 483);
            this.Lista.TabIndex = 0;
            this.Lista.Text = "Lista General";
            this.Lista.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(8, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Buscar:";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(8, 449);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(63, 25);
            this.lblRecords.TabIndex = 8;
            this.lblRecords.Text = "label6";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(75, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Buscar por Nombre, Apellido o Telefono";
            this.txtSearch.Size = new System.Drawing.Size(466, 29);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(688, 444);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Despues =>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(496, 444);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(93, 36);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = " <= Antes";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPaginas.AutoSize = true;
            this.lblTotalPaginas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPaginas.Location = new System.Drawing.Point(617, 454);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(33, 15);
            this.lblTotalPaginas.TabIndex = 4;
            this.lblTotalPaginas.Text = "total";
            this.lblTotalPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(0, 74);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.Size = new System.Drawing.Size(792, 364);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCliente_RowHeaderMouseDoubleClick);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.panelNewForm);
            this.Datos.Location = new System.Drawing.Point(4, 34);
            this.Datos.Name = "Datos";
            this.Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Datos.Size = new System.Drawing.Size(792, 483);
            this.Datos.TabIndex = 1;
            this.Datos.Text = "Datos";
            this.Datos.UseVisualStyleBackColor = true;
            // 
            // panelNewForm
            // 
            this.panelNewForm.AutoSize = true;
            this.panelNewForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelNewForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNewForm.Controls.Add(this.chbStatus);
            this.panelNewForm.Controls.Add(this.btnGuardar);
            this.panelNewForm.Controls.Add(this.btnCancelar);
            this.panelNewForm.Controls.Add(this.lbltitulo);
            this.panelNewForm.Controls.Add(this.txtTelefono);
            this.panelNewForm.Controls.Add(this.label5);
            this.panelNewForm.Controls.Add(this.txtApellido);
            this.panelNewForm.Controls.Add(this.label4);
            this.panelNewForm.Controls.Add(this.txtNombre);
            this.panelNewForm.Controls.Add(this.label3);
            this.panelNewForm.Controls.Add(this.txtDireccion);
            this.panelNewForm.Controls.Add(this.label2);
            this.panelNewForm.Controls.Add(this.txtCodigo);
            this.panelNewForm.Controls.Add(this.label1);
            this.panelNewForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewForm.Location = new System.Drawing.Point(3, 3);
            this.panelNewForm.Name = "panelNewForm";
            this.panelNewForm.Size = new System.Drawing.Size(786, 477);
            this.panelNewForm.TabIndex = 6;
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Checked = true;
            this.chbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStatus.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbStatus.Location = new System.Drawing.Point(686, 14);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(85, 29);
            this.chbStatus.TabIndex = 11;
            this.chbStatus.Text = "Estado";
            this.chbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(8, 420);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(153, 51);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(628, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 51);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.Location = new System.Drawing.Point(19, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(151, 31);
            this.lbltitulo.TabIndex = 10;
            this.lbltitulo.Text = "Crear Cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.Location = new System.Drawing.Point(307, 85);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 34);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(307, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(307, 164);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 34);
            this.txtApellido.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(307, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(19, 164);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 34);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(19, 239);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(586, 106);
            this.txtDireccion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(19, 85);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(226, 34);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(621, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(175, 39);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Crear Cliente";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(8, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 15);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "label6";
            this.lblID.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarRegistroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tabControlCliente);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tabControlCliente.ResumeLayout(false);
            this.Activos.ResumeLayout(false);
            this.Activos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteActivados)).EndInit();
            this.Inactivos.ResumeLayout(false);
            this.Inactivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesInactivos)).EndInit();
            this.Lista.ResumeLayout(false);
            this.Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.panelNewForm.ResumeLayout(false);
            this.panelNewForm.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCliente;
        private System.Windows.Forms.TabPage Lista;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TabPage Datos;
        private System.Windows.Forms.Panel panelNewForm;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblTotalPaginas;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.TabPage Inactivos;
        private System.Windows.Forms.Label lblRecordsInactivos;
        private System.Windows.Forms.TextBox txtSearchInactivos;
        private System.Windows.Forms.Button btnNextInactivos;
        private System.Windows.Forms.Button btnPreviousInactivos;
        private System.Windows.Forms.Label lblTotalPaginasInactivos;
        private System.Windows.Forms.DataGridView dgvClientesInactivos;
        private System.Windows.Forms.TabPage Activos;
        private System.Windows.Forms.Label lblRecordsActivos;
        private System.Windows.Forms.TextBox txtSearchActivados;
        private System.Windows.Forms.Button btnNextActivos;
        private System.Windows.Forms.Button btnPreviousActivos;
        private System.Windows.Forms.Label lblTotalPaginasActivos;
        private System.Windows.Forms.DataGridView dgvClienteActivados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
    }
}
