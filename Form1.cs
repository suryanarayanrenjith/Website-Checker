using System.Media;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Website_Checker
{
    public partial class Form1 : Form
    {
        private NotifyIcon notifyIcon;

        public Form1()
        {
            InitializeComponent();
            InitializeTrayIcon();
            textBox2.Text = "curl";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeTrayIcon()
        {
            Icon customIcon = Properties.Resources.checkbox;

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = customIcon;
            notifyIcon.Text = "Website Checker App";

            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem showMenuItem = new ToolStripMenuItem("Show");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");

            showMenuItem.Click += ShowMenuItem_Click;
            exitMenuItem.Click += ExitMenuItem_Click;

            contextMenuStrip.Items.Add(showMenuItem);
            contextMenuStrip.Items.Add(exitMenuItem);

            notifyIcon.ContextMenuStrip = contextMenuStrip;

            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;

            UpdateTrayIconVisibility();
        }

        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void UpdateTrayIconVisibility()
        {
            notifyIcon.Visible = checkBox1.Checked;
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Minimized;
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.Trim();

            if (!IsValidUrl(url))
            {
                MessageBox.Show("Please enter a valid website URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a valid website URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            if (!url.Contains("www."))
            {
                url = url.Insert(url.IndexOf("//") + 2, "www.");
            }

            string userAgent = textBox2.Text.Trim();

            bool isWebsiteUp = CheckWebsiteStatus(url, userAgent);

            if (isWebsiteUp)
            {
                MessageBox.Show("Website is UP!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Website is DOWN!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValidUrl(string url)
        {
            string pattern = @"^(https?://)?([\da-z.-]+)\.([a-z.]{2,6})([/\w .-]*)*/?$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(url);
        }

        private bool CheckWebsiteStatus(string url, string userAgent)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.UserAgent = userAgent;

                request.Timeout = 10000;

                request.AllowAutoRedirect = true;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userAgent = textBox2.Text.Trim();
            MessageBox.Show($"User-Agent set to: {userAgent}", "User-Agent Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "curl";
            MessageBox.Show("User-Agent reset to 'curl'", "User-Agent Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTrayIconVisibility();
        }
    }
}
