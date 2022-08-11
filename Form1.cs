using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIE.AdapterUI;
using PIE.AxControls;
using PIE.Controls;
using PIE.ControlsUI;
using PIE.Display;
namespace PIE_LanTan
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            mMapcontrol = new PIE.AxControls.MapControl();
            tocControl = new PIE.AxControls.TOCControl();
            tocControl.SetBuddyControl(mMapcontrol);
            splitContainer.Panel1.Controls.Add(tocControl);
            tabPage1.Controls.Add(mMapcontrol);
            mMapcontrol.Dock = DockStyle.Fill;
            tocControl.Dock = DockStyle.Fill;

        }
        private PIE.AxControls.MapControl mMapcontrol = new PIE.AxControls.MapControl();
        private PIE.AxControls.TOCControl tocControl = new PIE.AxControls.TOCControl();
        private PIE.AxControls.PageLayoutControl pageLayerControl = new PIE.AxControls.PageLayoutControl();

        private void 加载栅格数据_Click(object sender, EventArgs e)
        {
            PIE.SystemUI.ICommand cmd = new PIE.Controls.RasterCommand();
            cmd.OnCreate(mMapcontrol);
            cmd.OnClick();
        }
    }
}
