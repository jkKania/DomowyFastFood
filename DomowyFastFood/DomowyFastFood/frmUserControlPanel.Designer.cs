namespace DomowyFastFood
{
    partial class frmUserControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserControlPanel));
            this.dgvRestaurant = new System.Windows.Forms.DataGridView();
            this.restauracjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domowyFastFoodDataSet1 = new DomowyFastFood.DomowyFastFoodDataSet1();
            this.restauracjaTableAdapter = new DomowyFastFood.DomowyFastFoodDataSet1TableAdapters.RestauracjaTableAdapter();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.lblSyncTitle = new System.Windows.Forms.Label();
            this.lblSyncInfo = new System.Windows.Forms.Label();
            this.domowyFastFoodDataSet2 = new DomowyFastFood.DomowyFastFoodDataSet2();
            this.restauracjaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restauracjaTableAdapter1 = new DomowyFastFood.DomowyFastFoodDataSet2TableAdapters.RestauracjaTableAdapter();
            this.domowyFastFoodDataSet3 = new DomowyFastFood.DomowyFastFoodDataSet3();
            this.restauracjaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.restauracjaTableAdapter2 = new DomowyFastFood.DomowyFastFoodDataSet3TableAdapters.RestauracjaTableAdapter();
            this.iDRestauracjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaRestauracjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danieDniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRestaurant
            // 
            this.dgvRestaurant.AllowUserToAddRows = false;
            this.dgvRestaurant.AllowUserToDeleteRows = false;
            this.dgvRestaurant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRestaurant.AutoGenerateColumns = false;
            this.dgvRestaurant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRestauracjiDataGridViewTextBoxColumn,
            this.nazwaRestauracjiDataGridViewTextBoxColumn,
            this.danieDniaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dgvRestaurant.DataSource = this.restauracjaBindingSource2;
            this.dgvRestaurant.Location = new System.Drawing.Point(12, 12);
            this.dgvRestaurant.Name = "dgvRestaurant";
            this.dgvRestaurant.ReadOnly = true;
            this.dgvRestaurant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRestaurant.Size = new System.Drawing.Size(682, 271);
            this.dgvRestaurant.TabIndex = 0;
            // 
            // restauracjaBindingSource
            // 
            this.restauracjaBindingSource.DataMember = "Restauracja";
            this.restauracjaBindingSource.DataSource = this.domowyFastFoodDataSet1;
            // 
            // domowyFastFoodDataSet1
            // 
            this.domowyFastFoodDataSet1.DataSetName = "DomowyFastFoodDataSet1";
            this.domowyFastFoodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauracjaTableAdapter
            // 
            this.restauracjaTableAdapter.ClearBeforeFill = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrder.Location = new System.Drawing.Point(619, 318);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Zamów!";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSync
            // 
            this.btnSync.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSync.Location = new System.Drawing.Point(495, 318);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(94, 23);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Synchronizuj";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // lblSyncTitle
            // 
            this.lblSyncTitle.AutoSize = true;
            this.lblSyncTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSyncTitle.Location = new System.Drawing.Point(12, 318);
            this.lblSyncTitle.Name = "lblSyncTitle";
            this.lblSyncTitle.Size = new System.Drawing.Size(139, 15);
            this.lblSyncTitle.TabIndex = 3;
            this.lblSyncTitle.Text = "Ostatnia Synchronizacja:";
            // 
            // lblSyncInfo
            // 
            this.lblSyncInfo.AutoSize = true;
            this.lblSyncInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSyncInfo.Location = new System.Drawing.Point(160, 318);
            this.lblSyncInfo.Name = "lblSyncInfo";
            this.lblSyncInfo.Size = new System.Drawing.Size(11, 15);
            this.lblSyncInfo.TabIndex = 4;
            this.lblSyncInfo.Text = "-";
            // 
            // domowyFastFoodDataSet2
            // 
            this.domowyFastFoodDataSet2.DataSetName = "DomowyFastFoodDataSet2";
            this.domowyFastFoodDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauracjaBindingSource1
            // 
            this.restauracjaBindingSource1.DataMember = "Restauracja";
            this.restauracjaBindingSource1.DataSource = this.domowyFastFoodDataSet2;
            // 
            // restauracjaTableAdapter1
            // 
            this.restauracjaTableAdapter1.ClearBeforeFill = true;
            // 
            // domowyFastFoodDataSet3
            // 
            this.domowyFastFoodDataSet3.DataSetName = "DomowyFastFoodDataSet3";
            this.domowyFastFoodDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauracjaBindingSource2
            // 
            this.restauracjaBindingSource2.DataMember = "Restauracja";
            this.restauracjaBindingSource2.DataSource = this.domowyFastFoodDataSet3;
            // 
            // restauracjaTableAdapter2
            // 
            this.restauracjaTableAdapter2.ClearBeforeFill = true;
            // 
            // iDRestauracjiDataGridViewTextBoxColumn
            // 
            this.iDRestauracjiDataGridViewTextBoxColumn.DataPropertyName = "ID_Restauracji";
            this.iDRestauracjiDataGridViewTextBoxColumn.HeaderText = "ID_Restauracji";
            this.iDRestauracjiDataGridViewTextBoxColumn.Name = "iDRestauracjiDataGridViewTextBoxColumn";
            this.iDRestauracjiDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRestauracjiDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaRestauracjiDataGridViewTextBoxColumn
            // 
            this.nazwaRestauracjiDataGridViewTextBoxColumn.DataPropertyName = "NazwaRestauracji";
            this.nazwaRestauracjiDataGridViewTextBoxColumn.HeaderText = "NazwaRestauracji";
            this.nazwaRestauracjiDataGridViewTextBoxColumn.Name = "nazwaRestauracjiDataGridViewTextBoxColumn";
            this.nazwaRestauracjiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danieDniaDataGridViewTextBoxColumn
            // 
            this.danieDniaDataGridViewTextBoxColumn.DataPropertyName = "DanieDnia";
            this.danieDniaDataGridViewTextBoxColumn.HeaderText = "DanieDnia";
            this.danieDniaDataGridViewTextBoxColumn.Name = "danieDniaDataGridViewTextBoxColumn";
            this.danieDniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmUserControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 363);
            this.Controls.Add(this.lblSyncInfo);
            this.Controls.Add(this.lblSyncTitle);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dgvRestaurant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUserControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domowy Fast Food";
            this.Load += new System.EventHandler(this.UserControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRestaurant;
        private DomowyFastFoodDataSet1 domowyFastFoodDataSet1;
        private System.Windows.Forms.BindingSource restauracjaBindingSource;
        private DomowyFastFoodDataSet1TableAdapters.RestauracjaTableAdapter restauracjaTableAdapter;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label lblSyncTitle;
        private System.Windows.Forms.Label lblSyncInfo;
        private DomowyFastFoodDataSet2 domowyFastFoodDataSet2;
        private System.Windows.Forms.BindingSource restauracjaBindingSource1;
        private DomowyFastFoodDataSet2TableAdapters.RestauracjaTableAdapter restauracjaTableAdapter1;
        private DomowyFastFoodDataSet3 domowyFastFoodDataSet3;
        private System.Windows.Forms.BindingSource restauracjaBindingSource2;
        private DomowyFastFoodDataSet3TableAdapters.RestauracjaTableAdapter restauracjaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRestauracjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaRestauracjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danieDniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}