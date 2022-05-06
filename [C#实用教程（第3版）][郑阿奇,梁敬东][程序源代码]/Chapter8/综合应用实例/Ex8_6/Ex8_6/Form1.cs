using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ex8_6
{
    public partial class Form1 : Form
    {
        int nDirLevel = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // 获取所有逻辑盘并列出硬盘中的所有目录
        public void ListDrives()
        {
            TreeNode tn;
            // 获取系统中的所有逻辑盘
            string[] drives = Directory.GetLogicalDrives();
            // 向树视图中添加节点
            tvDir.BeginUpdate();
            for (int i = 0; i < drives.Length; i++)
            {
                tn = new TreeNode(drives[i], 0, 0);
                tvDir.Nodes.Add(tn);            //把创建的节点添加到树视图中
            }
            tvDir.EndUpdate();
            // 把C盘设为当前选择节点
            tvDir.SelectedNode = tvDir.Nodes[0];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListDrives();
        }

        // 列出指定目录下的所有子目录和文件
        private void ListDirsAndFiles(string strDir)
        {
            ListViewItem lvi;
            int nImgIndex;
            string[] items = new string[4];
            string[] dirs;
            string[] files;
            try
            {
                // 获取指定目录下的所有子目录
                dirs = Directory.GetDirectories(@strDir);
                // 获取指定目录下的所有文件
                files = Directory.GetFiles(@strDir);
            }
            catch
            {
                return;
            }
            // 把子目录和文件添加到文件列表视图中
            lvFiles.BeginUpdate();
            lvFiles.Clear();            // 清除列表视图中的所有内容
            // 添加4个列表头
            lvFiles.Columns.AddRange(new ColumnHeader[] { chName, chSize, chType, chTime });
            // 把子目录添加到列表视图中
            for (int i = 0; i < dirs.Length; i++)
            {
                items[0] = Path.GetFileName(dirs[i]);
                items[1] = "";
                items[2] = "文件夹";
                items[3] = Directory.GetLastWriteTime(dirs[i]).ToLongDateString() + "" + Directory.GetLastWriteTime(dirs[i]).ToLongTimeString();
                lvi = new ListViewItem(items, 1);
                lvFiles.Items.Add(lvi);
            }
            // 把文件添加到列表视图中
            for (int i = 0; i < files.Length; i++)
            {
                string ext = (Path.GetExtension(files[i])).ToLower();
                // 根据不同的扩展名，来设定列表项的图标
                switch (ext)
                {
                    case ".doc":
                        nImgIndex = 3;
                        break;
                    case ".docx":
                        nImgIndex = 4;
                        break;
                    case ".txt":
                        nImgIndex = 5;
                        break;
                    case ".rar":
                        nImgIndex = 6;
                        break;
                    case ".zip":
                        nImgIndex = 6;
                        break;
                    case ".html":
                        nImgIndex = 7;
                        break;
                    case ".htm":
                        nImgIndex = 7;
                        break;
                    case ".ini":
                        nImgIndex = 8;
                        break;
                    case ".dll":
                        nImgIndex = 9;
                        break;
                    case ".bat":
                        nImgIndex = 10;
                        break;
                    case ".exe":
                        nImgIndex = 11;
                        break;
                    case ".jpg":
                        nImgIndex = 12;
                        break;
                    case ".gif":
                        nImgIndex = 13;
                        break;
                    default:
                        nImgIndex = 14;
                        break;
                }
                items[0] = Path.GetFileName(files[i]);
                FileInfo fi = new FileInfo(files[i]);
                items[1] = fi.Length.ToString();
                items[2] = ext + "文件";
                items[3] = fi.LastWriteTime.ToLongDateString() + " " + fi.LastWriteTime.ToLongTimeString();
                lvi = new ListViewItem(items, nImgIndex);
                lvFiles.Items.Add(lvi);
            }
            lvFiles.EndUpdate();
        }
        private void tvDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtPath.Text = tvDir.SelectedNode.FullPath;
            ListDirsAndFiles(tvDir.SelectedNode.FullPath);
        }

        //列出指定目录
        private void ListDirs(TreeNode tn, string strDir)
        {
            if (nDirLevel > 4)
            {
                nDirLevel = 0;
                return;
            }
            nDirLevel++;
            string[] arrDirs;
            TreeNode tmpNode;
            try
            {	// 获取指定目录下的所有目录
                arrDirs = Directory.GetDirectories(strDir);
                if (arrDirs.Length == 0) return;
                // 把每一个子目录添加到参数传递进来的树视图节点中
                for (int i = 0; i < arrDirs.Length; i++)
                {
                    tmpNode = new TreeNode(Path.GetFileName(arrDirs[i]), 1, 2);
                    // 对于每一个子目录，都进行递归列举
                    ListDirs(tmpNode, arrDirs[i]);
                    tn.Nodes.Add(tmpNode);
                }
            }
            catch
            {
                return;
            }
        }
        private void tvDir_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ListDirs(e.Node, txtPath.Text.Trim());
        }

        private void lvFiles_DoubleClick(object sender, EventArgs e)
        {
            txtPath.Text = txtPath.Text.Trim() + "\\" + lvFiles.SelectedItems[0].Text;
            ListDirsAndFiles(txtPath.Text.Trim());
        }

        private void miDetail_Click(object sender, EventArgs e)
        {
            lvFiles.View = View.Details;
            lvFiles.Columns[0].Text = "名称";
            lvFiles.Columns[1].Text = "大小";
            lvFiles.Columns[2].Text = "类型";
            lvFiles.Columns[3].Text = "修改日期";
        }

        private void maiMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
