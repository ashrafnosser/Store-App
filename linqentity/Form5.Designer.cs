
namespace linqentity
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.supplyId = new System.Windows.Forms.TextBox();
            this.varietiesQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.storeName = new System.Windows.Forms.ComboBox();
            this.permissionDate = new System.Windows.Forms.DateTimePicker();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.expiry = new System.Windows.Forms.TextBox();
            this.btAddP = new System.Windows.Forms.Button();
            this.variatiesName = new System.Windows.Forms.ComboBox();
            this.productionHistory = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // supplyId
            // 
            resources.ApplyResources(this.supplyId, "supplyId");
            this.supplyId.Name = "supplyId";
            // 
            // varietiesQuantity
            // 
            resources.ApplyResources(this.varietiesQuantity, "varietiesQuantity");
            this.varietiesQuantity.Name = "varietiesQuantity";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // storeName
            // 
            resources.ApplyResources(this.storeName, "storeName");
            this.storeName.FormattingEnabled = true;
            this.storeName.Name = "storeName";
            this.storeName.SelectedIndexChanged += new System.EventHandler(this.storeName_SelectedIndexChanged);
            // 
            // permissionDate
            // 
            resources.ApplyResources(this.permissionDate, "permissionDate");
            this.permissionDate.Name = "permissionDate";
            // 
            // supplierName
            // 
            resources.ApplyResources(this.supplierName, "supplierName");
            this.supplierName.Name = "supplierName";
            // 
            // expiry
            // 
            resources.ApplyResources(this.expiry, "expiry");
            this.expiry.Name = "expiry";
            // 
            // btAddP
            // 
            resources.ApplyResources(this.btAddP, "btAddP");
            this.btAddP.Name = "btAddP";
            this.btAddP.UseVisualStyleBackColor = true;
            this.btAddP.Click += new System.EventHandler(this.btAddP_Click);
            // 
            // variatiesName
            // 
            resources.ApplyResources(this.variatiesName, "variatiesName");
            this.variatiesName.FormattingEnabled = true;
            this.variatiesName.Name = "variatiesName";
            // 
            // productionHistory
            // 
            resources.ApplyResources(this.productionHistory, "productionHistory");
            this.productionHistory.Name = "productionHistory";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.productionHistory);
            this.Controls.Add(this.variatiesName);
            this.Controls.Add(this.btAddP);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.permissionDate);
            this.Controls.Add(this.storeName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.varietiesQuantity);
            this.Controls.Add(this.supplyId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplyId;
        private System.Windows.Forms.TextBox varietiesQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox storeName;
        private System.Windows.Forms.DateTimePicker permissionDate;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.TextBox expiry;
        private System.Windows.Forms.Button btAddP;
        private System.Windows.Forms.ComboBox variatiesName;
        private System.Windows.Forms.DateTimePicker productionHistory;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
    }
}