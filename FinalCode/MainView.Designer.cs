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
            this.txt_HouseholdName.TextChanged += new System.EventHandler(this.txt_HouseholdName_TextChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 599);
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
    }
}

