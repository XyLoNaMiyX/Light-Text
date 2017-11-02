using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ExtensionMethods;
using Microsoft.Win32;

using Light_Text.Properties;

namespace Light_Text
{
    public partial class MainF : Form
    {

        #region Variables

        enum StatusTypes { Success, Information, Warning, Error };

        string ltxtpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            @"\LonamiWebs\Light Text";

        string addonsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            @"\LonamiWebs\Light Text\Addons";

        bool changingTab = true;

        bool refreshingTabs = true;

        string filter =  Resources.filters + Resources.allfilter;

        string filterload = Resources.allfilter;

        public class CachedFile {
            public string Content { get; set; }
            public string Path { get; set; }
            public bool Saved { get; set; }

            public CachedFile(string content = "", string path = "")
            {
                Content = content;
                Path = path;
                Saved = true;
            }
        }
        List<CachedFile> cachedFiles = new List<CachedFile>();

        string[] arguments = new string[0];

        InterProcessCommunication ipc = new InterProcessCommunication("LightTextIPC");

        string[] emojifaces = { "😄", "😃", "😀", "😊", "☺", "😉", "😍", "😘", "😚", "😗", "😙", "😜", "😝", "😛", "😳", "😁", "😔", "😌", "😒", "😞", "😣", "😢", "😂", "😭", "😪", "😥", "😰", "😅", "😓", "😩", "😫", "😨", "😱", "😠", "😡", "😤", "😖", "😆", "😋", "😷", "😎", "😴", "😵", "😲", "😟", "😦", "😧", "😈", "👿", "😮", "😬", "😐", "😕", "😯", "😶", "😇", "😏", "😑" };
        //string[] emojipeople = new string[] { "👲", "👳", "👮", "👷", "💂", "👶", "👦", "👧", "👨", "👩", "👴", "👵", "👱", "👼", "👸", "😺", "😸", "😻", "😽", "😼", "🙀", "😿", "😹", "😾", "👹", "👺", "🙈", "🙉", "🙊", "💀", "👽", "💩" };
        //string[] emojiothers = new string[] { "🔥", "✨", "🌟", "💫", "💥", "💢", "💦", "💧", "💤", "💨", "👂", "👀", "👃", "👅", "👄", "👍", "👎", "👌", "👊", "✊", "✌", "👋", "✋", "👐", "👆", "👇", "👉", "👈", "🙌", "🙏", "☝", "👏", "💪", "🚶", "🏃", "💃", "👫", "👪", "👬", "👭", "💏", "💑", "👯", "🙆", "🙅", "💁", "🙋", "💆", "💇", "💅", "👰", "🙎", "🙍", "🙇", "🎩", "👑", "👒", "👟", "👞", "👡", "👠", "👢", "👕", "👔", "👚", "👗", "🎽", "👖", "👘", "👙", "💼", "👜", "👝", "👛", "👓", "🎀", "🌂", "💄", "💛", "💙", "💜", "💚", "❤", "💔", "💗", "💓", "💕", "💖", "💞", "💘", "💌", "💋", "💍", "💎", "👤", "👥", "💬", "👣", "💭" };

        #endregion

        #region Set up

        public MainF(string[] args)
        {
            InitializeComponent();
            SetText();

            arguments = args;
            
            ipc.Listen();
            ipc.NewMessage += ipc_NewMessage;
        }
        
