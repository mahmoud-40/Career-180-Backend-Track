namespace Notepad
{
    public partial class MyNotepad : Form
    {
        private string path = null;
        public MyNotepad()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    rtb_body.SaveFile(saveFD.FileName);
                }
            }
            else
            {
                rtb_body.SaveFile(path);
                rtb_body.Clear();
                path = null;
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                rtb_body.LoadFile(openFD.FileName);
                path = openFD.FileName;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            rtb_body.Clear();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_body.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    Save_Click(sender, e);
                }
                else
                {
                    rtb_body.Clear();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                rtb_body.SaveFile(saveFD.FileName);
                rtb_body.Clear();
                path = null;
            }
        }

        private void change_font_button_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (rtb_body.SelectedText != "")
                {
                    rtb_body.SelectionFont = fontDialog.Font;
                }
                else
                {
                    rtb_body.Font = fontDialog.Font;
                }
            }
        }

        private void change_color_button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (rtb_body.SelectedText != "")
                {
                    rtb_body.SelectionColor = colorDialog.Color;
                }
                else
                {
                    rtb_body.ForeColor = colorDialog.Color;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_button_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_Click(sender, e);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_body.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    Save_Click(sender, e);
                }
                else
                {
                    rtb_body.Clear();
                }
            }

            this.Close();
        }

        private void rtb_body_TextChanged(object sender, EventArgs e)
        {
        }

        private void background_color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (rtb_body.SelectedText != "")
                {
                    rtb_body.SelectionBackColor = colorDialog.Color;
                }
                else
                {
                    rtb_body.BackColor = colorDialog.Color;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show "By Mahmoud Abdulmawlaa - 2024"
            MessageBox.Show("By Mahmoud Abdulmawlaa - 2024", "About");
        }

        private void MyNotepad_Load(object sender, EventArgs e)
        {

        }
    }
}
