using System.IO.Ports;

namespace SerialPortTest
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerPort = new System.Windows.Forms.Timer(this.components);
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPort = new System.Windows.Forms.Button();
            this.textBoxRecebe = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEnvia = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerPort
            // 
            this.timerPort.Interval = 1000;
            this.timerPort.Tick += new System.EventHandler(this.timerPort_Tick);
            // 
            // SerialPort1
            // 
            this.SerialPort1.BaudRate = 115200;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btPort);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PORTA SERIAL";
            // 
            // btPort
            // 
            this.btPort.BackColor = System.Drawing.SystemColors.Control;
            this.btPort.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btPort.FlatAppearance.BorderSize = 2;
            this.btPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPort.Location = new System.Drawing.Point(6, 19);
            this.btPort.Name = "btPort";
            this.btPort.Size = new System.Drawing.Size(110, 39);
            this.btPort.TabIndex = 3;
            this.btPort.TabStop = false;
            this.btPort.Text = "Conectar";
            this.btPort.UseVisualStyleBackColor = false;
            this.btPort.Click += new System.EventHandler(this.btPort_Click);
            // 
            // textBoxRecebe
            // 
            this.textBoxRecebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecebe.Location = new System.Drawing.Point(8, 199);
            this.textBoxRecebe.Multiline = true;
            this.textBoxRecebe.Name = "textBoxRecebe";
            this.textBoxRecebe.ReadOnly = true;
            this.textBoxRecebe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecebe.Size = new System.Drawing.Size(660, 262);
            this.textBoxRecebe.TabIndex = 24;
            this.textBoxRecebe.TabStop = false;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.Control;
            this.btClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btClear.FlatAppearance.BorderSize = 2;
            this.btClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Location = new System.Drawing.Point(643, 168);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(25, 25);
            this.btClear.TabIndex = 25;
            this.btClear.TabStop = false;
            this.btClear.Text = "X";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.textBoxEnvia);
            this.groupBox2.Controls.Add(this.btEnviar);
            this.groupBox2.Location = new System.Drawing.Point(8, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 77);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMANDO";
            // 
            // textBoxEnvia
            // 
            this.textBoxEnvia.Location = new System.Drawing.Point(122, 29);
            this.textBoxEnvia.Name = "textBoxEnvia";
            this.textBoxEnvia.Size = new System.Drawing.Size(509, 20);
            this.textBoxEnvia.TabIndex = 4;
            // 
            // btEnviar
            // 
            this.btEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.btEnviar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btEnviar.FlatAppearance.BorderSize = 2;
            this.btEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviar.Location = new System.Drawing.Point(6, 19);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(110, 39);
            this.btEnviar.TabIndex = 3;
            this.btEnviar.TabStop = false;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = false;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.textBoxRecebe);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPort;
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPort;
        private System.Windows.Forms.TextBox textBoxRecebe;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxEnvia;
        private System.Windows.Forms.Button btEnviar;
    }
}

