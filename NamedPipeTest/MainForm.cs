using System;
using System.Data;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeTest {
    public partial class MainForm : Form  {

        bool running = false;
        NamedPipeClientStream stream;

        public static string[] getAllNamedPipes() {
            string[] pipes = null;

            // retrieve all namedpipes
            try {
                pipes = Directory.GetFiles(@"\\.\pipe\");
            } catch (DirectoryNotFoundException) {
                MessageBox.Show("Could not retrieve pipes, will shutdown application");
                Application.Exit();
            }

            // return only the names instead of the complete path
            return pipes.Select((s) => {
                int index = s.LastIndexOf("\\");
                return s.Remove(0, index + 1);
            }).ToArray();
        }

        public MainForm() {
            InitializeComponent();

            refreshPipes();
        }        

        private void b_refresh_Click(object sender, EventArgs e) {
            refreshPipes();
        }

        private void b_connect_Click(object sender, EventArgs e) {

            if (b_connect.Text == "disconnect") {
                disconnect();
                b_connect.Text = "connect";
                b_send.Enabled = false;
                cb_pipes.Enabled = true;
                b_refresh.Enabled = true;
                tb_input.Enabled = false;
            } else {
                string pipeName = cb_pipes.SelectedItem.ToString();
                connect(pipeName);
                b_connect.Text = "disconnect";
                b_send.Enabled = true;
                cb_pipes.Enabled = false;
                b_refresh.Enabled = false;
                tb_input.Enabled = true;
                rtb_Output.Clear();
            }
        }

        private void b_send_Click(object sender, EventArgs e) {
            var sw = new StreamWriter(stream);

            sw.WriteLine(tb_input.Text);
            sw.Flush();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            disconnect();
        }

        private void refreshPipes() {
            cb_pipes.Items.Clear();
            
            cb_pipes.Items.AddRange(getAllNamedPipes());

            cb_pipes.SelectedIndex = cb_pipes.Items.Count - 1;
        }                

        /// <summary>
        /// Connects to the namedpipe with the given name
        /// </summary>
        /// <param name="pipename">Name of the namedpipe</param>
        private void connect(string pipename) {
           
            stream = new NamedPipeClientStream(".", pipename, PipeDirection.InOut, PipeOptions.Asynchronous);
            
            stream.Connect(2000);

            Task.Run(() => pollNamedPipe(stream));
            
        }        

        /// <summary>
        /// Reads all incoming text from connected namedpipe and writes it to the RichTextBox
        /// </summary>
        /// <param name="stream"></param>
        private void pollNamedPipe(Stream stream) {
            StreamReader sr = new StreamReader(stream);
            
            running = true;

            while (running) {
                
                string text = null;

                try {
                    text = sr.ReadLine();
                } catch (Exception ex) {
                    if(ex is IOException)
                        return;
                    if (ex is ObjectDisposedException)
                        return;
                } 

                if(!string.IsNullOrEmpty(text))
                    WriteLine(text);                
            }
        }        

        /// <summary>
        /// Adds a line of the RichTextBox with autoscrolling
        /// </summary>
        /// <param name="text"></param>
        public void WriteLine(string text) {

            Invoke(new Action(() => {
                                                                
                rtb_Output.AppendText(text + "\n");
                if(cb_Autoscroll.Checked) {
                    rtb_Output.SelectionStart = rtb_Output.TextLength;
                    rtb_Output.ScrollToCaret();
                }

            }));
        }

        private void disconnect() {
            if(stream != null && stream.IsConnected) {
                stream.Close();
                stream.Dispose();
                running = false;
            }
        }
        
    }  
}
