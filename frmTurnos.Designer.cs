﻿namespace clinica
{
    partial class frmTurnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbxEstudios = new ComboBox();
            cbxTurnos = new ComboBox();
            btnSalir = new Button();
            cbxHoraInicio = new ComboBox();
            cbxHoraFin = new ComboBox();
            btnFiltrar = new Button();
            lblEstudio = new Label();
            dtpFechaDesde = new DateTimePicker();
            dtpFechaHasta = new DateTimePicker();
            lblFechaDesde = new Label();
            lblFechaHasta = new Label();
            lbxTurnos = new ListBox();
            SuspendLayout();
            // 
            // cbxEstudios
            // 
            cbxEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstudios.FormattingEnabled = true;
            cbxEstudios.Location = new Point(70, 84);
            cbxEstudios.Name = "cbxEstudios";
            cbxEstudios.Size = new Size(250, 23);
            cbxEstudios.TabIndex = 0;
            cbxEstudios.SelectedIndexChanged += cbxEstudios_SelectedIndexChanged;
            // 
            // cbxTurnos
            // 
            cbxTurnos.FormattingEnabled = true;
            cbxTurnos.Location = new Point(70, 268);
            cbxTurnos.Name = "cbxTurnos";
            cbxTurnos.Size = new Size(313, 23);
            cbxTurnos.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(694, 498);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cbxHoraInicio
            // 
            cbxHoraInicio.FormattingEnabled = true;
            cbxHoraInicio.Location = new Point(70, 193);
            cbxHoraInicio.Name = "cbxHoraInicio";
            cbxHoraInicio.Size = new Size(121, 23);
            cbxHoraInicio.TabIndex = 3;
            // 
            // cbxHoraFin
            // 
            cbxHoraFin.FormattingEnabled = true;
            cbxHoraFin.Location = new Point(359, 193);
            cbxHoraFin.Name = "cbxHoraFin";
            cbxHoraFin.Size = new Size(121, 23);
            cbxHoraFin.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(482, 247);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "button1";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.Location = new Point(70, 66);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(46, 15);
            lblEstudio.TabIndex = 6;
            lblEstudio.Text = "Estudio";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Location = new Point(70, 141);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(250, 23);
            dtpFechaDesde.TabIndex = 7;
            dtpFechaDesde.ValueChanged += dtpFechaDesde_ValueChanged;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Location = new Point(359, 141);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(250, 23);
            dtpFechaHasta.TabIndex = 8;
            dtpFechaHasta.ValueChanged += dtpFechaHasta_ValueChanged;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Location = new Point(70, 123);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(73, 15);
            lblFechaDesde.TabIndex = 9;
            lblFechaDesde.Text = "Fecha Desde";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Location = new Point(359, 123);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(71, 15);
            lblFechaHasta.TabIndex = 10;
            lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lbxTurnos
            // 
            lbxTurnos.FormattingEnabled = true;
            lbxTurnos.ItemHeight = 15;
            lbxTurnos.Location = new Point(70, 311);
            lbxTurnos.Name = "lbxTurnos";
            lbxTurnos.Size = new Size(527, 199);
            lbxTurnos.TabIndex = 11;
            // 
            // frmTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 533);
            Controls.Add(lbxTurnos);
            Controls.Add(lblFechaHasta);
            Controls.Add(lblFechaDesde);
            Controls.Add(dtpFechaHasta);
            Controls.Add(dtpFechaDesde);
            Controls.Add(lblEstudio);
            Controls.Add(btnFiltrar);
            Controls.Add(cbxHoraFin);
            Controls.Add(cbxHoraInicio);
            Controls.Add(btnSalir);
            Controls.Add(cbxTurnos);
            Controls.Add(cbxEstudios);
            Name = "frmTurnos";
            Text = "frmTurnos";
            Load += frmTurnos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxEstudios;
        private ComboBox cbxTurnos;
        private Button btnSalir;
        private ComboBox cbxHoraInicio;
        private ComboBox cbxHoraFin;
        private Button btnFiltrar;
        private Label lblEstudio;
        private DateTimePicker dtpFechaDesde;
        private DateTimePicker dtpFechaHasta;
        private Label lblFechaDesde;
        private Label lblFechaHasta;
        private ListBox lbxTurnos;
    }
}