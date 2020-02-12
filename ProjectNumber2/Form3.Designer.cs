namespace ProjectNumber2
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._5th_Year_StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this._5th_Year_StudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new ProjectNumber2.Database1DataSet();
            this._5th_Year_StudentsTableAdapter = new ProjectNumber2.Database1DataSetTableAdapters._5th_Year_StudentsTableAdapter();
            this.tableAdapterManager = new ProjectNumber2.Database1DataSetTableAdapters.TableAdapterManager();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._5th_Year_StudentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._5th_Year_StudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _5th_Year_StudentsDataGridView
            // 
            this._5th_Year_StudentsDataGridView.AllowUserToAddRows = false;
            this._5th_Year_StudentsDataGridView.AllowUserToDeleteRows = false;
            this._5th_Year_StudentsDataGridView.AutoGenerateColumns = false;
            this._5th_Year_StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._5th_Year_StudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this._5th_Year_StudentsDataGridView.DataSource = this._5th_Year_StudentsBindingSource;
            this._5th_Year_StudentsDataGridView.Location = new System.Drawing.Point(271, 12);
            this._5th_Year_StudentsDataGridView.Name = "_5th_Year_StudentsDataGridView";
            this._5th_Year_StudentsDataGridView.ReadOnly = true;
            this._5th_Year_StudentsDataGridView.RowHeadersVisible = false;
            this._5th_Year_StudentsDataGridView.Size = new System.Drawing.Size(203, 476);
            this._5th_Year_StudentsDataGridView.TabIndex = 2;
            // 
            // _5th_Year_StudentsBindingSource
            // 
            this._5th_Year_StudentsBindingSource.DataMember = "5th_Year_Students";
            this._5th_Year_StudentsBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _5th_Year_StudentsTableAdapter
            // 
            this._5th_Year_StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._5th_Year_StudentsTableAdapter = this._5th_Year_StudentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ProjectNumber2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this._5th_Year_StudentsDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._5th_Year_StudentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._5th_Year_StudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource _5th_Year_StudentsBindingSource;
        private Database1DataSetTableAdapters._5th_Year_StudentsTableAdapter _5th_Year_StudentsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView _5th_Year_StudentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}