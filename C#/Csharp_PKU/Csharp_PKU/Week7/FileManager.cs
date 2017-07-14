using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Csharp_PKU.Week7
{

    /// <summary>
    /// Form1 的摘要说明。
    /// </summary>
    public class FileManager : System.Windows.Forms.Form
    {
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private SplitContainer splitContainer1;
        private TreeView treeView1;
        private ListView listView1;

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FileManager()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();

            //
            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码
            //
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Blue;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 500);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(266, 500);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);

            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 500);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FileManager
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FileManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.Run(new Form1());
        //}

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //注意，添加TreeView控件，Dock属性设为Left，再添加Splitter控件，同样将Dock属性设为Left。最后添加ListView控件，命名为listView，Dock属性设为Fill。
            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            listView1.Columns.Add("Column 1", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", 100, HorizontalAlignment.Center);

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Bitmap.FromFile(@"Week7\folder.bmp"));
            imageListSmall.Images.Add(Bitmap.FromFile(@"Week7\file.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile(@"Week7\folder.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile(@"Week7\file.bmp"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            FillDrivers();

        }

        private void FillDrivers()
        {
            //获取逻辑驱动器

            string[] LogicDrives = System.IO.Directory.GetLogicalDrives();

            TreeNode[] cRoot = new TreeNode[LogicDrives.Length];

            for (int i = 0; i < LogicDrives.Length; i++)
            {

                TreeNode drivesNode = new TreeNode(LogicDrives[i]);

                treeView1.Nodes.Add(drivesNode);

                if (LogicDrives[i] != "A:\\" && LogicDrives[i] != "B:\\")
                    getSubNode(drivesNode, true);

            }
        }

        private void getSubNode(TreeNode PathName, bool isEnd)
        {

            if (!isEnd)
                return; //exit this

            try
            {
                TreeNode curNode;
                DirectoryInfo curDir = new DirectoryInfo(PathName.FullPath);

                DirectoryInfo[] subDir = curDir.GetDirectories();

                foreach (DirectoryInfo d in subDir)
                {
                    curNode = new TreeNode(d.Name);
                    PathName.Nodes.Add(curNode);

                    //getSubNode(curNode,false);
                }
            }
            catch { }

        }

        private void treeView1_AfterExpand(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            try
            {
                foreach (TreeNode tn in e.Node.Nodes)
                {
                    if (!tn.IsExpanded)
                        getSubNode(tn, true);
                }
            }
            catch { }
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            listView1.Items.Clear();

            DirectoryInfo selDir = new DirectoryInfo(e.Node.FullPath);

            DirectoryInfo[] listDir;

            FileInfo[] listFile;

            listDir = selDir.GetDirectories();
            listFile = selDir.GetFiles();

            foreach (DirectoryInfo d in listDir)
            {
                ListViewItem item1 = new ListViewItem(d.Name, 0);
                //item1.Checked = d.;
                //item1.SubItems.Add(d.Name);
                item1.SubItems.Add(d.Extension);
                item1.SubItems.Add(d.CreationTime.ToShortDateString());
                listView1.Items.Add(item1);
            }

            foreach (FileInfo d in listFile)
            {
                ListViewItem item1 = new ListViewItem(d.Name, 1);
                item1.Checked = d.IsReadOnly;
                //item1.SubItems.Add(d.Name);
                item1.SubItems.Add(d.Extension);
                item1.SubItems.Add(d.CreationTime.ToShortDateString());
                listView1.Items.Add(item1);
            }

        }

    }

}
