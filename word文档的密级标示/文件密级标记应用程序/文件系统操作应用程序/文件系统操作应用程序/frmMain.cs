using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;


namespace 文件系统操作应用程序
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void lvwFileSystem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tvwFileSystem.BeginUpdate();//暂时停止重新绘制内容
            this.Cursor = Cursors.WaitCursor;//设置窗体的鼠标光标形式为等待样式
            tvwFileSystem.Nodes.Clear();//清空树状列表控件中所有节点
            foreach (DriveInfo d in DriveInfo.GetDrives())//获得计算机系统所有逻辑磁盘的信息对象数组
            {
                TreeNode rootNode = CreateDirecotryNode(d.RootDirectory);
                tvwFileSystem.Nodes.Add(rootNode);
            }
            tvwFileSystem.EndUpdate();//允许重新绘制
            this.Cursor = Cursors.Default;//窗体鼠标状态为正常
        }

        private object loadingFlag = new object();

        private TreeNode CreateDirecotryNode(DirectoryInfo dir)//为目录对象创建一个树状列表节点对象
        {
            TreeNode node = new TreeNode(dir.Name);//创建一个节点对象
            node.Tag = dir;
            TreeNode node2 = new TreeNode("正在加载...");
            node2.Tag = loadingFlag;
            node.Nodes.Add(node2);
            return node;
        }

        private void tvwFileSystem_AfterExpand(object sender, TreeViewEventArgs e)
        {
            LoadChildNodes(e.Node);
        }

        private void LoadChildNodes(TreeNode rootNode)
        {
            if (rootNode.FirstNode != null
                && rootNode.FirstNode.Tag == loadingFlag)
            {
                //加载子目录
                rootNode.Nodes.Clear();
                DirectoryInfo dir = (DirectoryInfo)rootNode.Tag;
                foreach (DirectoryInfo subDir in dir.GetDirectories())//获得指定目录下所有子目录信息
                {
                    TreeNode node = CreateDirecotryNode(subDir);
                    rootNode.Nodes.Add(node);
                }
            }
        }

        private void tvwFileSystem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvwFileSystem.BeginUpdate();
            lvwFileSystem.Items.Clear();
            if (tvwFileSystem.SelectedNode != null)
            {
                DirectoryInfo rootDir = (DirectoryInfo)tvwFileSystem.SelectedNode.Tag;
                //首先列出所有的子目录

                foreach (DirectoryInfo dir in rootDir.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(dir.Name);
                    item.SubItems.Add("");
                    item.SubItems.Add(dir.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    item.Tag = dir;
                    lvwFileSystem.Items.Add(item);
                }
                //列出所有的文件
                foreach (FileInfo file in rootDir.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Length.ToString());
                    item.SubItems.Add(file.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    item.Tag = file;
                    lvwFileSystem.Items.Add(item);
                }
            }
            lvwFileSystem.EndUpdate();
        }

        private void btnSecure_Click(object sender, EventArgs e)
        {
            if (lvwFileSystem.SelectedItems.Count > 0
                && lvwFileSystem.SelectedItems[0].Tag is FileInfo)
            {
                FileInfo file = (FileInfo)lvwFileSystem.SelectedItems[0].Tag;
                //获得文件扩展名
                string ext = file.Extension;
                if (ext != null)
                {
                    ext = ext.Trim().ToLower();
                    if (ext == ".doc"||ext == ".docx")
                    {
                        //标记密级
                        Word.Application oWord;
                        Word._Document oDoc;
                        object MissingValue = Missing.Value;
                        object oDocCustomProps;

                        oWord = new Word.Application();
                        oWord.Visible = false;

                        object ofile = file.FullName; ;
                        oDoc = oWord.Documents.Open(
                        ref ofile, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

                        oDocCustomProps = oDoc.CustomDocumentProperties;
                        Type typeDocCustomProps = oDocCustomProps.GetType();

                        string strIndex = "Secret Flag";
                        string strValue = "秘密";
                        object[] oArgs = {strIndex,false,
                     MsoDocProperties.msoPropertyTypeString,
                     strValue};

                        typeDocCustomProps.InvokeMember("Add", BindingFlags.Default |
                                                   BindingFlags.InvokeMethod, null,
                                                   oDocCustomProps, oArgs);
                     
                         

                        Word.Paragraph parag = oDoc.Content.Paragraphs.Add(ref MissingValue);
                        parag.Range.InsertParagraph();

                        oDoc.SaveAs(ref ofile, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

                        oDoc.Close(ref MissingValue, ref MissingValue, ref MissingValue);

                        MessageBox.Show("设置秘密成功！");
                        //修改文件属性，刷新列表
                        tvwFileSystem_AfterSelect(null, null);
                    }
                }
            }
            else MessageBox.Show("文件类型选择不正确");
        }   

        private void btnjm_Click(object sender, EventArgs e)
        {
            if (lvwFileSystem.SelectedItems.Count > 0
               && lvwFileSystem.SelectedItems[0].Tag is FileInfo)
            {
                FileInfo file = (FileInfo)lvwFileSystem.SelectedItems[0].Tag;
                //获得文件扩展名
                string ext = file.Extension;
                if (ext != null)
                {
                    ext = ext.Trim().ToLower();
                    if (ext == ".doc" || ext == ".docx")
                    {
                        //标记密级
                        Word.Application oWord;
                        Word._Document oDoc;
                        object MissingValue = Missing.Value;
                        object oDocCustomProps;

                        oWord = new Word.Application();
                        oWord.Visible = false;

                        object ofile = file.FullName; ;
                        oDoc = oWord.Documents.Open(
                        ref ofile, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

                        oDocCustomProps = oDoc.CustomDocumentProperties;
                        Type typeDocCustomProps = oDocCustomProps.GetType();

                        string strIndex = "Secret Flag";
                        string strValue = "机密";
                        object[] oArgs = {strIndex,false,
                     MsoDocProperties.msoPropertyTypeString,
                     strValue};

                        typeDocCustomProps.InvokeMember("Add", BindingFlags.Default |
                                                   BindingFlags.InvokeMethod, null,
                                                   oDocCustomProps, oArgs);



                        Word.Paragraph parag = oDoc.Content.Paragraphs.Add(ref MissingValue);
                        parag.Range.InsertParagraph();

                        oDoc.SaveAs(ref ofile, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

                        oDoc.Close(ref MissingValue, ref MissingValue, ref MissingValue);

                        MessageBox.Show("设置机密成功！");
                        //修改文件属性，刷新列表
                        tvwFileSystem_AfterSelect(null, null);
                    }
                }
            }
            else MessageBox.Show("文件类型选择不正确");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lvwFileSystem.SelectedItems.Count > 0
               && lvwFileSystem.SelectedItems[0].Tag is FileInfo)
            {
                FileInfo file = (FileInfo)lvwFileSystem.SelectedItems[0].Tag;
                //获得文件扩展名
                string ext = file.Extension;
                if (ext != null)
                {
                    ext = ext.Trim().ToLower();
                    if (ext == ".doc" || ext == ".docx")
                    {
                        //标记密级
                        Word.Application oWord;
                        Word._Document oDoc;
                        object MissingValue = Missing.Value;
                        object oDocCustomProps;

                        oWord = new Word.Application();
                        oWord.Visible = false;

                        object ofile = file.FullName; ;
                        oDoc = oWord.Documents.Open(
                        ref ofile, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue,
                        ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

                        oDocCustomProps = oDoc.CustomDocumentProperties;
                        Type typeDocCustomProps = oDocCustomProps.GetType();

                        string strIndex = "Secret Flag";
                        string strValue = "绝密";
                        object[] oArgs = {strIndex,false,
                     MsoDocProperties.msoPropertyTypeString,
                     strValue};

                        typeDocCustomProps.InvokeMember("Add", BindingFlags.Default |
                                                   BindingFlags.InvokeMethod, null,
                                                   oDocCustomProps, oArgs);



                        Word.Paragraph parag = oDoc.Content.Paragraphs.Add(ref MissingValue);
                        parag.Range.InsertParagraph();

                        oDoc.SaveAs(ref ofile, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

                        oDoc.Close(ref MissingValue, ref MissingValue, ref MissingValue);

                        MessageBox.Show("设置绝密成功！");
                        //修改文件属性，刷新列表
                        tvwFileSystem_AfterSelect(null, null);
                    }
                }
            }
            else MessageBox.Show("文件类型选择不正确");
        }
    }
}

