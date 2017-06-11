using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bugreprot解析 : Form
    {
        public Bugreprot解析()
        {
            InitializeComponent();
        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.FileName = "";
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "txtファイル(*.txt)|logファイル(*.log)|すべてのファイル(*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.Title = "開くファイルを選択してください";
            dialog.RestoreDirectory = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Clear
                label1.Text = "";

                Console.WriteLine("Read --- " + dialog.FileName + " ---");
                selectedFileName.Text = dialog.FileName;
                System.IO.StreamReader stream = null;
                try
                {
                    stream = new System.IO.StreamReader(dialog.FileName);

                    string line;
                    int count = 0;
                    // label1.Text = stream.ReadLine();
                    while ((line = stream.ReadLine()) != null)
                    {
                        label1.Text += line + "\n";

                        // Escape
                        if (count++ > 100) break; //OOPS! 500 line is limit?
                    }
                }
                finally
                {
                    if (stream != null) stream.Close();
                }
            }
        }
    }
}
