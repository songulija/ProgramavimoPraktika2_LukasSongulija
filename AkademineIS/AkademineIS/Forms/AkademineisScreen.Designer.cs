namespace AkademineIS.Forms
{
    partial class AkademineisScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.DisplayMarks = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Studentas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(345, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "AKADEMINE SISTEMA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 310);
            this.dataGridView1.TabIndex = 2;
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StudentNameLabel.Location = new System.Drawing.Point(105, 43);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(51, 20);
            this.StudentNameLabel.TabIndex = 3;
            this.StudentNameLabel.Text = "label3";
            // 
            // DisplayMarks
            // 
            this.DisplayMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DisplayMarks.Location = new System.Drawing.Point(16, 383);
            this.DisplayMarks.Name = "DisplayMarks";
            this.DisplayMarks.Size = new System.Drawing.Size(166, 42);
            this.DisplayMarks.TabIndex = 4;
            this.DisplayMarks.Text = "Display Marks";
            this.DisplayMarks.UseVisualStyleBackColor = true;
            this.DisplayMarks.Click += new System.EventHandler(this.DisplayMarks_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogoutButton.Location = new System.Drawing.Point(771, 18);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(125, 38);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AkademineisScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 464);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.DisplayMarks);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AkademineisScreen";
            this.Text = "AkademineisScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Button DisplayMarks;
        private System.Windows.Forms.Button LogoutButton;
    }
}