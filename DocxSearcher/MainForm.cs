using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace DocxSearcher
{
    public partial class MainForm : Form
    {
        string source = @"C:\Users\falko\Desktop\output\";
        //string destFile = @"C:\Temp\tempFolder\";

        public MainForm()
        {
           
            InitializeComponent();
            this.txtDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnSearchDirectory_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.SelectedPath = this.txtDirectory.Text;

            if (fbd.ShowDialog(this) == DialogResult.OK)
                this.txtDirectory.Text = fbd.SelectedPath;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.resultListView.Items.Clear();
            int counter = 0;

            

            try
            {
                foreach (var filePath in Search(this.txtDirectory.Text, this.txtSearch.Text, this.cBoxUseSubdirectories.Checked, this.cBoxCaseSensitive.Checked, this.rBtnRegex.Checked))
                {
                    int i=0;
                    ++i;
                    //ListViewItem item = resultListView.Items.Add((++counter).ToString());
                    var item2 = (++counter);
                    item2.ToString();
                    var file = new FileInfo(filePath);
                    //var fileName = filePath;

                    // Console.WriteLine(filePath);
                    //string[] files = Directory.GetFiles(filePath);
                    //string[] files = Directory.GetFiles(filePath);
                    // foreach (String item in filePath)
                    // {

                    //  }

                    // Use Path class to manipulate file and directory paths.
                    //string sourceFile = System.IO.Path.Combine(filePath, fileName);
                    //string destFile = System.IO.Path.Combine(source, filePath);
                    File.Copy(filePath, source + Path.GetFileName(filePath));
                    //ListViewItem item = resultListView.Items.Add((resultListView.Items.Count + 1).ToString());
                    //item.ToString();
                    this.resultListView.Items.Add(new ListViewItem(new string[] { item2.ToString(),file.Name, string.Format("{0:0.0}", file.Length / 1024d), file.FullName }));
                    //Console.WriteLine("\n");
                    //File.Copy(filePath, source);
                    //System.IO.File.Copy(sourceFile, source, true);
                    //Console.WriteLine(item2.ToString() + file);
                    
                    // Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Exception details:\n{0}", ex), string.Format("Exception '{0}' occurred.", ex.GetType()), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resultListView_ItemActivate(object sender, EventArgs e)
        {
            string filePath = ((ListView)sender).SelectedItems[0].SubItems[3].Text;
            if (File.Exists(filePath))
                Process.Start(filePath);
        }

        private static IEnumerable<string> Search(string directory, string searchString, bool searchSubdirectories, bool caseSensitive, bool useRegex)
        {
            var isMatch = useRegex ? new Predicate<string>(x => Regex.IsMatch(x, searchString, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase))
                : new Predicate<string>(x => x.IndexOf(searchString, caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) >= 0);

            foreach (var filePath in Directory.GetFiles(directory, "*.docx", searchSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly))
            {
                string docxText;
                //Console.WriteLine(filePath);
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    docxText = new DocxToStringConverter(stream).Convert();

                if (isMatch(docxText))
                    yield return filePath;
            }
        }

        private void resultListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
