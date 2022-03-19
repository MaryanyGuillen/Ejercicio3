namespace Ejercicio3
{
    partial class frmUsuariosRegistrados
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
            this.UsuariosRegistradosDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosRegistradosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosRegistradosDataGridView
            // 
            this.UsuariosRegistradosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosRegistradosDataGridView.Location = new System.Drawing.Point(22, 41);
            this.UsuariosRegistradosDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsuariosRegistradosDataGridView.Name = "UsuariosRegistradosDataGridView";
            this.UsuariosRegistradosDataGridView.Size = new System.Drawing.Size(613, 298);
            this.UsuariosRegistradosDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios registrados en la base de datos";
            // 
            // frmUsuariosRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuariosRegistradosDataGridView);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUsuariosRegistrados";
            this.Text = "frmUsuariosRegistrados";
            this.Load += new System.EventHandler(this.frmUsuariosRegistrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosRegistradosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsuariosRegistradosDataGridView;
        private System.Windows.Forms.Label label1;
    }
}