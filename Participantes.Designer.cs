namespace Sorteo
{
    partial class Participantes
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
            this.nombreTbx = new System.Windows.Forms.TextBox();
            this.participarBtn = new System.Windows.Forms.Button();
            this.telefonoTbx = new System.Windows.Forms.TextBox();
            this.cedulaTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.apellidoTbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreTbx
            // 
            this.nombreTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreTbx.Location = new System.Drawing.Point(70, 62);
            this.nombreTbx.MaxLength = 50;
            this.nombreTbx.Name = "nombreTbx";
            this.nombreTbx.Size = new System.Drawing.Size(186, 26);
            this.nombreTbx.TabIndex = 1;
            this.nombreTbx.TextChanged += new System.EventHandler(this.nombreTbx_TextChanged);
            // 
            // participarBtn
            // 
            this.participarBtn.BackColor = System.Drawing.Color.Black;
            this.participarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.participarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.participarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.participarBtn.Font = new System.Drawing.Font("Montserrat Extra Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.participarBtn.ForeColor = System.Drawing.Color.White;
            this.participarBtn.Location = new System.Drawing.Point(70, 372);
            this.participarBtn.Name = "participarBtn";
            this.participarBtn.Size = new System.Drawing.Size(180, 37);
            this.participarBtn.TabIndex = 5;
            this.participarBtn.Text = "PARTICIPAR";
            this.participarBtn.UseVisualStyleBackColor = false;
            this.participarBtn.Click += new System.EventHandler(this.participarBtn_Click);
            // 
            // telefonoTbx
            // 
            this.telefonoTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telefonoTbx.Location = new System.Drawing.Point(70, 281);
            this.telefonoTbx.MaxLength = 20;
            this.telefonoTbx.Name = "telefonoTbx";
            this.telefonoTbx.Size = new System.Drawing.Size(186, 26);
            this.telefonoTbx.TabIndex = 4;
            // 
            // cedulaTbx
            // 
            this.cedulaTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cedulaTbx.Location = new System.Drawing.Point(70, 208);
            this.cedulaTbx.MaxLength = 8;
            this.cedulaTbx.Name = "cedulaTbx";
            this.cedulaTbx.Size = new System.Drawing.Size(186, 26);
            this.cedulaTbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(262, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Teléfono";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Montserrat Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Apellido.Location = new System.Drawing.Point(262, 137);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(79, 20);
            this.Apellido.TabIndex = 16;
            this.Apellido.Text = "Apellido";
            // 
            // apellidoTbx
            // 
            this.apellidoTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apellidoTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apellidoTbx.Location = new System.Drawing.Point(70, 135);
            this.apellidoTbx.MaxLength = 50;
            this.apellidoTbx.Name = "apellidoTbx";
            this.apellidoTbx.Size = new System.Drawing.Size(186, 26);
            this.apellidoTbx.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Sorteo.Properties.Resources.fondo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 603);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nombreTbx);
            this.panel2.Controls.Add(this.telefonoTbx);
            this.panel2.Controls.Add(this.Apellido);
            this.panel2.Controls.Add(this.cedulaTbx);
            this.panel2.Controls.Add(this.apellidoTbx);
            this.panel2.Controls.Add(this.participarBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 454);
            this.panel2.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Sorteo.Properties.Resources.fondo2;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(259, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 603);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 91);
            this.panel3.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackgroundImage = global::Sorteo.Properties.Resources.Logo_Catalina_Harriague_de_Castaños___UTU1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(300, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 68);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = global::Sorteo.Properties.Resources.anep;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(152, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 68);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::Sorteo.Properties.Resources.edusalto;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "*Sin puntos ni guiones";
            // 
            // Participantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Participantes";
            this.Text = "Sorteo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Participantes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox nombreTbx;
        private TextBox telefonoTbx;
        private TextBox cedulaTbx;
        private Button participarBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Apellido;
        private TextBox apellidoTbx;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
    }
}