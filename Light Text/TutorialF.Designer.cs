namespace Light_Text
{
    partial class TutorialF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorialF));
            this.tutorialRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tutorialRTB
            // 
            this.tutorialRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tutorialRTB.Location = new System.Drawing.Point(0, 0);
            this.tutorialRTB.Name = "tutorialRTB";
            this.tutorialRTB.Size = new System.Drawing.Size(584, 361);
            this.tutorialRTB.TabIndex = 0;
            this.tutorialRTB.Text = "";
            // 
            // TutorialF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tutorialRTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TutorialF";
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.TutorialF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        System.Windows.Forms.RichTextBox tutorialRTB;
    }
}
