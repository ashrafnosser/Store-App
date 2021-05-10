
namespace linqentity
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.update = new System.Windows.Forms.Button();
            this.productionHistory = new System.Windows.Forms.DateTimePicker();
            this.variatiesName = new System.Windows.Forms.ComboBox();
            this.btAddP = new System.Windows.Forms.Button();
            this.expiry = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.permissionDate = new System.Windows.Forms.DateTimePicker();
            this.storeName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.varietiesQuantity = new System.Windows.Forms.TextBox();
            this.dissmalId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            resources.ApplyResources(this.update, "update");
            this.update.Name = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // productionHistory
            // 
            resources.ApplyResources(this.productionHistory, "productionHistory");
            this.productionHistory.Name = "productionHistory";
            // 
            // variatiesName
            // 
            resources.ApplyResources(this.variatiesName, "variatiesName");
            this.variatiesName.FormattingEnabled = true;
            this.variatiesName.Name = "variatiesName";
            // 
            // btAddP
            // 
            resources.ApplyResources(this.btAddP, "btAddP");
            this.btAddP.Name = "btAddP";
            this.btAddP.UseVisualStyleBackColor = true;
            this.btAddP.Click += new System.EventHandler(this.btAddP_Click);
            // 
            // expiry
            // 
            resources.ApplyResources(this.expiry, "expiry");
            this.expiry.Name = "expiry";
            // 
            // customerName
            // 
            resources.ApplyResources(this.customerName, "customerName");
            this.customerName.Name = "customerName";
            // 
            // permissionDate
            // 
            resources.ApplyResources(this.permissionDate, "permissionDate");
            this.permissionDate.Name = "permissionDate";
            // 
            // storeName
            // 
            resources.ApplyResources(this.storeName, "storeName");
            this.storeName.FormattingEnabled = true;
            this.storeName.Name = "storeName";
            this.storeName.SelectedIndexChanged += new System.EventHandler(this.storeName_SelectedIndexChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // varietiesQuantity
            // 
            resources.ApplyResources(this.varietiesQuantity, "varietiesQuantity");
            this.varietiesQuantity.Name = "varietiesQuantity";
            // 
            // dissmalId
            // 
            resources.ApplyResources(this.dissmalId, "dissmalId");
            this.dissmalId.Name = "dissmalId";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            // 
            // dataGridView2
            // 
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Name = "dataGridView2";
            // 
            // Form6
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.productionHistory);
            this.Controls.Add(this.variatiesName);
            this.Controls.Add(this.btAddP);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.permissionDate);
            this.Controls.Add(this.storeName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.varietiesQuantity);
            this.Controls.Add(this.dissmalId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DateTimePicker productionHistory;
        private System.Windows.Forms.ComboBox variatiesName;
        private System.Windows.Forms.Button btAddP;
        private System.Windows.Forms.TextBox expiry;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.DateTimePicker permissionDate;
        private System.Windows.Forms.ComboBox storeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox varietiesQuantity;
        private System.Windows.Forms.TextBox dissmalId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}