namespace Sorteo
{
    partial class Login
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
            this.usuarioTbx = new System.Windows.Forms.TextBox();
            this.contraseniaTbx = new System.Windows.Forms.TextBox();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuarioTbx
            // 
            this.usuarioTbx.Location = new System.Drawing.Point(12, 121);
            this.usuarioTbx.Name = "usuarioTbx";
            this.usuarioTbx.Size = new System.Drawing.Size(206, 23);
            this.usuarioTbx.TabIndex = 0;
            // 
            // contraseniaTbx
            // 
            this.contraseniaTbx.Location = new System.Drawing.Point(12, 172);
            this.contraseniaTbx.Name = "contraseniaTbx";
            this.contraseniaTbx.Size = new System.Drawing.Size(206, 23);
            this.contraseniaTbx.TabIndex = 1;
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Location = new System.Drawing.Point(51, 223);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(123, 27);
            this.ingresarBtn.TabIndex = 2;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iniciar sesión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.contraseniaTbx);
            this.Controls.Add(this.usuarioTbx);
            this.Name = "Form1";
            this.Text = "Sorteo - Inicio de sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usuarioTbx;
        private TextBox contraseniaTbx;
        private Button ingresarBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}