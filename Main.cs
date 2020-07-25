using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace StayOnTop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnSetTop_Click(object sender, EventArgs e)
        {
            SetWindowState("top");
        }

        private void btnSetNormal_Click(object sender, EventArgs e)
        {
            SetWindowState("normal");
        }

        private void btnSetBottom_Click(object sender, EventArgs e)
        {
            SetWindowState("bottom");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private bool SetWindowState(string state)
        {
            IntPtr handle = ((WindowInfo)lbWindows.SelectedItem).Handle;
            switch(state)
            {
                case "top":
                    return WindowManager.SetStayOnTop(handle);
                case "normal":
                    return WindowManager.SetStayNormal(handle);
                case "bottom":
                    return WindowManager.SetStayOnBottom(handle);
            }
            return false;
        }

        private void LoadList()
        {
            lbWindows.DataSource = WindowManager.GetOpenWindowsList();
        }
    }
}
