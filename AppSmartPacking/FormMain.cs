using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSmartPacking
{
    public partial class frmMain : Form
    {
        private Form ActiveForm = null;

        public object SplitContainer1 { get; private set; }

        public frmMain()
        {
            InitializeComponent();
            customizeDeign();
            
        }

        #region FUNCTION
        private void customizeDeign()
        {
            /*
             * 
             * Giai thich code
             * 
            */
            panelSpace.Size = new System.Drawing.Size(255, 100);
            //panelMenu.Size = new System.Drawing.Size(255, 500);
            panelSubMenuCaterogy.Visible = false;
            panelSubMenuSystem.Visible = false;
            panelSubMenuInOut.Visible = false;
            panelSpace.Visible = true;
        } 
        private void hideSubMenu()
        {
            if(panelSubMenuSystem.Visible == true)
            {
                panelSubMenuSystem.Visible = false;
            }
            if (panelSubMenuInOut.Visible == true)
            {
                panelSubMenuInOut.Visible = false;
            }
            if (panelSubMenuCaterogy.Visible == true)
            {
                panelSubMenuCaterogy.Visible = false;
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        
        private void openChildForm(Form ChildForm, Panel panelShow)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = ChildForm;
            
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.MaximizeBox = false;
            ChildForm.MinimizeBox = false;
            
            panelShow.Controls.Add(ChildForm);
            panelShow.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        #endregion

        #region Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
        }
        #endregion

        #region Menu he thong
        private void btnSystem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuSystem);
            
        }

        private void btnSystemControl_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormSTControl(), panelDisplay);

        }

        private void btnSystemCamera_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormSTCamera(), panelDisplay);
        }

        private void btnSystemRfid_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormSTRfid(), panelDisplay);
        }

        private void btnSystemManager_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormSTManagement(), panelDisplay);
        }
        #endregion

        #region menu danh muc
        private void btnMenuCaterogy_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCaterogy);
        }

        private void btnCarPacking_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormCACarPacking(), panelDisplay);
        }

        private void btnCaterogy2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormCACaterogy2(), panelDisplay);
        }

        private void btnCaterogy3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormCACaterogy3(), panelDisplay);
        }
        #endregion

        #region menu quan ly

        private void btnManegementInOut_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuInOut);
        }

        private void btnInOutManagement_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormMNInOut(), panelDisplay);
        }

        private void btnTicketMonthManagement_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormMNTicketMonth(), panelDisplay);
        }

        private void btnCardRfidManagement_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormMNCardRfid(), panelDisplay);
        }

        private void btnCameraManagement_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormMNCamera(), panelDisplay);
        }
        #endregion

        #region bao cao thong ke
        private void btnMenuBarReport_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormReport(), panelDisplay);
        }
        #endregion

        #region Help
        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormHelp(), panelDisplay);
        }
        #endregion 

        #region Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void frmMain_MaximumSizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
