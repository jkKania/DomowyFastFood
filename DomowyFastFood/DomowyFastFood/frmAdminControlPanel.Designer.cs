namespace DomowyFastFood
{
    partial class frmAdminControlPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminControlPanel));
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.zamowienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domowyFastFoodDataSet = new DomowyFastFood.DomowyFastFoodDataSet();
            this.zamowienieTableAdapter = new DomowyFastFood.DomowyFastFoodDataSetTableAdapters.ZamowienieTableAdapter();
            this.btnDelOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 12);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(634, 190);
            this.dgvOrder.TabIndex = 0;
            // 
            // zamowienieBindingSource
            // 
            this.zamowienieBindingSource.DataMember = "Zamowienie";
            this.zamowienieBindingSource.DataSource = this.domowyFastFoodDataSet;
            // 
            // domowyFastFoodDataSet
            // 
            this.domowyFastFoodDataSet.DataSetName = "DomowyFastFoodDataSet";
            this.domowyFastFoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamowienieTableAdapter
            // 
            this.zamowienieTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelOrder.Location = new System.Drawing.Point(272, 239);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(115, 30);
            this.btnDelOrder.TabIndex = 1;
            this.btnDelOrder.Text = "Usun zamowienie";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // frmAdminControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 301);
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.dgvOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdminControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domowy Fast Food";
            this.Load += new System.EventHandler(this.frmAdminControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private DomowyFastFoodDataSet domowyFastFoodDataSet;
        private System.Windows.Forms.BindingSource zamowienieBindingSource;
        private DomowyFastFoodDataSetTableAdapters.ZamowienieTableAdapter zamowienieTableAdapter;
        private System.Windows.Forms.Button btnDelOrder;
    }
}