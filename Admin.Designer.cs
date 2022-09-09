namespace Sorteo
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tablaDgv = new System.Windows.Forms.DataGridView();
            this.cedulaTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sortearBtn = new System.Windows.Forms.Button();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.coparBtn = new System.Windows.Forms.Button();
            this.nombreTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apellidoTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefonoTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDgv
            // 
            this.tablaDgv.AllowUserToAddRows = false;
            this.tablaDgv.AllowUserToDeleteRows = false;
            this.tablaDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDgv.Location = new System.Drawing.Point(257, 12);
            this.tablaDgv.Name = "tablaDgv";
            this.tablaDgv.RowTemplate.Height = 25;
            this.tablaDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDgv.Size = new System.Drawing.Size(531, 345);
            this.tablaDgv.TabIndex = 0;
            // 
            // cedulaTbx
            // 
            this.cedulaTbx.Location = new System.Drawing.Point(12, 65);
            this.cedulaTbx.Name = "cedulaTbx";
            this.cedulaTbx.Size = new System.Drawing.Size(239, 23);
            this.cedulaTbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cédula (Identificador)";
            // 
            // sortearBtn
            // 
            this.sortearBtn.Location = new System.Drawing.Point(12, 258);
            this.sortearBtn.Name = "sortearBtn";
            this.sortearBtn.Size = new System.Drawing.Size(239, 48);
            this.sortearBtn.TabIndex = 3;
            this.sortearBtn.Text = "Sortear";
            this.sortearBtn.UseVisualStyleBackColor = true;
            this.sortearBtn.Click += new System.EventHandler(this.sortearBtn_Click);
            // 
            // borrarBtn
            // 
            this.borrarBtn.Location = new System.Drawing.Point(176, 229);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(75, 23);
            this.borrarBtn.TabIndex = 4;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(140, 312);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(111, 45);
            this.limpiarBtn.TabIndex = 5;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(12, 229);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarBtn.TabIndex = 6;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(95, 229);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 7;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Extra Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Admin";
            // 
            // coparBtn
            // 
            this.coparBtn.Location = new System.Drawing.Point(12, 312);
            this.coparBtn.Name = "coparBtn";
            this.coparBtn.Size = new System.Drawing.Size(122, 45);
            this.coparBtn.TabIndex = 9;
            this.coparBtn.Text = "Copiar al portapapeles";
            this.coparBtn.UseVisualStyleBackColor = true;
            this.coparBtn.Click += new System.EventHandler(this.coparBtn_Click);
            // 
            // nombreTbx
            // 
            this.nombreTbx.Location = new System.Drawing.Point(12, 109);
            this.nombreTbx.Name = "nombreTbx";
            this.nombreTbx.Size = new System.Drawing.Size(239, 23);
            this.nombreTbx.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellido";
            // 
            // apellidoTbx
            // 
            this.apellidoTbx.Location = new System.Drawing.Point(12, 153);
            this.apellidoTbx.Name = "apellidoTbx";
            this.apellidoTbx.Size = new System.Drawing.Size(239, 23);
            this.apellidoTbx.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Teléfono";
            // 
            // telefonoTbx
            // 
            this.telefonoTbx.Location = new System.Drawing.Point(12, 197);
            this.telefonoTbx.Name = "telefonoTbx";
            this.telefonoTbx.Size = new System.Drawing.Size(239, 23);
            this.telefonoTbx.TabIndex = 14;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefonoTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apellidoTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreTbx);
            this.Controls.Add(this.coparBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.borrarBtn);
            this.Controls.Add(this.sortearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cedulaTbx);
            this.Controls.Add(this.tablaDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Sorteo - Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tablaDgv;
        private TextBox cedulaTbx;
        private Label label1;
        private Button sortearBtn;
        private Button borrarBtn;
        private Button limpiarBtn;
        private Button agregarBtn;
        private Button buscarBtn;
        private Label label2;
        private Button coparBtn;
        private TextBox nombreTbx;
        private Label label3;
        private Label label4;
        private TextBox apellidoTbx;
        private Label label5;
        private TextBox telefonoTbx;
    }
}