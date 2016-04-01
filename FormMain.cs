using System;
using System.Media;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Timer = System.Windows.Forms.Timer;

namespace WindowsFormsApplication1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
	}
}
