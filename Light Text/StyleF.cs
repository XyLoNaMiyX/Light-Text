using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Light_Text
{
    public partial class StyleF : Form
    {
        #region Variables

        MainF f = (MainF)Application.OpenForms["MainF"];

        Color bkcolor;
        Color frcolor;

        Font font;

        string fontsize;

        #endregion

        #region Set up

        public StyleF()
        {
            InitializeComponent();
            SetText();

            fontsize = fontSizeL.Text;

            font = f.textEditorRTB.Font;

            bkcolor = f.textEditorRTB.BackColor;
            frcolor = f.textEditorRTB.ForeColor;
        }
        
        void SetText() {
			foreColorL.Text = "Color de frente";
			backColorL.Text = "Color de fondo";
			strikeoutCB.Text = "Tachada";
			underlineCB.Text = "Subrayada";
			italicCB.Text = "Cursiva";
			boldCB.Text = "Negrita";
			fontL.Text = "Fuente";
			previewCB.Text = "Vista previa";
			cancelB.Text = "Cancelar";
			acceptB.Text = "Aceptar";
			fontSizeL.Text = "Tamaño de la fuente";
			Text = "Estilo";
		}

        void StyleF_Load(object sender, EventArgs e)
        {
            SetSizeValue();

            FontFamily[] fontFamilies = new InstalledFontCollection().Families;
            foreach (FontFamily ff in fontFamilies)
                fontsCB.Items.Add(ff.Name);

            fontSizeTB.Value = (int)font.Size;
            SetSizeValue();
            fontsCB.SelectedItem = font.Name;

            boldCB.Checked = font.Bold;
            italicCB.Checked = font.Italic;
            underlineCB.Checked = font.Underline;
            strikeoutCB.Checked = font.Strikeout;

            foreColorP.BackColor = frcolor;
            backColorP.BackColor = bkcolor;
        }

        #endregion

        #region Something changed

        void fontSizeTB_Scroll(object sender, EventArgs e)
        {
            SetSizeValue();
            SetPreview();
        }

        void SetSizeValue() {
            fontSizeL.Text = fontsize + " " + fontSizeTB.Value + "px";
        }

        void fontsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPreview();
        }

        void FontStyleCB_CheckedChanged(object sender, EventArgs e)
        {
            SetPreview();
        }

        void foreColorP_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = foreColorP.BackColor;
            if (cd.ShowDialog() != DialogResult.OK)
                return;
            foreColorP.BackColor = cd.Color;
            SetPreview();
        }

        void backColorP_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = backColorP.BackColor;
            if (cd.ShowDialog() != DialogResult.OK)
                return;
            backColorP.BackColor = cd.Color;
            SetPreview();
        }

        #endregion

        #region Set preview

        void previewCB_CheckedChanged(object sender, EventArgs e)
        {
            SetPreview();
        }

        void SetPreview()
        {
            if (previewCB.Checked)
            {
                FontStyle fsbold = boldCB.Checked ? FontStyle.Bold : FontStyle.Regular;
                FontStyle fsitalic = italicCB.Checked ? FontStyle.Italic : FontStyle.Regular;
                FontStyle fsunderline = underlineCB.Checked ? FontStyle.Underline : FontStyle.Regular;
                FontStyle fsstrikeout = strikeoutCB.Checked ? FontStyle.Strikeout : FontStyle.Regular;

                f.textEditorRTB.Font = new Font(fontsCB.Text, fontSizeTB.Value,
                    fsbold | fsitalic | fsunderline | fsstrikeout);

                f.textEditorRTB.ForeColor = foreColorP.BackColor;
                f.textEditorRTB.BackColor = backColorP.BackColor;
            }
            else
            {
                f.textEditorRTB.Font = font;

                f.textEditorRTB.ForeColor = frcolor;
                f.textEditorRTB.BackColor = bkcolor;
            }
        }

        #endregion

        #region Exit

        void acceptB_Click(object sender, EventArgs e)
        {
            previewCB.Checked = true;
            f.SaveOptions();
            this.Close();
        }

        void cancelB_Click(object sender, EventArgs e)
        {
            previewCB.Checked = false;
            f.SaveOptions();
            this.Close();
        }

        #endregion
    }
}
