namespace PSS
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学员录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.手动录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学员筛查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单个筛查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量筛查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学员录入ToolStripMenuItem,
            this.学员筛查ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学员录入ToolStripMenuItem
            // 
            this.学员录入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.手动录入ToolStripMenuItem,
            this.批量导入ToolStripMenuItem});
            this.学员录入ToolStripMenuItem.Name = "学员录入ToolStripMenuItem";
            this.学员录入ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学员录入ToolStripMenuItem.Text = "学员录入";
            // 
            // 手动录入ToolStripMenuItem
            // 
            this.手动录入ToolStripMenuItem.Name = "手动录入ToolStripMenuItem";
            this.手动录入ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.手动录入ToolStripMenuItem.Text = "手动录入";
            // 
            // 批量导入ToolStripMenuItem
            // 
            this.批量导入ToolStripMenuItem.Name = "批量导入ToolStripMenuItem";
            this.批量导入ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.批量导入ToolStripMenuItem.Text = "批量导入";
            // 
            // 学员筛查ToolStripMenuItem
            // 
            this.学员筛查ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单个筛查ToolStripMenuItem,
            this.批量筛查ToolStripMenuItem});
            this.学员筛查ToolStripMenuItem.Name = "学员筛查ToolStripMenuItem";
            this.学员筛查ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学员筛查ToolStripMenuItem.Text = "学员筛查";
            // 
            // 单个筛查ToolStripMenuItem
            // 
            this.单个筛查ToolStripMenuItem.Name = "单个筛查ToolStripMenuItem";
            this.单个筛查ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.单个筛查ToolStripMenuItem.Text = "单个筛查";
            // 
            // 批量筛查ToolStripMenuItem
            // 
            this.批量筛查ToolStripMenuItem.Name = "批量筛查ToolStripMenuItem";
            this.批量筛查ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.批量筛查ToolStripMenuItem.Text = "批量筛查";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 326);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "主界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学员录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 手动录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学员筛查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单个筛查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量筛查ToolStripMenuItem;
    }
}

