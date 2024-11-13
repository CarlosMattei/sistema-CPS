using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSHelpProfessores.Forms
{
    public partial class SucessForm : Form
    {
        int toastX, toastY;
        public SucessForm()
        {
            InitializeComponent();
        }

        private void SucessForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        int y = 100;
        private void SuccessHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 800)
                {
                    SuccessHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHeight - this.Height - 10;

            this.Location = new Point(toastX, toastY);
        }
    }
}
