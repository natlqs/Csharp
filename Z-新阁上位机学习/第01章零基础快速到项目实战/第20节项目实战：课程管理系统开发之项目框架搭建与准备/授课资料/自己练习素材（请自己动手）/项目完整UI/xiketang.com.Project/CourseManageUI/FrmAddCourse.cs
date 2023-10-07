using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Drawing;

namespace CourseManageUI
{
    public partial class FrmAddCourse : Form
    {
        public FrmAddCourse()
        {
            InitializeComponent();


        }

        //保存到数据库
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {


        }

        #region 其他

        //添加行号
        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(this.dgvCourseList.RowHeadersDefaultCellStyle.ForeColor);
            int lineNo = e.RowIndex + 1;
            e.Graphics.DrawString(lineNo.ToString(), e.InheritedRowStyle.Font, solidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
