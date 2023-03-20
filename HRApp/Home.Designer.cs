
namespace HRApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.ddlDepartments = new System.Windows.Forms.ComboBox();
            this.txtFilterEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewDependants = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(219, 100);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowTemplate.Height = 25;
            this.dgvEmployees.Size = new System.Drawing.Size(639, 306);
            this.dgvEmployees.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 84);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(794, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Employees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Human Resources App";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.ddlDepartments);
            this.groupBox1.Controls.Add(this.txtFilterEmployeeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(119, 275);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(7, 275);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ddlDepartments
            // 
            this.ddlDepartments.FormattingEnabled = true;
            this.ddlDepartments.Location = new System.Drawing.Point(7, 108);
            this.ddlDepartments.Name = "ddlDepartments";
            this.ddlDepartments.Size = new System.Drawing.Size(187, 23);
            this.ddlDepartments.TabIndex = 4;
            // 
            // txtFilterEmployeeID
            // 
            this.txtFilterEmployeeID.Location = new System.Drawing.Point(7, 52);
            this.txtFilterEmployeeID.Name = "txtFilterEmployeeID";
            this.txtFilterEmployeeID.Size = new System.Drawing.Size(187, 23);
            this.txtFilterEmployeeID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Or, by Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "By employee ID:";
            // 
            // btnViewDependants
            // 
            this.btnViewDependants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDependants.Location = new System.Drawing.Point(705, 415);
            this.btnViewDependants.Name = "btnViewDependants";
            this.btnViewDependants.Size = new System.Drawing.Size(153, 23);
            this.btnViewDependants.TabIndex = 3;
            this.btnViewDependants.Text = "View Dependants";
            this.btnViewDependants.UseVisualStyleBackColor = true;
            this.btnViewDependants.Click += new System.EventHandler(this.btnViewDependants_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.btnViewDependants);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox ddlDepartments;
        private System.Windows.Forms.TextBox txtFilterEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewDependants;
        private System.Windows.Forms.Label label5;
    }
}