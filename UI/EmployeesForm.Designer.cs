namespace UI
{
    partial class EmployeesForm
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPersonalId = new System.Windows.Forms.TextBox();
            this.txtGrossSalary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(30, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.PlaceholderText = "Apellido y Nombre";
            // 
            // txtPersonalId
            // 
            this.txtPersonalId.Location = new System.Drawing.Point(30, 70);
            this.txtPersonalId.Name = "txtPersonalId";
            this.txtPersonalId.Size = new System.Drawing.Size(200, 22);
            this.txtPersonalId.TabIndex = 1;
            this.txtPersonalId.PlaceholderText = "DNI (11 dígitos)";
            // 
            // txtGrossSalary
            // 
            this.txtGrossSalary.Location = new System.Drawing.Point(30, 110);
            this.txtGrossSalary.Name = "txtGrossSalary";
            this.txtGrossSalary.Size = new System.Drawing.Size(200, 22);
            this.txtGrossSalary.TabIndex = 2;
            this.txtGrossSalary.PlaceholderText = "Sueldo Bruto";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.Location = new System.Drawing.Point(120, 150);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(110, 30);
            this.btnConfirmChanges.TabIndex = 4;
            this.btnConfirmChanges.Text = "Confirmar";
            this.btnConfirmChanges.UseVisualStyleBackColor = true;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(240, 150);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 30);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "Listar";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(30, 200);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(400, 200);
            this.dgvEmployees.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 431);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnConfirmChanges);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGrossSalary);
            this.Controls.Add(this.txtPersonalId);
            this.Controls.Add(this.txtFullName);
            this.Name = "MainForm";
            this.Text = "Carga Masiva de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPersonalId;
        private System.Windows.Forms.TextBox txtGrossSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}
