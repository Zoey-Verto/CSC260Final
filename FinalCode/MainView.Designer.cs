namespace FinalCode {
	partial class MainView {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.label_MainHouseholdName = new System.Windows.Forms.Label();
            this.btn_MainAddPerson = new System.Windows.Forms.Button();
            this.txt_MainAddPersonName = new System.Windows.Forms.TextBox();
            this.table_MainPersonHolder = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label_MainHouseholdName
            // 
            this.label_MainHouseholdName.AutoSize = true;
            this.label_MainHouseholdName.Location = new System.Drawing.Point(12, 9);
            this.label_MainHouseholdName.Name = "label_MainHouseholdName";
            this.label_MainHouseholdName.Size = new System.Drawing.Size(89, 13);
            this.label_MainHouseholdName.TabIndex = 1;
            this.label_MainHouseholdName.Text = "Household Name";
            // 
            // btn_MainAddPerson
            // 
            this.btn_MainAddPerson.Location = new System.Drawing.Point(317, 52);
            this.btn_MainAddPerson.Name = "btn_MainAddPerson";
            this.btn_MainAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btn_MainAddPerson.TabIndex = 2;
            this.btn_MainAddPerson.Text = "Add Person";
            this.btn_MainAddPerson.UseVisualStyleBackColor = true;
            this.btn_MainAddPerson.Click += new System.EventHandler(this.btn_MainAddPerson_Click);
            // 
            // txt_MainAddPersonName
            // 
            this.txt_MainAddPersonName.Location = new System.Drawing.Point(305, 81);
            this.txt_MainAddPersonName.Name = "txt_MainAddPersonName";
            this.txt_MainAddPersonName.Size = new System.Drawing.Size(100, 20);
            this.txt_MainAddPersonName.TabIndex = 3;
            // 
            // table_MainPersonHolder
            // 
            this.table_MainPersonHolder.AutoScroll = true;
            this.table_MainPersonHolder.BackColor = System.Drawing.SystemColors.Control;
            this.table_MainPersonHolder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.table_MainPersonHolder.ColumnCount = 2;
            this.table_MainPersonHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_MainPersonHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_MainPersonHolder.Location = new System.Drawing.Point(15, 52);
            this.table_MainPersonHolder.Name = "table_MainPersonHolder";
            this.table_MainPersonHolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_MainPersonHolder.RowCount = 1;
            this.table_MainPersonHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_MainPersonHolder.Size = new System.Drawing.Size(284, 324);
            this.table_MainPersonHolder.TabIndex = 4;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 599);
            this.Controls.Add(this.table_MainPersonHolder);
            this.Controls.Add(this.txt_MainAddPersonName);
            this.Controls.Add(this.btn_MainAddPerson);
            this.Controls.Add(this.label_MainHouseholdName);
            this.Name = "MainView";
            this.Text = "Main View";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_MainHouseholdName;
        private System.Windows.Forms.Button btn_MainAddPerson;
        private System.Windows.Forms.TextBox txt_MainAddPersonName;
        private System.Windows.Forms.TableLayoutPanel table_MainPersonHolder;
    }
}