        void SetText() {
			closeCurrentTabTSMI.Text = "Cerrar pestaña actual";
			closeTabTSMI.Text = "Cerrar pestaña";
			randomTP.Text = "<null>";
			copyTSMI.Text = "Copiar";
			cutTSMI.Text = "Cortar";
			pasteTSMI.Text = "Pegar";
			undoTSMI.Text = "Deshacer";
			redoTSMI.Text = "Rehacer";
			emojisL.Text = "Los emojis no funcionan por el momento, pero son copiados al portapapeles";
			archivoToolStripMenuItem.Text = "Archivo";
			newTSMI.Text = "Nuevo";
			openTSMI.Text = "Abrir archivo(s)";
			saveTSMI.Text = "Guardar";
			saveAllTSMI.Text = "Guardar todos";
			saveAsTSMI.Text = "Guardar como...";
			editTSMI.Text = "Editar";
			countTSMI.Text = "Contar";
			searchTSMI.Text = "Buscar";
			replaceTSMI.Text = "Reemplazar";
			encodingTSMI.Text = "Codificación";
			utf7TSMI.Text = "UTF7";
			utf8TSMI.Text = "UTF8";
			utf32TSMI.Text = "UTF32";
			bigendianTSMI.Text = "Big endian";
			unicodeTSMI.Text = "Unicode";
			asciiTSMI.Text = "ASCII";
			settingsTSMI.Text = "Ajustes";
			programmerTSMI.Text = "Modo programador";
			smartHighlightingTSMI.Text = "Resaltado inteligente (BETA)";
			showincmsTSMI.Text = "Mostrar en el menú contextual";
			openLinksTSMI.Text = "Abrir links al cliquearlos";
			viewTSMI.Text = "Vista";
			styleTSMI.Text = "Estilo";
			showExtraPanelsTSMI.Text = "Mostrar paneles extra";
			sepEmojisTSMI.Text = "Emojis";
			helpTSMI.Text = "Ayuda";
			tutorialTSMI.Text = "Tutorial";
			supportTSMI.Text = "Soporte";
			checkUpdatesB.Text = "Comprobar actualizaciones";
			addonsTSMI.Text = "Addons";
			compilersTSMI.Text = "Compiladores";
			CSC.Text = "Descargar compilador C#";
			VBNET.Text = "Descargar compilador VB.Net";
			codeExampleTSMI.Text = "Ejemplo de código";
			cecsTSMI.Text = "Ejemplo C#";
			fileInfoTSSL.Text = "1 línea";
			infoTSSL.Text = "Información";
			Text = "Light Text";
		}

        void MainF_Load(object sender, EventArgs e)
        {
            SetStatus(Resources.loadsuccess, StatusTypes.Information);

            Directory.CreateDirectory(ltxtpath);
            if (!File.Exists(ltxtpath + @"\ofp")) //OpenedFilesPaths
                File.WriteAllText(ltxtpath + @"\ofp", "");

            LoadOptions();
            foreach (string s in arguments)
                AddFile(s, true);
            RefreshTabs();

            foreach (string c in emojifaces)
                emojisLV.Items.Add(c);
            CheckAddons();
        }

        #endregion

        #region Pipes

        void ipc_NewMessage(string message)
        {
        	m("gotcha msg");
        	Invoke(new MethodInvoker(Activate));
            if (message.Length > 0)
            	foreach (var file in message.Split('?'))
                	Invoke(new MethodInvoker(() => OpenFile(file)));
        }

        #endregion

        #region Addons

        Assembly ltcsc;
        Assembly ltvbnet;

        void CheckAddons() {
            Directory.CreateDirectory(addonsPath);

            if (File.Exists(addonsPath + @"\LTCSC.dll")) {
                CSC.Text = Resources.cscompiler;
                ltcsc = Assembly.LoadFile(addonsPath + @"\LTCSC.dll");
            }

            if (File.Exists(addonsPath + @"\LTVBNET.dll")) {
                VBNET.Text = Resources.vbcompiler;
                ltvbnet = Assembly.LoadFile(addonsPath + @"\LTVBNET.dll");
            }
        }

        void AddonTSMI_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            string name = tsmi.Name;

            string lang = "";
            string url = "";
            Assembly assembly = null;
            switch (name) {
                case "CSC":
                    lang = "C#";
                    assembly = ltcsc;
                    url = "https://dl.dropboxusercontent.com/s/n3ygxb711nuc5tc/LTCSC.dll?dl=1";
                    break;
                case "VBNET":
                    lang = "VB.Net";
                    assembly = ltvbnet;
                    url = "https://dl.dropboxusercontent.com/s/fcxk1gij7yo2tsn/LTVBNET.dll?dl=1";
                    break;
            }

