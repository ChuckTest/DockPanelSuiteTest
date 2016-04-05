using System;
using System.Linq;
using System.Windows.Forms;
using log4net;
using log4net.Appender;
using log4net.Repository.Hierarchy;
using WeifenLuo.WinFormsUI.Docking;

namespace WindowsFormsApplication1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
			InitLog();
        }

	    private static void InitLog()
	    {
			LogHelper.Init("app.config");
	    }


	    private void Form1_Load(object sender, EventArgs e)
	    {
		    this.IsMdiContainer = true;
	    }

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			FormChild tempForm2 = new FormChild();
			tempForm2.MdiParent = this;
			tempForm2.Show(dockPanel1);
		}

	    private void SetDocumentStyle(object sender, EventArgs e)
	    {
		    DocumentStyle olDocumentStyle = dockPanel1.DocumentStyle;
		    DocumentStyle newDocumentStyle;
		    if(sender == dockingMdiToolStripMenuItem)
		    {
			    newDocumentStyle = DocumentStyle.DockingMdi;
		    }
		    else if(sender == dockingSdiToolStripMenuItem)
		    {
			    newDocumentStyle = DocumentStyle.DockingSdi;
		    }
		    else if(sender == dockingWindowToolStripMenuItem)
		    {
			    newDocumentStyle = DocumentStyle.DockingWindow;
		    }
		    else if(sender == systemMdiToolStripMenuItem)
		    {
			    newDocumentStyle = DocumentStyle.SystemMdi;
		    }
		    else
		    {
			    throw new Exception("无法识别的sender");
		    }
		    if(newDocumentStyle == olDocumentStyle)
		    {
			    return;
		    }
		    dockPanel1.DocumentStyle = newDocumentStyle;

		    dockingMdiToolStripMenuItem.Checked = (newDocumentStyle == DocumentStyle.DockingMdi);
		    dockingSdiToolStripMenuItem.Checked = (newDocumentStyle == DocumentStyle.DockingSdi);
		    dockingWindowToolStripMenuItem.Checked = (newDocumentStyle == DocumentStyle.DockingWindow);
		    systemMdiToolStripMenuItem.Checked = (newDocumentStyle == DocumentStyle.SystemMdi);

	    }

		private void toolStripButtonLog_Click(object sender, EventArgs e)
		{
			var rootAppender = ((Hierarchy)LogManager.GetRepository())
										 .Root.Appenders.OfType<FileAppender>()
										 .FirstOrDefault();

			string filename = rootAppender != null ? rootAppender.File : string.Empty;

			MessageBox.Show(filename);
		}

		//  private FormChild CreateChild()
		//  {
		//   FormChild tempForm2 = new FormChild();
		//   tempForm2.MdiParent = this;
		//   int count = 1;
		//   string text = $"Form{count}";
		//while(ChildExist(text))
		//   {
		//    count++;
		//    text = $"Form{count}";
		//   }
		//   tempForm2.Text = text;
		//  }

		//  private bool ChildExist(string text)
		//  {
		//   bool flag = false;
		//   foreach(var item in dockPanel1.Contents)
		//   {
		//   item.DockHandler.TabText
		//   }
		//   return flag;
		//  }
	}
}
