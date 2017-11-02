namespace Light_Text
{
    partial class StyleF
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleF));
        	this.foreColorP = new System.Windows.Forms.Panel();
        	this.foreColorL = new System.Windows.Forms.Label();
        	this.backColorL = new System.Windows.Forms.Label();
        	this.backColorP = new System.Windows.Forms.Panel();
        	this.strikeoutCB = new System.Windows.Forms.CheckBox();
        	this.underlineCB = new System.Windows.Forms.CheckBox();
        	this.italicCB = new System.Windows.Forms.CheckBox();
        	this.boldCB = new System.Windows.Forms.CheckBox();
        	this.fontL = new System.Windows.Forms.Label();
        	this.previewCB = new System.Windows.Forms.CheckBox();
        	this.cancelB = new System.Windows.Forms.Button();
        	this.acceptB = new System.Windows.Forms.Button();
        	this.fontsCB = new System.Windows.Forms.ComboBox();
        	this.fontSizeL = new System.Windows.Forms.Label();
        	this.fontSizeTB = new System.Windows.Forms.TrackBar();
        	((System.ComponentModel.ISupportInitialize)(this.fontSizeTB)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// foreColorP
        	// 
        	this.foreColorP.BackColor = System.Drawing.Color.Black;
        	this.foreColorP.Location = new System.Drawing.Point(223, 156);
        	this.foreColorP.Name = "foreColorP";
        	this.foreColorP.Size = new System.Drawing.Size(24, 24);
        	this.foreColorP.TabIndex = 0;
        	this.foreColorP.Click += new System.EventHandler(this.foreColorP_Click);
        	// 
        	// foreColorL
        	// 
        	this.foreColorL.AutoSize = true;
        	this.foreColorL.Location = new System.Drawing.Point(141, 167);
        	this.foreColorL.Name = "foreColorL";
        	this.foreColorL.Size = new System.Drawing.Size(76, 13);
        	this.foreColorL.TabIndex = 1;
        	this.foreColorL.Text = "Color de frente";
        	// 
        	// backColorL
        	// 
        	this.backColorL.AutoSize = true;
        	this.backColorL.Location = new System.Drawing.Point(10, 167);
        	this.backColorL.Name = "backColorL";
        	this.backColorL.Size = new System.Drawing.Size(76, 13);
        	this.backColorL.TabIndex = 7;
        	this.backColorL.Text = "Color de fondo";
        	// 
        	// backColorP
        	// 
        	this.backColorP.BackColor = System.Drawing.Color.White;
        	this.backColorP.Location = new System.Drawing.Point(92, 158);
        	this.backColorP.Name = "backColorP";
        	this.backColorP.Size = new System.Drawing.Size(24, 24);
        	this.backColorP.TabIndex = 6;
        	this.backColorP.Click += new System.EventHandler(this.backColorP_Click);
        	// 
        	// strikeoutCB
        	// 
        	this.strikeoutCB.AutoSize = true;
        	this.strikeoutCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout);
        	this.strikeoutCB.Location = new System.Drawing.Point(170, 113);
        	this.strikeoutCB.Name = "strikeoutCB";
        	this.strikeoutCB.Size = new System.Drawing.Size(69, 17);
        	this.strikeoutCB.TabIndex = 22;
        	this.strikeoutCB.Text = "Tachada";
        	this.strikeoutCB.UseVisualStyleBackColor = true;
        	this.strikeoutCB.CheckedChanged += new System.EventHandler(this.FontStyleCB_CheckedChanged);
        	// 
        	// underlineCB
        	// 
        	this.underlineCB.AutoSize = true;
        	this.underlineCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
        	this.underlineCB.Location = new System.Drawing.Point(170, 89);
        	this.underlineCB.Name = "underlineCB";
        	this.underlineCB.Size = new System.Drawing.Size(77, 17);
        	this.underlineCB.TabIndex = 21;
        	this.underlineCB.Text = "Subrayada";
        	this.underlineCB.UseVisualStyleBackColor = true;
        	this.underlineCB.CheckedChanged += new System.EventHandler(this.FontStyleCB_CheckedChanged);
        	// 
        	// italicCB
        	// 
        	this.italicCB.AutoSize = true;
        	this.italicCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
        	this.italicCB.Location = new System.Drawing.Point(16, 113);
        	this.italicCB.Name = "italicCB";
        	this.italicCB.Size = new System.Drawing.Size(61, 17);
        	this.italicCB.TabIndex = 20;
        	this.italicCB.Text = "Cursiva";
        	this.italicCB.UseVisualStyleBackColor = true;
        	this.italicCB.CheckedChanged += new System.EventHandler(this.FontStyleCB_CheckedChanged);
        	// 
        	// boldCB
        	// 
        	this.boldCB.AutoSize = true;
        	this.boldCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.boldCB.Location = new System.Drawing.Point(15, 89);
        	this.boldCB.Name = "boldCB";
        	this.boldCB.Size = new System.Drawing.Size(67, 17);
        	this.boldCB.TabIndex = 19;
        	this.boldCB.Text = "Negrita";
        	this.boldCB.UseVisualStyleBackColor = true;
        	this.boldCB.CheckedChanged += new System.EventHandler(this.FontStyleCB_CheckedChanged);
        	// 
        	// fontL
        	// 
        	this.fontL.AutoSize = true;
        	this.fontL.Location = new System.Drawing.Point(13, 41);
        	this.fontL.Name = "fontL";
        	this.fontL.Size = new System.Drawing.Size(40, 13);
        	this.fontL.TabIndex = 18;
        	this.fontL.Text = "Fuente";
        	// 
        	// previewCB
        	// 
        	this.previewCB.AutoSize = true;
        	this.previewCB.Checked = true;
        	this.previewCB.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.previewCB.Location = new System.Drawing.Point(15, 204);
        	this.previewCB.Name = "previewCB";
        	this.previewCB.Size = new System.Drawing.Size(81, 17);
        	this.previewCB.TabIndex = 17;
        	this.previewCB.Text = "Vista previa";
        	this.previewCB.UseVisualStyleBackColor = true;
        	this.previewCB.CheckedChanged += new System.EventHandler(this.previewCB_CheckedChanged);
        	// 
        	// cancelB
        	// 
        	this.cancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.cancelB.Location = new System.Drawing.Point(98, 200);
        	this.cancelB.Name = "cancelB";
        	this.cancelB.Size = new System.Drawing.Size(75, 23);
        	this.cancelB.TabIndex = 16;
        	this.cancelB.Text = "Cancelar";
        	this.cancelB.UseVisualStyleBackColor = true;
        	this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
        	// 
        	// acceptB
        	// 
        	this.acceptB.Location = new System.Drawing.Point(179, 200);
        	this.acceptB.Name = "acceptB";
        	this.acceptB.Size = new System.Drawing.Size(75, 23);
        	this.acceptB.TabIndex = 15;
        	this.acceptB.Text = "Aceptar";
        	this.acceptB.UseVisualStyleBackColor = true;
        	this.acceptB.Click += new System.EventHandler(this.acceptB_Click);
        	// 
        	// fontsCB
        	// 
        	this.fontsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.fontsCB.FormattingEnabled = true;
        	this.fontsCB.Location = new System.Drawing.Point(59, 38);
        	this.fontsCB.Name = "fontsCB";
        	this.fontsCB.Size = new System.Drawing.Size(188, 21);
        	this.fontsCB.TabIndex = 14;
        	this.fontsCB.SelectedIndexChanged += new System.EventHandler(this.fontsCB_SelectedIndexChanged);
        	// 
        	// fontSizeL
        	// 
        	this.fontSizeL.AutoSize = true;
        	this.fontSizeL.Location = new System.Drawing.Point(12, 9);
        	this.fontSizeL.Name = "fontSizeL";
        	this.fontSizeL.Size = new System.Drawing.Size(105, 13);
        	this.fontSizeL.TabIndex = 13;
        	this.fontSizeL.Text = "Tamaño de la fuente";
        	// 
        	// fontSizeTB
        	// 
        	this.fontSizeTB.AutoSize = false;
        	this.fontSizeTB.Location = new System.Drawing.Point(143, 9);
        	this.fontSizeTB.Maximum = 100;
        	this.fontSizeTB.Minimum = 8;
        	this.fontSizeTB.Name = "fontSizeTB";
        	this.fontSizeTB.Size = new System.Drawing.Size(104, 26);
        	this.fontSizeTB.TabIndex = 12;
        	this.fontSizeTB.TickStyle = System.Windows.Forms.TickStyle.None;
        	this.fontSizeTB.Value = 8;
        	this.fontSizeTB.Scroll += new System.EventHandler(this.fontSizeTB_Scroll);
        	// 
        	// StyleF
        	// 
        	this.AcceptButton = this.acceptB;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.cancelB;
        	this.ClientSize = new System.Drawing.Size(257, 233);
        	this.Controls.Add(this.strikeoutCB);
        	this.Controls.Add(this.underlineCB);
        	this.Controls.Add(this.italicCB);
        	this.Controls.Add(this.boldCB);
        	this.Controls.Add(this.fontL);
        	this.Controls.Add(this.previewCB);
        	this.Controls.Add(this.cancelB);
        	this.Controls.Add(this.acceptB);
        	this.Controls.Add(this.fontsCB);
        	this.Controls.Add(this.fontSizeL);
        	this.Controls.Add(this.fontSizeTB);
        	this.Controls.Add(this.backColorL);
        	this.Controls.Add(this.backColorP);
        	this.Controls.Add(this.foreColorL);
        	this.Controls.Add(this.foreColorP);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "StyleF";
        	this.Text = "Estilo";
        	this.TopMost = true;
        	this.Load += new System.EventHandler(this.StyleF_Load);
        	((System.ComponentModel.ISupportInitialize)(this.fontSizeTB)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.Panel foreColorP;
        System.Windows.Forms.Label foreColorL;
        System.Windows.Forms.Label backColorL;
        System.Windows.Forms.Panel backColorP;
        System.Windows.Forms.CheckBox strikeoutCB;
        System.Windows.Forms.CheckBox underlineCB;
        System.Windows.Forms.CheckBox italicCB;
        System.Windows.Forms.CheckBox boldCB;
        System.Windows.Forms.Label fontL;
        System.Windows.Forms.CheckBox previewCB;
        System.Windows.Forms.Button cancelB;
        System.Windows.Forms.Button acceptB;
        System.Windows.Forms.ComboBox fontsCB;
        System.Windows.Forms.Label fontSizeL;
        System.Windows.Forms.TrackBar fontSizeTB;
    }
}
