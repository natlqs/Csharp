namespace xiketang.com.ListDataShow
{
    partial class FrmDgvList
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCourseList = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnCourseIdDESC = new System.Windows.Forms.Button();
            this.btnClassHourASC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourseList
            // 
            this.dgvCourseList.AllowUserToAddRows = false;
            this.dgvCourseList.AllowUserToDeleteRows = false;
            this.dgvCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseList.Location = new System.Drawing.Point(12, 12);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.ReadOnly = true;
            this.dgvCourseList.RowTemplate.Height = 23;
            this.dgvCourseList.Size = new System.Drawing.Size(617, 314);
            this.dgvCourseList.TabIndex = 0;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(13, 344);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(137, 40);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "展示数据";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnCourseIdDESC
            // 
            this.btnCourseIdDESC.Location = new System.Drawing.Point(185, 344);
            this.btnCourseIdDESC.Name = "btnCourseIdDESC";
            this.btnCourseIdDESC.Size = new System.Drawing.Size(105, 40);
            this.btnCourseIdDESC.TabIndex = 2;
            this.btnCourseIdDESC.Text = "编号降序";
            this.btnCourseIdDESC.UseVisualStyleBackColor = true;
            this.btnCourseIdDESC.Click += new System.EventHandler(this.btnCourseIdDESC_Click);
            // 
            // btnClassHourASC
            // 
            this.btnClassHourASC.Location = new System.Drawing.Point(311, 344);
            this.btnClassHourASC.Name = "btnClassHourASC";
            this.btnClassHourASC.Size = new System.Drawing.Size(105, 40);
            this.btnClassHourASC.TabIndex = 2;
            this.btnClassHourASC.Text = "课时升序";
            this.btnClassHourASC.UseVisualStyleBackColor = true;
            this.btnClassHourASC.Click += new System.EventHandler(this.btnClassHourASC_Click);
            // 
            // FrmDgvList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 396);
            this.Controls.Add(this.btnClassHourASC);
            this.Controls.Add(this.btnCourseIdDESC);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.dgvCourseList);
            this.Name = "FrmDgvList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List泛型集合做数据源";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnCourseIdDESC;
        private System.Windows.Forms.Button btnClassHourASC;
    }
}

