namespace Light_Text
{
    partial class CountSearchReplaceF
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountSearchReplaceF));
        	this.splitContainer = new System.Windows.Forms.SplitContainer();
        	this.toSearchTB = new System.Windows.Forms.TextBox();
        	this.replaceWithTB = new System.Windows.Forms.TextBox();
        	this.multilineCB = new System.Windows.Forms.CheckBox();
        	this.countB = new System.Windows.Forms.Button();
        	this.searchB = new System.Windows.Forms.Button();
        	this.replaceAllB = new System.Windows.Forms.Button();
        	this.ignoreCapital = new System.Windows.Forms.CheckBox();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
        	this.splitContainer.Panel1.SuspendLayout();
        	this.splitContainer.Panel2.SuspendLayout();
        	this.splitContainer.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// splitContainer
        	// 
        	this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.splitContainer.Location = new System.Drawing.Point(9, 13);
        	this.splitContainer.Name = "splitContainer";
        	this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
        	// 
        	// splitContainer.Panel1
        	// 
        	this.splitContainer.Panel1.Controls.Add(this.toSearchTB);
        	// 
        	// splitContainer.Panel2
        	// 
        	this.splitContainer.Panel2.Controls.Add(this.replaceWithTB);
        	this.splitContainer.Size = new System.Drawing.Size(191, 119);
        	this.splitContainer.SplitterDistance = 61;
        	this.splitContainer.TabIndex = 6;
        	// 
        	// toSearchTB
        	// 
        	this.toSearchTB.AcceptsTab = true;
        	this.toSearchTB.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.toSearchTB.Location = new System.Drawing.Point(0, 0);
        	this.toSearchTB.Name = "toSearchTB";
        	this.toSearchTB.Size = new System.Drawing.Size(191, 20);
        	this.toSearchTB.TabIndex = 0;
        	this.toSearchTB.TextChanged += new System.EventHandler(this.toSearchTB_TextChanged);
        	this.toSearchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toSearchTB_KeyDown);
        	// 
        	// replaceWithTB
        	// 
        	this.replaceWithTB.AcceptsTab = true;
        	this.replaceWithTB.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.replaceWithTB.Location = new System.Drawing.Point(0, 0);
        	this.replaceWithTB.Name = "replaceWithTB";
        	this.replaceWithTB.Size = new System.Drawing.Size(191, 20);
        	this.replaceWithTB.TabIndex = 2;
        	this.replaceWithTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.replaceWithTB_KeyDown);
        	// 
        	// multilineCB
        	// 
        	this.multilineCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.multilineCB.AutoSize = true;
        	this.multilineCB.Location = new System.Drawing.Point(206, 71);
        	this.multilineCB.Name = "multilineCB";
        	this.multilineCB.Size = new System.Drawing.Size(122, 17);
        	this.multilineCB.TabIndex = 1;
        	this.multilineCB.Text = "Búsqueda multilínea";
        	this.multilineCB.UseVisualStyleBackColor = true;
        	this.multilineCB.CheckedChanged += new System.EventHandler(this.multilineCB_CheckedChanged);
        	// 
        	// countB
        	// 
        	this.countB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.countB.Location = new System.Drawing.Point(206, 13);
        	this.countB.Name = "countB";
        	this.countB.Size = new System.Drawing.Size(106, 23);
        	this.countB.TabIndex = 3;
        	this.countB.Text = "Contar";
        	this.countB.UseVisualStyleBackColor = true;
        	this.countB.Click += new System.EventHandler(this.countB_Click);
        	// 
        	// searchB
        	// 
        	this.searchB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.searchB.Location = new System.Drawing.Point(206, 42);
        	this.searchB.Name = "searchB";
        	this.searchB.Size = new System.Drawing.Size(106, 23);
        	this.searchB.TabIndex = 4;
        	this.searchB.Text = "Buscar";
        	this.searchB.UseVisualStyleBackColor = true;
        	this.searchB.Click += new System.EventHandler(this.searchB_Click);
        	// 
        	// replaceAllB
        	// 
        	this.replaceAllB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.replaceAllB.Location = new System.Drawing.Point(206, 109);
        	this.replaceAllB.Name = "replaceAllB";
        	this.replaceAllB.Size = new System.Drawing.Size(106, 23);
        	this.replaceAllB.TabIndex = 5;
        	this.replaceAllB.Text = "Reemplazar";
        	this.replaceAllB.UseVisualStyleBackColor = true;
        	this.replaceAllB.Click += new System.EventHandler(this.replaceAllB_Click);
        	// 
        	// ignoreCapital
        	// 
        	this.ignoreCapital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.ignoreCapital.AutoSize = true;
        	this.ignoreCapital.Checked = true;
        	this.ignoreCapital.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.ignoreCapital.Location = new System.Drawing.Point(206, 91);
        	this.ignoreCapital.Name = "ignoreCapital";
        	this.ignoreCapital.Size = new System.Drawing.Size(117, 17);
        	this.ignoreCapital.TabIndex = 7;
        	this.ignoreCapital.Text = "Ignorar mayúsculas";
        	this.ignoreCapital.UseVisualStyleBackColor = true;
        	this.ignoreCapital.CheckedChanged += new System.EventHandler(this.ignoreCapital_CheckedChanged);
        	// 
        	// CountSearchReplaceF
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(324, 141);
        	this.Controls.Add(this.ignoreCapital);
        	this.Controls.Add(this.splitContainer);
        	this.Controls.Add(this.replaceAllB);
        	this.Controls.Add(this.searchB);
        	this.Controls.Add(this.countB);
        	this.Controls.Add(this.multilineCB);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MinimumSize = new System.Drawing.Size(340, 180);
        	this.Name = "CountSearchReplaceF";
        	this.Text = "Contar, buscar y reemplazar";
        	this.TopMost = true;
        	this.splitContainer.Panel1.ResumeLayout(false);
        	this.splitContainer.Panel1.PerformLayout();
        	this.splitContainer.Panel2.ResumeLayout(false);
        	this.splitContainer.Panel2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
        	this.splitContainer.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.TextBox toSearchTB;
        System.Windows.Forms.CheckBox multilineCB;
        System.Windows.Forms.TextBox replaceWithTB;
        System.Windows.Forms.Button countB;
        System.Windows.Forms.Button searchB;
        System.Windows.Forms.Button replaceAllB;
        System.Windows.Forms.SplitContainer splitContainer;
        System.Windows.Forms.CheckBox ignoreCapital;
    }
}