            if (assembly != null)
            {
                string path = cachedFiles[textEditorTC.SelectedIndex].Path;

                if (path == "") {
                    if (MessageBox.Show(Resources.tocompile, Resources.saverequired,
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        if (Save()) {
                            path = cachedFiles[textEditorTC.SelectedIndex].Path;
                            object[] parameters = new object[] { textEditorRTB.Text, path };
                            ExecuteAddon(assembly, "LT" + name, "Compiler", parameters);
                        }
                }
                else {
                    object[] parameters = new object[] { textEditorRTB.Text, path };
                    ExecuteAddon(assembly, "LT" + name, "Compiler", parameters);
                }
            } else {
                try {
                    if (MessageBox.Show(Resources.wishdownload + " " + lang + "?", Resources.downloadaddon,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        using (WebClient client = new WebClient()) {
                            client.DownloadFile(url, addonsPath + @"\LT" + name + ".dll");

                            CheckAddons();

                            MessageBox.Show(Resources.addondownload, Resources.addondownloadt,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } catch {
                    MessageBox.Show(Resources.addonerror, Resources.addonerrort,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Code examples

        void cecsTSMI_Click(object sender, EventArgs e)
        {
            textEditorRTB.Text =
                "using System;\r\n\r\nnamespace Example {\r\n\tpublic class MyApp {\r\n\t\tpublic static void Main(string[] args) {\r\n\t\t\tConsole.WriteLine(\"" + Resources.helloworld + " :)\");\r\n\t\t\tConsole.ReadKey();\r\n\t\t}\r\n\t}\r\n}";
        }

        #endregion

        //More at stackoverflow.com/questions/14479074/c-sharp-reflection-load-assembly-and-invoke-a-method-if-it-exists
        void ExecuteAddon(Assembly assembly, string nmespace, string clss, object[] constructorParameters)
        {
            //Namespace, Class
            Type t = assembly.GetType(nmespace + "." + clss);

            //Create instance of class
            var o = Activator.CreateInstance(t, constructorParameters);
        }

        #endregion

        #region Options

        void LoadOptions()
        {
            try
            {
                Location = Settings.Default.Location;
                if (Location.X < 0 || Location.Y < 0)
                    Location = new Point(0, 0);
                Size = Settings.Default.Size;
                textEditorRTB.Font = Settings.Default.Font;
                textEditorRTB.BackColor = Settings.Default.BackColor;
                textEditorRTB.ForeColor = Settings.Default.ForeColor;
                sepEmojisTSMI.Checked = Settings.Default.ShowEmojis;
                programmerTSMI.Checked = Settings.Default.ProgrammerMode;
                smartHighlightingTSMI.Checked = Settings.Default.SmartHighlighting;
                openLinksTSMI.Checked = Settings.Default.OpenLinks;
                if (Settings.Default.Maximized)
                    WindowState = FormWindowState.Maximized;

                string[] openedFiles = File.ReadAllLines(ltxtpath + @"\ofp");
                int fcount = 0;
                foreach (string s in openedFiles)
                    if (File.Exists(s))
                    {
                        fcount++;
                        AddFile(s, true);
                    }
                if (fcount == 0)
                    AddFile("", true);

            }
            catch (FileNotFoundException) { }
            catch { SaveOptions(); }
        }

        public void SaveOptions() {
            bool maximized = WindowState == FormWindowState.Maximized;
            if (!maximized) {
                Settings.Default.Location = Location;
                Settings.Default.Size = Size;
            }
            Settings.Default.Font = textEditorRTB.Font;
            Settings.Default.BackColor = textEditorRTB.BackColor;
            Settings.Default.ForeColor = textEditorRTB.ForeColor;
            Settings.Default.ShowEmojis = sepEmojisTSMI.Checked;
            Settings.Default.ProgrammerMode = programmerTSMI.Checked;
            Settings.Default.SmartHighlighting = smartHighlightingTSMI.Checked;
            Settings.Default.OpenLinks = openLinksTSMI.Checked;

            string[] openedFiles = new string[cachedFiles.Count];
            for (int i = 0; i < cachedFiles.Count; i++)
                openedFiles[i] = cachedFiles[i].Path; //es muy cutre, pero no hay otra :(
            File.WriteAllLines(ltxtpath + @"\ofp", openedFiles); //así no hay excepción...

            Settings.Default.Maximized = maximized;

            try
            { Settings.Default.Save(); }
            catch (FileNotFoundException) { }
            catch (Exception) { SetStatus(Resources.ssaveerror, StatusTypes.Error); }
        }

        #endregion

        #region Tool Strip Menu Items

        void newTSMI_Click(object sender, EventArgs e) { AddFile(); }

        void openTSMI_Click(object sender, EventArgs e) { OpenFile(); }

        void saveTSMI_Click(object sender, EventArgs e) { Save(); }

        void saveAllTSMI_Click(object sender, EventArgs e)
        {
            int li = textEditorTC.SelectedIndex;
            for (int i = 0; i < cachedFiles.Count; i++)
            {
                textEditorTC.SelectedIndex = i;
                Save();
            }
            textEditorTC.SelectedIndex = li;
        }

        void saveAsTSMI_Click(object sender, EventArgs e) { SaveAs(); }

        void styleTSMI_Click(object sender, EventArgs e) { new StyleF().Show(); }

        void programmerTSMI_Click(object sender, EventArgs e) { SaveOptions(); }

        void smartHighlightingTSMI_Click(object sender, EventArgs e) { SaveOptions(); }

        void showincmsTSMI_Click(object sender, EventArgs e) {
        	string neiperm = "Not enough permissions. Please run Light Text as administrador";
        	string neipermt = "Not enough permissions";
    		string ltxt = @"*\shell\LightText";
    		
        	if (showincmsTSMI.Checked)
		    	try {
		        	var rk = Registry.ClassesRoot.OpenSubKey(ltxt);
		        	if (rk == null) {
		        		Registry.ClassesRoot.CreateSubKey(ltxt);
		        		rk = Registry.ClassesRoot.OpenSubKey(ltxt, true);
		        		
		        		var exepath =  "\"" + Application.ExecutablePath + "\"";
		        		
		        		rk.SetValue(null, "Editar con Light Text"); //TODO multiple languages
		        		rk.SetValue("Icon", exepath + ",0");
		        		rk.SetValue("Position", "Top");
		        		
		        		rk.CreateSubKey("command");
		        		rk.OpenSubKey("command", true).SetValue(null, exepath + " \"%1\"");
		        		
		        		showincmsTSMI.Checked = true;
		    		}
		    	} catch (UnauthorizedAccessException)
        		{ MessageBox.Show(neiperm, neipermt, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        	else 
        		try {
        			var rk = Registry.ClassesRoot.OpenSubKey(@"*\shell", true);
        			rk.DeleteSubKeyTree("LightText");
        			showincmsTSMI.Checked = false;
        		}
        		catch (UnauthorizedAccessException)
	        	{ MessageBox.Show(neiperm, neipermt, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void sepEmojisTSMI_CheckedChanged(object sender, EventArgs e) {
            splitContainer.Panel2Collapsed = !sepEmojisTSMI.Checked;
            SaveOptions();
        }

        void openLinksTSMI_Click(object sender, EventArgs e) { SaveOptions(); }

        void closeCurrentTabTSMI_Click(object sender, EventArgs e) { RemoveTab(textEditorTC.SelectedIndex); }

        void closeTabTSMI_Click(object sender, EventArgs e) { RemoveTab(clickedTab); }

        int clickedTab = -1;

        void textEditorTC_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                for (int i = 0; i < textEditorTC.TabCount; i++)
                    if (textEditorTC.GetTabRect(i).Contains(e.Location))
                        clickedTab = i;
        }

        void anyEditTSMI_Click(object sender, EventArgs e) { new CountSearchReplaceF().Show(); }

        void tutorialTSMI_Click(object sender, EventArgs e) { new TutorialF().Show(); }

        void supportTSMI_Click(object sender, EventArgs e) {
            Process.Start("http://lonamiwebs.github.io/contacto.php?t=software&q=ltxt");
        }


        #region Encoding checking and unchecking

        void utf7TSMI_Click(object sender, EventArgs e) {
            ResetEncodingTSMI();
            utf7TSMI.Checked = true;
        }

        void utf8TSMI_Click(object sender, EventArgs e) {
            ResetEncodingTSMI();
            utf8TSMI.Checked = true;
        }

        void utf32TSMI_Click(object sender, EventArgs e) {
            ResetEncodingTSMI();
            utf32TSMI.Checked = true;
        }

        void unicodeTSMI_Click(object sender, EventArgs e) {
            ResetEncodingTSMI();
            unicodeTSMI.Checked = true;
        }

        void bigendianTSMI_Click(object sender, EventArgs e) {
            ResetEncodingTSMI();
            bigendianTSMI.Checked = true;
        }

        void asciiTSMI_Click(object sender, EventArgs e) {
            ResetEncodingTSMI();
            asciiTSMI.Checked = true;
        }

        #endregion

        #endregion

        #region Text Editor Context Menu Strip

        void copyTSMI_Click(object sender, EventArgs e)
        {
            string st = textEditorRTB.SelectedText;
            if (st.Length > 0)
                Clipboard.SetText(st);
        }

        void cutTSMI_Click(object sender, EventArgs e)
        {
            string st = textEditorRTB.SelectedText;
            if (st.Length > 0)
            {
                Clipboard.SetText(st);
                textEditorRTB.Text =
                    textEditorRTB.Text.Remove(textEditorRTB.SelectionStart, textEditorRTB.SelectionLength);
            }
        }

        void pasteTSMI_Click(object sender, EventArgs e)
        {
            textEditorRTB.Text =
                textEditorRTB.Text.Insert(textEditorRTB.SelectionStart, Clipboard.GetText());
        }

        void undoTSMI_Click(object sender, EventArgs e)
        {
            textEditorRTB.Undo();
        }

        void redoTSMI_Click(object sender, EventArgs e)
        {
            textEditorRTB.Redo();
        }

        #endregion
        
        #region Tab control

        void RefreshTabs()
        {
            if (cachedFiles.Count == 0)
                AddTab(new CachedFile());
            else
                foreach (CachedFile cf in cachedFiles)
                    AddTab(cf);

            bool hasnull = textEditorTC.TabPages[0].Text == ">null<";

            if (hasnull)
            {
                textEditorTC.TabPages[1].Controls.Add(textEditorRTB);
                textEditorTC.TabPages.RemoveAt(0);
            }

            int i = textEditorTC.SelectedIndex;

            SetContent(i);

            changingTab = false;
            refreshingTabs = false;

            textEditorTC.TabPages[i].Controls.Add(textEditorRTB);
            CheckFileState(i);
        }

        void RefreshTab(int index)
        {
            if (!refreshingTabs)
            {
                textEditorTC.TabPages[index].Controls.Add(textEditorRTB);

                changingTab = true;
                SetContent(index);
                changingTab = false;

                textEditorRTB.Focus();
                CheckFileState(index);
            }
        }

        void SetContent(int index) {
            if (index >= cachedFiles.Count)
                return;

            string content = cachedFiles[index].Content;

            if (content.StartsWith(@"{\rtf"))
                textEditorRTB.Rtf = content;
            else
                textEditorRTB.Text = content;
        }

        void AddFile(string path = "", bool loadingOptions = false)
        {
            string content = path != "" ? File.ReadAllText(path) : "";
            CachedFile cf = new CachedFile(content, path);
            cachedFiles.Add(cf);

            if (!loadingOptions)
                AddTab(cf);
        }

        void AddTab(CachedFile cf)
        {
            changingTab = true;
            int i = textEditorTC.TabPages.Count;

            string name = "nuevo " + i;
            if (cf.Path != "")
                name = Path.GetFileName(cf.Path);

            textEditorTC.TabPages.Add(name);
            textEditorTC.SelectedIndex = i;

            changingTab = false;

            RefreshTab(i);
        }

        //RemoveTab (and file)
        void RemoveTab(int index)
        {
            CachedFile cf = cachedFiles[index];
            if (!cf.Saved)
                if (MessageBox.Show(Resources.closingnosave, Resources.closingnosavet, MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    Save();

            if (textEditorTC.TabPages.Count == 1)
                AddFile();

            cachedFiles.RemoveAt(index);
            textEditorTC.TabPages.RemoveAt(index);

            if (textEditorTC.TabPages.Count == index)
                textEditorTC.SelectedIndex = index - 1;
            else
                textEditorTC.SelectedIndex = index;

            SaveOptions();
        }

        void textEditorTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = textEditorTC.SelectedIndex;
            if (!changingTab)
                RefreshTab(i);
        }

        #endregion

        #region Open file

        void OpenFile() {
            ofd.Filter = filterload;
            if (ofd.ShowDialog() == DialogResult.OK)
                foreach(string f in ofd.FileNames)
                    OpenFile(f);
        }

        void OpenFile(string path)
        {
            try
            {
                for (int i = 0; i < cachedFiles.Count; i++)
                    if (cachedFiles[i].Path == path) { //already in
                        cachedFiles[i].Content = File.ReadAllText(path);
                        textEditorTC.SelectedIndex = i;
                        RefreshTab(i);
                        return;
                    }

                AddFile(path);
                SetEncoding(GetEncoding(path));
                SetStatus(Resources.opensuccess, StatusTypes.Success);

                RefreshTab(textEditorTC.SelectedIndex);
                SaveOptions();

                if (Path.GetExtension(path) == ".rtf")
                    textEditorRTB.LoadFile(path);
            }
            catch { SetStatus(Resources.openerror + " " + path, StatusTypes.Error); }
        }

        #endregion

        #region Save file

        bool SaveAs()
        {
            sfd.Filter = filter;
            sfd.FilterIndex = 0;
            if (sfd.ShowDialog() == DialogResult.OK)
                return Save(sfd.FileName);
            else
                return false;
        }

        bool Save(string path = "")
        {
            int index = textEditorTC.SelectedIndex;
            if (path == "")
                path = cachedFiles[index].Path;
            if (path == "")
                return SaveAs();
            else
                try
                {
                    Encoding encoding = RetrieveEncoding();

                    if (Path.GetExtension(path) == ".rtf")
                        textEditorRTB.SaveFile(path);
                    else
                        if (IsKnownEncoding(encoding))
                            using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Create), encoding))
                                sw.Write(textEditorRTB.Text);
                        else
                            File.WriteAllText(path, textEditorRTB.Text);

                    cachedFiles[index].Path = path;
                    cachedFiles[index].Saved = true;
                    textEditorTC.TabPages[index].Text = Path.GetFileName(path);

                    SaveOptions();
                    SetStatus(Resources.savesuccess + " " + path, StatusTypes.Success);

                    return true;
                }
                catch (UnauthorizedAccessException) {
                    SetStatus(Resources.neiperm, StatusTypes.Error);
                }
                catch (Exception) { SetStatus(Resources.couldnotsave, StatusTypes.Error); }
            return false;
        }

        #endregion

        #region Information

        void SetStatus(string message, StatusTypes type) {
            switch (type) {
                case StatusTypes.Success:
                    infoTSSL.ForeColor = Color.Green;
                    break;
                case StatusTypes.Information:
                    infoTSSL.ForeColor = Color.DarkBlue;
                    break;
                case StatusTypes.Warning:
                    infoTSSL.ForeColor = Color.Orange;
                    break;
                case StatusTypes.Error:
                    infoTSSL.ForeColor = Color.Red;
                    break;
                default:
                    infoTSSL.ForeColor = Color.Black;
                    break;
            }

            infoTSSL.Text = message;
            fileInfoTSSL.Text = GetFileInfo();
        }

        string GetFileInfo() {
            string text = textEditorRTB.Text;

            int lines = text.Split('\n').Length;
            int chars = text.Length;

            int sstart = textEditorRTB.SelectionStart;
            int slength = textEditorRTB.SelectionLength;
            int send = sstart + slength;

            int sline = textEditorRTB.GetLineFromCharIndex(sstart) + 1;

            if (slength == 0)
                return Resources.lines + " " + lines + " (" + sline + ") - " + Resources.chars + " " + chars +
                    " - " + Resources.selection + " " + sstart;
            else
                return Resources.lines + " " + lines + " (" + sline + ") - " + Resources.chars + " " + chars +
                    " - " + Resources.selection + " " + sstart + ", " + send + " (" + slength + ")";
        }

        void CheckFileState(int index)
        {
            if (index >= cachedFiles.Count)
                return;

            if (cachedFiles[index].Saved)
                SetStatus(Resources.cursaved, StatusTypes.Information);
            else
                SetStatus(Resources.curnotsaved, StatusTypes.Warning);
        }

        #endregion

        #region Text editor handlers

        void textEditorTB_TextChanged(object sender, EventArgs e)
        {
            fileInfoTSSL.Text = GetFileInfo();
            if (changingTab)
                return;

            int index = textEditorTC.SelectedIndex;
            cachedFiles[index].Content = textEditorRTB.Rtf;
            cachedFiles[index].Saved = false;
            SetStatus(Resources.curnotsaved, StatusTypes.Warning);

            if (smartHighlightingTSMI.Checked)
                Highlight();
        }

        void textEditorTB_Click(object sender, EventArgs e) {
            fileInfoTSSL.Text = GetFileInfo();
        }

        void textEditorRTB_KeyDown(object sender, KeyEventArgs e)
        {
            int i = textEditorRTB.SelectionStart;
            int l = textEditorRTB.GetLineFromCharIndex(i);
            int t = LineTabs(l);

            if (!programmerTSMI.Checked)
                return;

            if (aut)
            	return;
            
        	bfss = i;

            aut = true;
            if (e.KeyCode == Keys.Enter) {
            	e.Handled = e.SuppressKeyPress = true;
                SendKeys.SendWait("{ENTER}");
                SendKeys.SendWait("{TAB " + t + "}");
            }

            if (e.KeyCode == Keys.Home) {
            	e.Handled = e.SuppressKeyPress = true;
                SendKeys.SendWait("{HOME}");
                SendKeys.SendWait("{RIGHT " + t + "}");
                wsh = true;
            }
            aut = false;
        }

        int bfss = -1; // before selection start
        bool aut; // working automatly ?
        bool wsh; // was the key home ??

        void textEditorTB_KeyUp(object sender, KeyEventArgs e)
        {
            fileInfoTSSL.Text = GetFileInfo();
            int i = textEditorRTB.SelectionStart;
            int l = textEditorRTB.GetLineFromCharIndex(i);
            int t = LineTabs(l);

            if (wsh) {
            	if (!aut && bfss == i)
            	    SendKeys.Send("{LEFT " + t + "}");
            	wsh = false;
            }
        }

        void textEditorRTB_LinkClicked(object sender, LinkClickedEventArgs e) {
            if (openLinksTSMI.Checked)
                Process.Start(e.LinkText);
        }

        #endregion
        
        public static void m(object msg = null) {
        	Debug.WriteLine(msg == null ? "=======================" : msg.ToString());
        }

        #region Encoding utilities

        //http://stackoverflow.com/questions/3825390/effective-way-to-find-any-files-encoding
        /// <summary>
        /// Retrieve encoding from file
        /// </summary>
        /// <param name="filename">File to be inspected</param>
        /// <returns>File encoding</returns>
        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM (Byte Order Mark)
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open)) file.Read(bom, 0, 4);

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }

        /// <summary>
        /// Retrieve encoding from which encoding is selected on the tool strip menu items
        /// </summary>
        /// <returns>Selected encoding</returns>
        Encoding RetrieveEncoding()
        {
            Encoding encoding = null;

            if (utf7TSMI.Checked)
                encoding = Encoding.UTF7;
            if (utf8TSMI.Checked)
                encoding = Encoding.UTF8;
            if (utf32TSMI.Checked)
                encoding = Encoding.UTF32;
            if (unicodeTSMI.Checked)
                encoding = Encoding.Unicode;
            if (bigendianTSMI.Checked)
                encoding = Encoding.BigEndianUnicode;
            if (asciiTSMI.Checked)
                encoding = Encoding.ASCII;

            return encoding;
        }

        /// <summary>
        /// Check with the given encoding the correspondant tool strip menu item
        /// </summary>
        /// <param name="encoding">Encoding to be checked</param>
        void SetEncoding(Encoding encoding)
        {
            ResetEncodingTSMI();

            if (encoding == Encoding.UTF7)
                utf7TSMI.Checked = true;
            if (encoding == Encoding.UTF8)
                utf8TSMI.Checked = true;
            if (encoding == Encoding.UTF32)
                utf32TSMI.Checked = true;
            if (encoding == Encoding.Unicode)
                unicodeTSMI.Checked = true;
            if (encoding == Encoding.BigEndianUnicode)
                unicodeTSMI.Checked = true;
            if (encoding == Encoding.ASCII)
                asciiTSMI.Checked = true;
        }

        /// <summary>
        /// Uncheck all encodings
        /// </summary>
        void ResetEncodingTSMI()
        {
            utf7TSMI.Checked = utf8TSMI.Checked = utf32TSMI.Checked = unicodeTSMI.Checked =
                bigendianTSMI.Checked = asciiTSMI.Checked = false;
        }

        /// <summary>
        /// Determine if encoding is a known encoding
        /// </summary>
        /// <returns>true if it is known, false if not</returns>
        bool IsKnownEncoding(Encoding encoding)
        {
            return encoding == Encoding.UTF7 || encoding == Encoding.UTF8 || encoding == Encoding.UTF32 ||
                encoding == Encoding.Unicode || encoding == Encoding.BigEndianUnicode || encoding == Encoding.ASCII;
        }

        #endregion

        #region Text editor utilities

        int LineTabs(int lineIndex)
        {
            //Get current line
            string line = textEditorRTB.Text.Split('\n')[lineIndex];
            //Split to chars that are not TABs (so we get first tabs one way, otherwise just use line.Count)
            string fl = Regex.Split(line, "[^\t]+")[0];
            //Return count of tabs in the first part of the line
            return fl.Count(c => c == '\t');
        }

        #endregion

        #region Extra panel

        void emojisLV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i = emojisLV.SelectedIndices[0];
                Clipboard.SetText(emojisLV.Items[i].Text);
            }
            catch { }
        }

        #endregion

        #region Form closing (plus save options events)

        void MainF_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < cachedFiles.Count; i++)
            {
                CachedFile cf = cachedFiles[i];
                if (!cf.Saved) {
                    textEditorTC.SelectedIndex = i;
                    DialogResult r = MessageBox.Show(Resources.closingnosave, Resources.closingnosavet, MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (r == DialogResult.Yes)
                        Save();
                    else if (r == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        void MainF_FormClosed(object sender, FormClosedEventArgs e) { SaveOptions(); }

        void MainF_ResizeEnd(object sender, EventArgs e) { SaveOptions(); }

        #endregion

        #region Smart Highlighting

        void Highlight() {
            int lastPos = textEditorRTB.SelectionStart;
            int lastLength = textEditorRTB.SelectionLength;

            textEditorRTB.SelectionProtected = true;

            Color newBg = textEditorRTB.BackColor.MSOD();

            textEditorRTB.SelectAll();
            textEditorRTB.SelectionBackColor = textEditorRTB.BackColor;
            string t = textEditorRTB.Text;
            //Parenthesis Opened/Closed Indicies
            List<int> poi = TU.Search("(", t);
            List<int> pci = TU.Search(")", t);

            //Square Brackets Opened/Closed Indicies
            List<int> sboi = TU.Search("[", t);
            List<int> sbci = TU.Search("]", t);

            //Curly Brackets Opened/Closed Indicies
            List<int> cboi = TU.Search("{", t);
            List<int> cbci = TU.Search("}", t);

            //HTML Tags OpenedClosed Indicies
            List<int> htoi = TU.Search("<", t);
            List<int> htci = TU.Search(">", t);

            for (int i = 0; i < poi.Count; i++)  {
                int l = i < pci.Count ? pci[i] - poi[i] + 1 : 1;
                textEditorRTB.Select(poi[i], l);
                textEditorRTB.SelectionBackColor = newBg;
            }
            for (int i = 0; i < sboi.Count; i++) {
                int l = i < sbci.Count ? sbci[i] - sboi[i] + 1 : 1;
                textEditorRTB.Select(sboi[i], l);
                textEditorRTB.SelectionBackColor = newBg;
            }
            for (int i = 0; i < cboi.Count; i++) {
                int l = i < cbci.Count ? cbci[i] - cboi[i] + 1 : 1;
                textEditorRTB.Select(cboi[i], l);
                textEditorRTB.SelectionBackColor = newBg;
            }
            for (int i = 0; i < htoi.Count; i++) {
                int l = i < htci.Count ? htci[i] - htoi[i] + 1 : 1;
                textEditorRTB.Select(htoi[i], l);
                textEditorRTB.SelectionBackColor = newBg;
            }

            textEditorRTB.Select(lastPos, lastLength);

            textEditorRTB.SelectionProtected = false;
        }

        #endregion

        //Margi debajo
        #region ¿Multiselect?
        List<string> _Words = new List<string>();
        void textEditorRTB_MouseUp(object sender, MouseEventArgs e)
        {
            //Tal vez pueda hacer algo con esto para un multiselect. Haría muy potente Light Text
            textEditorRTB.SelectionBackColor = Color.Black;
            textEditorRTB.SelectionColor = Color.White;
            _Words.Add(textEditorRTB.SelectedText);
        }
        #endregion

        void checkUpdatesB_Click(object sender, EventArgs e)
        {
            new UpdateChecker.UpdateChecker(Assembly.GetExecutingAssembly().Location, "ltxt").Show();
        }

        //ToolStripControlHost statusTrackBar;

        //I can add font size in Load! Something like zoom? Maybe Ctrl + MouseWheel = + zoom, textEdito.fontsize = fontSize * zoom;
        //statusTrackBar = new ToolStripControlHost(new TrackBar());
        //statusStrip.Items.Add(statusTrackBar);
    }
}

namespace ExtensionMethods
{
    public static class ColorMethods
    {   

        /// <summary>
        /// Retrieve if it would be better Black Or White
        /// </summary>
        /// <param name="color">Color to check BOW with</param>
        /// <returns></returns>
        public static Color BOW(this Color color)
        {
            int r = color.R;
            int g = color.G;
            int b = color.B;

            int rgb = r + g + b;
            int max = 255 * 3;

            if (rgb < (int)max / 2)
                return Color.White;
            else
                return Color.Black;
        }


        /// <summary>
        /// Make Shiner Or Darker a given color
        /// </summary>
        /// <param name="color">Color to MSOD</param>
        /// <param name="amount">Amount of color to be substracted</param>
        /// <returns></returns>
        public static Color MSOD(this Color color, int amount = 40)
        {
            bool add = true;
            if (color.BOW() == Color.Black)
                add = false;
            
            int r = color.R;
            int g = color.G;
            int b = color.B;

            if (add)
            {
                for (int i = 0; i < amount; i++)
                    if (r < 255)
                        r++;
                for (int i = 0; i < amount; i++)
                    if (g < 255)
                        g++;
                for (int i = 0; i < amount; i++)
                    if (b < 255)
                        b++;
            }
            else
            {
                for (int i = 0; i < amount; i++)
                    if (r > 0)
                        r--;
                for (int i = 0; i < amount; i++)
                    if (g > 0)
                        g--;
                for (int i = 0; i < amount; i++)
                    if (b > 0)
                        b--;
            }

            return Color.FromArgb(r, g, b);
        }
    }
}
