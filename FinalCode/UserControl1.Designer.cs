namespace FinalCode
{
    partial class uc_PersonPayTotal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_PersonName = new System.Windows.Forms.Label();
            this.label_TotalPaid = new System.Windows.Forms.Label();
            this.txt_Payment = new System.Windows.Forms.TextBox();
            this.btn_AddToTotal = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_PersonName
            // 
            this.label_PersonName.AutoSize = true;
            this.label_PersonName.Location = new System.Drawing.Point(3, 9);
            this.label_PersonName.Name = "label_PersonName";
            this.label_PersonName.Size = new System.Drawing.Size(72, 13);
            this.label_PersonName.TabIndex = 0;
            this.label_PersonName.Text = "Default Name";
            // 
            // label_TotalPaid
            // 
            this.label_TotalPaid.AutoSize = true;
            this.label_TotalPaid.Location = new System.Drawing.Point(104, 9);
            this.label_TotalPaid.Name = "label_TotalPaid";
            this.label_TotalPaid.Size = new System.Drawing.Size(13, 13);
            this.label_TotalPaid.TabIndex = 1;
            this.label_TotalPaid.Text = "0";
            // 
            // txt_Payment
            // 
            this.txt_Payment.Location = new System.Drawing.Point(168, 32);
            this.txt_Payment.Name = "txt_Payment";
            this.txt_Payment.Size = new System.Drawing.Size(75, 20);
            this.txt_Payment.TabIndex = 2;
            // 
            // btn_AddToTotal
            // 
            this.btn_AddToTotal.Location = new System.Drawing.Point(168, 3);
            this.btn_AddToTotal.Name = "btn_AddToTotal";
            this.btn_AddToTotal.Size = new System.Drawing.Size(75, 23);
            this.btn_AddToTotal.TabIndex = 3;
            this.btn_AddToTotal.Text = "Add to Total";
            this.btn_AddToTotal.UseVisualStyleBackColor = true;
            this.btn_AddToTotal.Click += new System.EventHandler(this.btn_AddToTotal_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(3, 35);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // uc_PersonPayTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_AddToTotal);
            this.Controls.Add(this.txt_Payment);
            this.Controls.Add(this.label_TotalPaid);
            this.Controls.Add(this.label_PersonName);
            this.Name = "uc_PersonPayTotal";
            this.Size = new System.Drawing.Size(253, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PersonName;
        private System.Windows.Forms.Label label_TotalPaid;
        private System.Windows.Forms.TextBox txt_Payment;
        private System.Windows.Forms.Button btn_AddToTotal;
        private System.Windows.Forms.Button btn_Delete;
    }
}
