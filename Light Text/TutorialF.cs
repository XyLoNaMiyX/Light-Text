using System;
using System.Windows.Forms;

namespace Light_Text
{
    public partial class TutorialF : Form
    {
        public TutorialF()
        {
            InitializeComponent();
            SetText();
        }
        
        void SetText() {
			Text = "Tutorial";
		}

        void TutorialF_Load(object sender, EventArgs e)
        {
            string rtf = Properties.Resources.help;
            tutorialRTB.Rtf = rtf;
        }
    }
}
