
namespace Examen_Empresa.Vista
{
    partial class TicketView
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.TicketDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(117, 107);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(200, 26);
            this.NombreTextBox.TabIndex = 2;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(467, 61);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.FechaDateTimePicker.TabIndex = 5;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(117, 58);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(200, 26);
            this.IdTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TipoComboBox);
            this.groupBox2.Location = new System.Drawing.Point(24, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 114);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de soporte";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.EstadoComboBox);
            this.groupBox3.Location = new System.Drawing.Point(24, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(743, 104);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado del ticket";
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.Enabled = false;
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Location = new System.Drawing.Point(174, 49);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(200, 28);
            this.TipoComboBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de soporte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado del Ticket";
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.Enabled = false;
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Location = new System.Drawing.Point(174, 47);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(200, 28);
            this.EstadoComboBox.TabIndex = 9;
            // 
            // TicketDataGridView
            // 
            this.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDataGridView.Location = new System.Drawing.Point(24, 466);
            this.TicketDataGridView.Name = "TicketDataGridView";
            this.TicketDataGridView.RowHeadersWidth = 62;
            this.TicketDataGridView.RowTemplate.Height = 28;
            this.TicketDataGridView.Size = new System.Drawing.Size(743, 123);
            this.TicketDataGridView.TabIndex = 11;
            this.TicketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDataGridView_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CancelarButton);
            this.groupBox4.Controls.Add(this.NuevoButton);
            this.groupBox4.Controls.Add(this.EliminarButton);
            this.groupBox4.Controls.Add(this.ModificarButton);
            this.groupBox4.Controls.Add(this.GuardarButton);
            this.groupBox4.Location = new System.Drawing.Point(24, 624);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(743, 89);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Botones";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(476, 39);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(90, 29);
            this.CancelarButton.TabIndex = 16;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(92, 39);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(90, 29);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(380, 39);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(90, 29);
            this.EliminarButton.TabIndex = 14;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(188, 39);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(90, 29);
            this.ModificarButton.TabIndex = 13;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Location = new System.Drawing.Point(284, 39);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(90, 29);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 736);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.TicketDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TicketView";
            this.Text = "Tickets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.Button NuevoButton;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button ModificarButton;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox TipoComboBox;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox EstadoComboBox;
        public System.Windows.Forms.DataGridView TicketDataGridView;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NombreTextBox;
        public System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}