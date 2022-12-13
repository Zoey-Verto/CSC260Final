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
            this.btn_MainAddPerson = new System.Windows.Forms.Button();
            this.txt_MainAddPersonName = new System.Windows.Forms.TextBox();
            this.panel_MainPersonHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_HouseholdName = new System.Windows.Forms.TextBox();
            this.label_TotalSpentLabel = new System.Windows.Forms.Label();
            this.label_TotalSpentNum = new System.Windows.Forms.Label();
            this.btn_BalPayments = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // panel_MainPersonHolder
            // 
            this.panel_MainPersonHolder.AutoScroll = true;
            this.panel_MainPersonHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_MainPersonHolder.Location = new System.Drawing.Point(15, 52);
            this.panel_MainPersonHolder.Name = "panel_MainPersonHolder";
            this.panel_MainPersonHolder.Size = new System.Drawing.Size(284, 314);
            this.panel_MainPersonHolder.TabIndex = 4;
            this.panel_MainPersonHolder.WrapContents = false;
            // 
            // txt_HouseholdName
            // 
            this.txt_HouseholdName.Location = new System.Drawing.Point(15, 12);
            this.txt_HouseholdName.Name = "txt_HouseholdName";
            this.txt_HouseholdName.Size = new System.Drawing.Size(130, 20);
            this.txt_HouseholdName.TabIndex = 5;
            this.txt_HouseholdName.Text = "Default Household";
            this.txt_HouseholdName.Leave += new System.EventHandler(this.txt_HouseholdName_TextChanged);
            // 
            // label_TotalSpentLabel
            // 
            this.label_TotalSpentLabel.AutoSize = true;
            this.label_TotalSpentLabel.Location = new System.Drawing.Point(170, 12);
            this.label_TotalSpentLabel.Name = "label_TotalSpentLabel";
            this.label_TotalSpentLabel.Size = new System.Drawing.Size(62, 13);
            this.label_TotalSpentLabel.TabIndex = 6;
            this.label_TotalSpentLabel.Text = "Total Spent";
            // 
            // label_TotalSpentNum
            // 
            this.label_TotalSpentNum.AutoSize = true;
            this.label_TotalSpentNum.Location = new System.Drawing.Point(170, 36);
            this.label_TotalSpentNum.Name = "label_TotalSpentNum";
            this.label_TotalSpentNum.Size = new System.Drawing.Size(13, 13);
            this.label_TotalSpentNum.TabIndex = 7;
            this.label_TotalSpentNum.Text = "0";
            // 
            // btn_BalPayments
            // 
            this.btn_BalPayments.Location = new System.Drawing.Point(15, 383);
            this.btn_BalPayments.Name = "btn_BalPayments";
            this.btn_BalPayments.Size = new System.Drawing.Size(111, 23);
            this.btn_BalPayments.TabIndex = 8;
            this.btn_BalPayments.Text = "Balance Payments";
            this.btn_BalPayments.UseVisualStyleBackColor = true;
            this.btn_BalPayments.Click += new System.EventHandler(this.btn_BalPayments_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 420);
            this.Controls.Add(this.btn_BalPayments);
            this.Controls.Add(this.label_TotalSpentNum);
            this.Controls.Add(this.label_TotalSpentLabel);
            this.Controls.Add(this.txt_HouseholdName);
            this.Controls.Add(this.panel_MainPersonHolder);
            this.Controls.Add(this.txt_MainAddPersonName);
            this.Controls.Add(this.btn_MainAddPerson);
            this.Name = "MainView";
            this.Text = "Main View";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Button btn_MainAddPerson;
        private System.Windows.Forms.TextBox txt_MainAddPersonName;
        private System.Windows.Forms.FlowLayoutPanel panel_MainPersonHolder;
        private System.Windows.Forms.TextBox txt_HouseholdName;
        private System.Windows.Forms.Label label_TotalSpentLabel;
        private System.Windows.Forms.Label label_TotalSpentNum;
        private System.Windows.Forms.Button btn_BalPayments;
    }
}

