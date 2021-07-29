
namespace DataDashboard
{
    partial class Form1
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
            this.stationDatagrid = new System.Windows.Forms.DataGridView();
            this.stationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthToWaterLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUnload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stationDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stationDatagrid
            // 
            this.stationDatagrid.AutoGenerateColumns = false;
            this.stationDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationName,
            this.screenId,
            this.date,
            this.depthToWaterLevel,
            this.comment});
            this.stationDatagrid.DataSource = this.stationDataBindingSource;
            this.stationDatagrid.Location = new System.Drawing.Point(42, 185);
            this.stationDatagrid.Name = "stationDatagrid";
            this.stationDatagrid.Size = new System.Drawing.Size(547, 172);
            this.stationDatagrid.TabIndex = 0;
            this.stationDatagrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.stationDatagrid_DataError);
            // 
            // stationName
            // 
            this.stationName.DataPropertyName = "StationName";
            this.stationName.HeaderText = "StationName";
            this.stationName.Name = "stationName";
            // 
            // screenId
            // 
            this.screenId.DataPropertyName = "screen_id";
            this.screenId.HeaderText = "screen_id";
            this.screenId.Name = "screenId";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // depthToWaterLevel
            // 
            this.depthToWaterLevel.DataPropertyName = "depth_to_water_level";
            this.depthToWaterLevel.HeaderText = "depth_to_water_level";
            this.depthToWaterLevel.Name = "depthToWaterLevel";
            // 
            // comment
            // 
            this.comment.DataPropertyName = "comment";
            this.comment.HeaderText = "comment";
            this.comment.Name = "comment";
            // 
            // stationDataBindingSource
            // 
            this.stationDataBindingSource.DataSource = typeof(DataDashboard.StationData);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(613, 224);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load CSV File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(613, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.deleteRow);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(42, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(547, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(42, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(42, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(547, 20);
            this.textBox2.TabIndex = 8;
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(613, 319);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(75, 23);
            this.btnUnload.TabIndex = 9;
            this.btnUnload.Text = "Unload CSV";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUnload_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnload);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.stationDatagrid);
            this.Name = "Form1";
            this.Text = "Add, Edit and Delete Data";
            ((System.ComponentModel.ISupportInitialize)(this.stationDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stationDatagrid;
        private System.Windows.Forms.BindingSource stationDataBindingSource;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn screenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthToWaterLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnUnload;
    }
}

