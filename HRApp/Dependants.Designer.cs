
namespace HRApp
{
    partial class Dependants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dependants));
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDependants = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtRelationship = new System.Windows.Forms.TextBox();
            this.btnAddDependant = new System.Windows.Forms.Button();
            this.btnDeleteDependant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependants)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dependants of the Employee: ";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeName.Location = new System.Drawing.Point(236, 123);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(152, 21);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "lblEmployeeName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Human Resources App";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 84);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(733, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Employee Dependants";
            // 
            // dgvDependants
            // 
            this.dgvDependants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDependants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependants.Location = new System.Drawing.Point(28, 167);
            this.dgvDependants.Name = "dgvDependants";
            this.dgvDependants.ReadOnly = true;
            this.dgvDependants.RowTemplate.Height = 25;
            this.dgvDependants.Size = new System.Drawing.Size(518, 263);
            this.dgvDependants.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Relationship:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(656, 164);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(202, 23);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(656, 193);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(202, 23);
            this.txtLastName.TabIndex = 9;
            // 
            // txtRelationship
            // 
            this.txtRelationship.Location = new System.Drawing.Point(656, 222);
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.Size = new System.Drawing.Size(202, 23);
            this.txtRelationship.TabIndex = 10;
            // 
            // btnAddDependant
            // 
            this.btnAddDependant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDependant.Location = new System.Drawing.Point(575, 257);
            this.btnAddDependant.Name = "btnAddDependant";
            this.btnAddDependant.Size = new System.Drawing.Size(283, 23);
            this.btnAddDependant.TabIndex = 11;
            this.btnAddDependant.Text = "Add Dependant";
            this.btnAddDependant.UseVisualStyleBackColor = true;
            this.btnAddDependant.Click += new System.EventHandler(this.btnAddDependant_Click);
            // 
            // btnDeleteDependant
            // 
            this.btnDeleteDependant.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteDependant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDependant.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDependant.Location = new System.Drawing.Point(575, 407);
            this.btnDeleteDependant.Name = "btnDeleteDependant";
            this.btnDeleteDependant.Size = new System.Drawing.Size(283, 23);
            this.btnDeleteDependant.TabIndex = 12;
            this.btnDeleteDependant.Text = "Delete Selected Dependant";
            this.btnDeleteDependant.UseVisualStyleBackColor = false;
            // 
            // Dependants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(870, 459);
            this.Controls.Add(this.btnDeleteDependant);
            this.Controls.Add(this.btnAddDependant);
            this.Controls.Add(this.txtRelationship);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDependants);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.label1);
            this.Name = "Dependants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dependants";
            this.Load += new System.EventHandler(this.Dependants_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDependants;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtRelationship;
        private System.Windows.Forms.Button btnAddDependant;
        private System.Windows.Forms.Button btnDeleteDependant;
        private System.Windows.Forms.Label label6;
    }
}