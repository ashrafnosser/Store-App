
namespace linqentity
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transformId = new System.Windows.Forms.TextBox();
            this.supplier = new System.Windows.Forms.TextBox();
            this.expiry = new System.Windows.Forms.TextBox();
            this.fromStore = new System.Windows.Forms.ComboBox();
            this.toStore = new System.Windows.Forms.ComboBox();
            this.varieties = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pHistory = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // transformId
            // 
            resources.ApplyResources(this.transformId, "transformId");
            this.transformId.Name = "transformId";
            // 
            // supplier
            // 
            resources.ApplyResources(this.supplier, "supplier");
            this.supplier.Name = "supplier";
            // 
            // expiry
            // 
            resources.ApplyResources(this.expiry, "expiry");
            this.expiry.Name = "expiry";
            // 
            // fromStore
            // 
            resources.ApplyResources(this.fromStore, "fromStore");
            this.fromStore.FormattingEnabled = true;
            this.fromStore.Name = "fromStore";
            this.fromStore.SelectedIndexChanged += new System.EventHandler(this.from_SelectedIndexChanged);
            // 
            // toStore
            // 
            resources.ApplyResources(this.toStore, "toStore");
            this.toStore.FormattingEnabled = true;
            this.toStore.Name = "toStore";
            // 
            // varieties
            // 
            resources.ApplyResources(this.varieties, "varieties");
            this.varieties.FormattingEnabled = true;
            this.varieties.Name = "varieties";
            // 
            // Add
            // 
            resources.ApplyResources(this.Add, "Add");
            this.Add.Name = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // quantity
            // 
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // pHistory
            // 
            resources.ApplyResources(this.pHistory, "pHistory");
            this.pHistory.Name = "pHistory";
            // 
            // Form7
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pHistory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.varieties);
            this.Controls.Add(this.toStore);
            this.Controls.Add(this.fromStore);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.transformId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox transformId;
        private System.Windows.Forms.TextBox supplier;
        private System.Windows.Forms.TextBox expiry;
        private System.Windows.Forms.ComboBox fromStore;
        private System.Windows.Forms.ComboBox toStore;
        private System.Windows.Forms.ComboBox varieties;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker pHistory;
    }
}