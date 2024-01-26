namespace ejemplo1
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rbtMuggle = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.lblNroFavorito = new System.Windows.Forms.Label();
            this.numNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(252, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(101, 718);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 33);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(89, 489);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(428, 223);
            this.lwElementos.TabIndex = 7;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(79, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(79, 113);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(141, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(252, 107);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(252, 151);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(198, 24);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "Te gusta el Chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(41, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // rbtWizard
            // 
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Checked = true;
            this.rbtWizard.Location = new System.Drawing.Point(6, 31);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(83, 24);
            this.rbtWizard.TabIndex = 0;
            this.rbtWizard.TabStop = true;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rbtMuggle
            // 
            this.rbtMuggle.AutoSize = true;
            this.rbtMuggle.Location = new System.Drawing.Point(169, 31);
            this.rbtMuggle.Name = "rbtMuggle";
            this.rbtMuggle.Size = new System.Drawing.Size(86, 24);
            this.rbtMuggle.TabIndex = 1;
            this.rbtMuggle.Text = "Muggle";
            this.rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(351, 31);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(83, 24);
            this.rbtSquibs.TabIndex = 2;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rbtSquibs);
            this.groupBox1.Controls.Add(this.rbtWizard);
            this.groupBox1.Controls.Add(this.rbtMuggle);
            this.groupBox1.Location = new System.Drawing.Point(83, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(85, 314);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(111, 20);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color Favorito:";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(252, 306);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(200, 28);
            this.cboColorFavorito.TabIndex = 4;
            // 
            // lblNroFavorito
            // 
            this.lblNroFavorito.AutoSize = true;
            this.lblNroFavorito.Location = new System.Drawing.Point(85, 354);
            this.lblNroFavorito.Name = "lblNroFavorito";
            this.lblNroFavorito.Size = new System.Drawing.Size(130, 20);
            this.lblNroFavorito.TabIndex = 14;
            this.lblNroFavorito.Text = "Numero Favorito:";
            // 
            // numNumeroFavorito
            // 
            this.numNumeroFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeroFavorito.Location = new System.Drawing.Point(252, 354);
            this.numNumeroFavorito.Name = "numNumeroFavorito";
            this.numNumeroFavorito.Size = new System.Drawing.Size(196, 26);
            this.numNumeroFavorito.TabIndex = 5;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(89, 424);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(131, 31);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver &Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 773);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.numNumeroFavorito);
            this.Controls.Add(this.lblNroFavorito);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(713, 829);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primera APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rbtMuggle;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Label lblNroFavorito;
        private System.Windows.Forms.NumericUpDown numNumeroFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

