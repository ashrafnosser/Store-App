
namespace linqentity
{
    partial class dialogeLanguage
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
            this.arabic = new System.Windows.Forms.Button();
            this.English = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rakkas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "which language do tou want";
            // 
            // arabic
            // 
            this.arabic.Location = new System.Drawing.Point(103, 155);
            this.arabic.Name = "arabic";
            this.arabic.Size = new System.Drawing.Size(75, 23);
            this.arabic.TabIndex = 1;
            this.arabic.Text = "Arabic";
            this.arabic.UseVisualStyleBackColor = true;
            this.arabic.Click += new System.EventHandler(this.arabic_Click);
            // 
            // English
            // 
            this.English.Location = new System.Drawing.Point(277, 155);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(75, 23);
            this.English.TabIndex = 2;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // dialogeLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 265);
            this.Controls.Add(this.English);
            this.Controls.Add(this.arabic);
            this.Controls.Add(this.label1);
            this.Name = "dialogeLanguage";
            this.Text = "dialogeLanguage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button arabic;
        private System.Windows.Forms.Button English;
    }
}