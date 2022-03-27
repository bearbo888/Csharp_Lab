using Forms_Lab;
using Loan_Lab;
using POS_Lab;
using Student_StructForm;
using StudentGrade;
using StudentGrade_List;
using Method;
using doForWhile;
using Screen_Saver;
using XOgame;
using System;
using System.Windows.Forms;
using MyClac;
using Guess;
using Notepad;
using Painter;

namespace HomePage
{
    public partial class frmHOP : Form
    {
        public frmHOP()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmHLO frm = new frmHLO();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.;
            splitContainer2.Panel2.Controls.Add(frm);       
            frm.Show();
        }
        private void btnLoan_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmLON frm = new frmLON();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmPOS frm = new frmPOS();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnSSF_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmSSF frm = new frmSSF();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnSG_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmSGE frm = new frmSGE();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnSGL_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmSGL frm = new frmSGL();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnMethod_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmMET frm = new frmMET();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmCAL frm = new frmCAL();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnDO_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmDFW frm = new frmDFW();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnXO_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmXOG frm = new frmXOG();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void frmHOP_AutoSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void splitContainer2_Panel1_Resize(object sender, EventArgs e)
        {
            btnDO.Width = splitContainer2.Panel1.Width-20;
            btnCalc.Width = splitContainer2.Panel1.Width - 20;
            btnHello.Width = splitContainer2.Panel1.Width - 20;
            btnLoan.Width = splitContainer2.Panel1.Width - 20;
            btnMethod.Width = splitContainer2.Panel1.Width - 20;
            btnPOS.Width = splitContainer2.Panel1.Width - 20;
            btnSGL.Width = splitContainer2.Panel1.Width - 20;
            btnSSF.Width = splitContainer2.Panel1.Width - 20;
            btnXO.Width = splitContainer2.Panel1.Width - 20;
            btnSG.Width = splitContainer2.Panel1.Width - 20;
            btnGuess.Width = splitContainer2.Panel1.Width - 20;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmGUS frm = new frmGUS();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmSSR frm = new frmSSR();
            frm.Show();
        }

        private void btnNotePad_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmNTP frm = new frmNTP();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            frmPAT frm = new frmPAT();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.AutoScroll = true;
            //frm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
    }
}
