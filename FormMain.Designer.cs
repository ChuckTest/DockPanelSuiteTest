namespace WindowsFormsApplication1
{
    partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin3 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
			WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin3 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient7 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient15 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient16 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient8 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient17 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient18 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient19 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient9 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient20 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient21 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.documentStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dockingMdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dockingWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dockingSdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.systemMdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.documentStyleToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(826, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 21);
			this.toolStripMenuItem1.Text = "菜单一";
			// 
			// documentStyleToolStripMenuItem
			// 
			this.documentStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dockingMdiToolStripMenuItem,
            this.dockingWindowToolStripMenuItem,
            this.dockingSdiToolStripMenuItem,
            this.systemMdiToolStripMenuItem});
			this.documentStyleToolStripMenuItem.Name = "documentStyleToolStripMenuItem";
			this.documentStyleToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
			this.documentStyleToolStripMenuItem.Text = "DocumentStyle";
			// 
			// dockingMdiToolStripMenuItem
			// 
			this.dockingMdiToolStripMenuItem.Checked = true;
			this.dockingMdiToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.dockingMdiToolStripMenuItem.Name = "dockingMdiToolStripMenuItem";
			this.dockingMdiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.dockingMdiToolStripMenuItem.Text = "DockingMdi";
			this.dockingMdiToolStripMenuItem.Click += new System.EventHandler(this.SetDocumentStyle);
			// 
			// dockingWindowToolStripMenuItem
			// 
			this.dockingWindowToolStripMenuItem.Name = "dockingWindowToolStripMenuItem";
			this.dockingWindowToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.dockingWindowToolStripMenuItem.Text = "DockingWindow";
			this.dockingWindowToolStripMenuItem.Click += new System.EventHandler(this.SetDocumentStyle);
			// 
			// dockingSdiToolStripMenuItem
			// 
			this.dockingSdiToolStripMenuItem.Name = "dockingSdiToolStripMenuItem";
			this.dockingSdiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.dockingSdiToolStripMenuItem.Text = "DockingSdi";
			this.dockingSdiToolStripMenuItem.Click += new System.EventHandler(this.SetDocumentStyle);
			// 
			// systemMdiToolStripMenuItem
			// 
			this.systemMdiToolStripMenuItem.Name = "systemMdiToolStripMenuItem";
			this.systemMdiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.systemMdiToolStripMenuItem.Text = "SystemMdi";
			this.systemMdiToolStripMenuItem.Click += new System.EventHandler(this.SetDocumentStyle);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 25);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(826, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
			this.toolStripButton1.Text = "测试";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 522);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(826, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// dockPanel1
			// 
			this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dockPanel1.Location = new System.Drawing.Point(0, 50);
			this.dockPanel1.Name = "dockPanel1";
			this.dockPanel1.RightToLeftLayout = true;
			this.dockPanel1.Size = new System.Drawing.Size(826, 472);
			dockPanelGradient7.EndColor = System.Drawing.SystemColors.ControlLight;
			dockPanelGradient7.StartColor = System.Drawing.SystemColors.ControlLight;
			autoHideStripSkin3.DockStripGradient = dockPanelGradient7;
			tabGradient15.EndColor = System.Drawing.SystemColors.Control;
			tabGradient15.StartColor = System.Drawing.SystemColors.Control;
			tabGradient15.TextColor = System.Drawing.SystemColors.ControlDarkDark;
			autoHideStripSkin3.TabGradient = tabGradient15;
			autoHideStripSkin3.TextFont = new System.Drawing.Font("Microsoft YaHei", 9F);
			dockPanelSkin3.AutoHideStripSkin = autoHideStripSkin3;
			tabGradient16.EndColor = System.Drawing.SystemColors.ControlLightLight;
			tabGradient16.StartColor = System.Drawing.SystemColors.ControlLightLight;
			tabGradient16.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient3.ActiveTabGradient = tabGradient16;
			dockPanelGradient8.EndColor = System.Drawing.SystemColors.Control;
			dockPanelGradient8.StartColor = System.Drawing.SystemColors.Control;
			dockPaneStripGradient3.DockStripGradient = dockPanelGradient8;
			tabGradient17.EndColor = System.Drawing.SystemColors.ControlLight;
			tabGradient17.StartColor = System.Drawing.SystemColors.ControlLight;
			tabGradient17.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient3.InactiveTabGradient = tabGradient17;
			dockPaneStripSkin3.DocumentGradient = dockPaneStripGradient3;
			dockPaneStripSkin3.TextFont = new System.Drawing.Font("Microsoft YaHei", 9F);
			tabGradient18.EndColor = System.Drawing.SystemColors.ActiveCaption;
			tabGradient18.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient18.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
			tabGradient18.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
			dockPaneStripToolWindowGradient3.ActiveCaptionGradient = tabGradient18;
			tabGradient19.EndColor = System.Drawing.SystemColors.Control;
			tabGradient19.StartColor = System.Drawing.SystemColors.Control;
			tabGradient19.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripToolWindowGradient3.ActiveTabGradient = tabGradient19;
			dockPanelGradient9.EndColor = System.Drawing.SystemColors.ControlLight;
			dockPanelGradient9.StartColor = System.Drawing.SystemColors.ControlLight;
			dockPaneStripToolWindowGradient3.DockStripGradient = dockPanelGradient9;
			tabGradient20.EndColor = System.Drawing.SystemColors.InactiveCaption;
			tabGradient20.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient20.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
			tabGradient20.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
			dockPaneStripToolWindowGradient3.InactiveCaptionGradient = tabGradient20;
			tabGradient21.EndColor = System.Drawing.Color.Transparent;
			tabGradient21.StartColor = System.Drawing.Color.Transparent;
			tabGradient21.TextColor = System.Drawing.SystemColors.ControlDarkDark;
			dockPaneStripToolWindowGradient3.InactiveTabGradient = tabGradient21;
			dockPaneStripSkin3.ToolWindowGradient = dockPaneStripToolWindowGradient3;
			dockPanelSkin3.DockPaneStripSkin = dockPaneStripSkin3;
			this.dockPanel1.Skin = dockPanelSkin3;
			this.dockPanel1.TabIndex = 3;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 544);
			this.Controls.Add(this.dockPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem documentStyleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dockingMdiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dockingWindowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dockingSdiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem systemMdiToolStripMenuItem;
	}
}

