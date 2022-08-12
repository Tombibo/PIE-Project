using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using PIE.AdapterUI;
using PIE.AxControls;
using PIE.Controls;
using PIE.ControlsUI;
using PIE.Display;
using PIE.SystemUI;

namespace PIE_LanTan
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitFrom();
            mMapcontrol = new PIE.AxControls.MapControl();
            tocControl = new PIE.AxControls.TOCControl();
            tocControl.SetBuddyControl(mMapcontrol);
            splitContainer.Panel1.Controls.Add(tocControl);
            tabPage1.Controls.Add(mMapcontrol);
            mMapcontrol.Dock = DockStyle.Fill;
            tocControl.Dock = DockStyle.Fill;

        }
        /// <summary>
        /// 初始化界面
        /// </summary>
        private void InitFrom()
        {
            mapControl1.FocusMap = pageLayoutControl1.FocusMap;
            tocControl1.SetBuddyControl(pageLayoutControl1);
        }
        private PIE.AxControls.MapControl mMapcontrol = new PIE.AxControls.MapControl();
        private PIE.AxControls.TOCControl tocControl = new PIE.AxControls.TOCControl();
        private PIE.AxControls.PageLayoutControl pageLayerControl = new PIE.AxControls.PageLayoutControl();

        private void 加载栅格数据_Click(object sender, EventArgs e)
        {
            PIE.SystemUI.ICommand cmd = new PIE.Controls.RasterCommand();
            cmd.OnCreate(mapControl1);
            cmd.OnClick();
        }
        /// <summary>
        /// 综合判读_选择要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            ITool tool = new ElementSelectTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }

        }
        /// <summary>
        /// 综合判读_画点要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_DrawPoint_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawPointElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 绘制折线要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 折线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawPolylineElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 绘制曲线要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 曲线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawCurveElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 绘制自由线要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 自由线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawFreehandElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 绘制椭圆要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 椭圆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawEllipseElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 绘制矩形要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 矩形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawRectElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 绘制圆要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 圆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawCircleElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 绘制多边形要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 多边形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawPolygonElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 绘制箭头要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_DrawArrow_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawArrowElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 绘制文本要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_DrawText_Click(object sender, EventArgs e)
        {
            ITool tool = new DrawTextElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 编辑节点工具
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_EditElementNode_Click(object sender, EventArgs e)
        {
            ITool tool = new EditElementNodeTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                cmd.OnClick();
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                cmd.OnClick();
                pageLayoutControl1.CurrentTool = tool;
            }
        }

        /// <summary>
        /// 旋转要素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Rotate_Click(object sender, EventArgs e)
        {
            ITool tool = new RotateElementTool();
            ICommand cmd = tool as ICommand;
            if (tabControl1.SelectedIndex == 0)
            {
                cmd.OnCreate(mapControl1);
                cmd.OnClick();
                mapControl1.CurrentTool = tool;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                cmd.OnCreate(pageLayoutControl1);
                cmd.OnClick();
                pageLayoutControl1.CurrentTool = tool;
            }
        }
    }
}
