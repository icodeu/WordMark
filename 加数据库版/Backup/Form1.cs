using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using FileManager.Class;

namespace FileManager
{
    public partial class Form1 : Form
    {
        string oldDri = "";
        string oldFile = "";

        bool a;//判断操作是“复制”还是“剪切”

        System.Collections.Specialized.StringCollection CurPath = new System.Collections.Specialized.StringCollection();    //CurPath集合属性存储了每一级目录的全路径

        public Form1()
        {//初始化界面
            InitializeComponent();

            try
            {
                tb_currentpath.Text = "我的电脑";       //初始路径
                lv_allinfo.Clear();
                lv_allinfo.View = View.Details;         //ListView以详细数据方式显示
                lv_allinfo.Columns.Add("本地磁盘", lv_allinfo.Width / 3, HorizontalAlignment.Left);     //增加一个显示字段，显示磁盘名
                string[] Drv = Directory.GetLogicalDrives();        //将获得的所有磁盘列表存入数组Drv
                int DrvCnt = Drv.Length;                            //获得数组长度
                for (int i = 0; i < DrvCnt; i++)
                {
                    ListViewItem lvi = new ListViewItem();          //实例化一个ListViewItem的对象
                    lvi.Text = "驱动器" + Drv[i];                   //设置磁盘名称
                    lvi.ImageIndex = 3;                             //设置图标
                    lvi.Tag = Drv[i];                               //通过Tag保存当前的完全路径
                    lv_allinfo.Items.Add(lvi);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillFilesView(string FullName)
        {//获得当前目录文件夹信息及子目录文件信息并显示在ListView上
            lv_allinfo.Clear();
            lv_allinfo.View = View.Details;
            lv_allinfo.Columns.Add("名称", lv_allinfo.Width / 3, HorizontalAlignment.Left);             //增加一个显示字段，显示文件名称
            lv_allinfo.Columns.Add("类型", lv_allinfo.Width / 6, HorizontalAlignment.Center);
            lv_allinfo.Columns.Add("大小(字节)", lv_allinfo.Width / 6, HorizontalAlignment.Right);
            lv_allinfo.Columns.Add("最后访问时间", lv_allinfo.Width / 3, HorizontalAlignment.Left);
            DirectoryInfo CurDir = new DirectoryInfo(FullName);                 //得到需要显示内容列表的目录信息
            DirectoryInfo[] dirs = CurDir.GetDirectories();                     //得到当前目录中的所有文件夹（子目录）
            FileInfo[] files = CurDir.GetFiles();                               //得到当前目录中的所有文件

            foreach (DirectoryInfo dir in dirs)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dir.Name;                    //设置文件夹名称
                lvi.Tag = dir.FullName;                 //设置文件夹的完全路径
                lvi.ImageIndex = 0;                     //设置文件夹图标
                lvi.SubItems.Add("文件夹");             //设置类型
                lvi.SubItems.Add("");
                lvi.SubItems.Add(dir.LastAccessTime.ToString());        //设置文件夹最后访问时间
                lv_allinfo.Items.Add(lvi);
            }

            foreach (FileInfo file in files)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = file.Name;
                if (file.Extension == ".txt")       //判断文件的后缀名是否为.txt
                {
                    lvi.ImageIndex = 1;
                }
                else
                {
                    lvi.ImageIndex = 2;
                }
                lvi.Tag = file.FullName;        //获得文件的完全路径
                lvi.SubItems.Add("文件");       //设置类型
                lvi.SubItems.Add(file.Length.ToString());   //设置文件大小
                lvi.SubItems.Add(file.LastAccessTime.ToString());       //设置文件最后访问时间
                lv_allinfo.Items.Add(lvi);
            }
        }

        private void lv_allinfo_DoubleClick(object sender, EventArgs e)
        {//ListView双击
            try
            {
                string FullName = lv_allinfo.SelectedItems[0].Tag.ToString();       //获得选中项的全部名称
                if (lv_allinfo.SelectedItems[0].ImageIndex == 1)                    //如果选中的是txt
                {
                    EditTxt dlgEditTxt = new EditTxt();
                    dlgEditTxt.lb_fullname.Text = FullName;
                    dlgEditTxt.ShowDialog(this);
                }
                else
                {
                    if (lv_allinfo.SelectedItems[0].ImageIndex == 2)        //如果选中的是其他文件
                    {
                        System.Diagnostics.Process.Start(FullName);         //通过系统函数启动该文件
                    }
                    else
                    {
                        tb_currentpath.Text = FullName;         //更新路径显示
                        FillFilesView(FullName);                //更新ListView
                        CurPath.Add(FullName);                  //将当前路径存入CurPath
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {//返回上一层
            try
            {
                if (CurPath.Count > 1)      //如果当前所在位置不是根目录
                {
                    string FullName = CurPath[CurPath.Count - 2].ToString();    //获得上一级目录的路径
                    tb_currentpath.Text = FullName;                             //更新路径显示
                    FillFilesView(FullName);                                    //更新ListView
                    CurPath.RemoveAt(CurPath.Count - 1);                        //从CurPath中删除当前目录
                }
                else
                {
                    if (CurPath.Count == 1)         //如果在根目录
                    {
                        CurPath.RemoveAt(CurPath.Count - 1);    //从CurPath中删除当前目录
                        tb_currentpath.Text = "我的电脑";  //更新路径显示
                        lv_allinfo.Clear();
                        lv_allinfo.View = View.Details;
                        lv_allinfo.Columns.Add("本地磁盘", lv_allinfo.Width / 3, HorizontalAlignment.Left);
                        string[] Drv = Directory.GetLogicalDrives();        //获取当前磁盘列表并存入数组
                        for (int i = 0; i < Drv.Length; i++)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = "驱动器" + Drv[i];
                            lvi.ImageIndex = 3;
                            lvi.Tag = Drv[i];
                            lv_allinfo.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewFolder_Click(object sender, EventArgs e)
        {//新建文件夹
            try
            {
                NewFolder folderDlg = new NewFolder();              //实例化一个NewFolder对象
                folderDlg.lbParentPath.Text = CurPath[CurPath.Count - 1];   //NewFolder上显示当前路径
                if (folderDlg.ShowDialog() == DialogResult.OK)              //弹出对话框
                {
                    string CurFullPath = CurPath[CurPath.Count - 1];        //获取当前路径
                    FillFilesView(CurFullPath);                             //刷新ListView
                }
                folderDlg.Dispose();                //释放对话框
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewFile_Click(object sender, EventArgs e)
        {//新建文件
            try
            {
                NewFile fileDlg = new NewFile();            //实例化一个NewFile对象
                fileDlg.lbParentPath.Text = CurPath[CurPath.Count - 1];
                if (fileDlg.ShowDialog() == DialogResult.OK)
                {
                    string CurFullPath = CurPath[CurPath.Count - 1];
                    FillFilesView(CurFullPath);
                }
                fileDlg.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {//删除
            try
            {
                if (lv_allinfo.SelectedItems.Count > 0)
                {
                    DialogResult ret = MessageBox.Show("是否确认删除所选？", "确定删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    {
                        if (lv_allinfo.SelectedItems[0].SubItems[1].Text == "文件夹")   //如果选中项的类型为“文件夹”
                        {
                            string strDir = lv_allinfo.SelectedItems[0].Tag.ToString();          //获得选中的文件夹的全部名称
                            Directory.Delete(strDir, true);                                    //删除选中的文件夹
                        }
                        else
                        {
                            string strFile = lv_allinfo.SelectedItems[0].Tag.ToString();
                            File.Delete(strFile);
                        }
                        string CurFullPath = CurPath[CurPath.Count - 1];            //获得当前路径
                        FillFilesView(CurFullPath);                         //刷新
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {//退出
            Application.Exit();
        }

        private void contextmenudelete_Click(object sender, EventArgs e)
        {//右键删除
            try
            {
                if (lv_allinfo.SelectedItems.Count > 0)
                {
                    DialogResult ret = MessageBox.Show("是否确认删除所选？", "确定删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    {
                        for (int i = 0; i < lv_allinfo.SelectedItems.Count; i++)
                        {
                            if (lv_allinfo.SelectedItems[i].SubItems[1].Text == "文件夹")   //如果选中项的类型为“文件夹”
                            {
                                string strDir = lv_allinfo.SelectedItems[i].Tag.ToString();          //获得选中的文件夹的全部名称
                                Directory.Delete(strDir, true);                                    //删除选中的文件夹(true不保护)
                            }
                            else
                            {
                                string strFile = lv_allinfo.SelectedItems[i].Tag.ToString();
                                File.Delete(strFile);
                            }
                        }
                        string CurFullPath = CurPath[CurPath.Count - 1];            //获得当前路径
                        FillFilesView(CurFullPath);                         //刷新
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextmenufolder_Click(object sender, EventArgs e)
        {//右键添加文件夹
            try
            {
                NewFolder folderDlg = new NewFolder();
                folderDlg.lbParentPath.Text = CurPath[CurPath.Count - 1];
                if (folderDlg.ShowDialog() == DialogResult.OK)
                {
                    string CurFullPath = CurPath[CurPath.Count - 1];
                    FillFilesView(CurFullPath);
                }
                folderDlg.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextmenufile_Click(object sender, EventArgs e)
        {//右键添加文件
            try
            {
                NewFile fileDlg = new NewFile();
                fileDlg.lbParentPath.Text = CurPath[CurPath.Count - 1];
                if (fileDlg.ShowDialog() == DialogResult.OK)
                {
                    string CurFullPath = CurPath[CurPath.Count - 1];
                    FillFilesView(CurFullPath);
                }
                fileDlg.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BigToolStripMenuItem_Click(object sender, EventArgs e)
        {//大图标
            lv_allinfo.View = View.LargeIcon;
        }
        private void SmallToolStripMenuItem_Click(object sender, EventArgs e)
        {//小图标
            lv_allinfo.View = View.SmallIcon;
        }
        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {//列表
            lv_allinfo.View = View.List;
        }

        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {//详细
            lv_allinfo.View = View.Details;
        }

        private void TitleToolStripMenuItem_Click(object sender, EventArgs e)
        {//文件名
            lv_allinfo.View = View.Tile;
        }

        private void copy_Click(object sender, EventArgs e)
        {//复制
            try
            {
                a = true;
                if (lv_allinfo.SelectedItems.Count == 0)
                {
                    return;
                }
                else
                {
                    oldDri = "";
                    oldFile = "";
                    if (lv_allinfo.SelectedItems[0].SubItems[1].Text == "文件夹")
                    {
                        oldDri = lv_allinfo.SelectedItems[0].Tag.ToString();
                    }
                    else
                    {
                        oldFile = lv_allinfo.SelectedItems[0].Tag.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 复制文件到指定目录
        /// </summary>
        /// <param name="strDir"></param>
        /// <param name="FilePath"></param>
        private void CopyFile(string strDir, string FilePath)
        {
            string FolderName = FilePath.Substring(Folder.DirectoryName(FilePath));
            if (Directory.Exists(strDir + "\\" + FolderName))
            {
                Class.Txt.DeleteFile(strDir + "\\" + FolderName);   //若文件存在，删除
                Class.Folder.CreateDir(FilePath, strDir);            //复制文件
            }
            else
            {
                Class.Txt.CreateText(FolderName, strDir);
            }
        }
        /// <summary>
        /// 复制文件夹到指定目录
        /// </summary>
        /// <param name="strDir"></param>
        /// <param name="FolderPath"></param>
        private void CopyDirectory(string strDir, string FolderPath)
        {
            string FolderName = FolderPath.Substring(Class.Folder.DirectoryName(FolderPath));
            if (Directory.Exists(strDir + "\\" + FolderName))
            {
                Class.Folder.DeleteFolder(strDir + "\\" + FolderName, true);
                Class.Folder.CreateDir(strDir, FolderName);
            }
            else
            {
                Class.Folder.CreateDir(strDir, FolderName);
            }
            DirectoryInfo DirectoryArray = Class.Folder.GetDir(FolderPath);
            FileInfo[] Files = DirectoryArray.GetFiles();
            DirectoryInfo[] Directorys = DirectoryArray.GetDirectories();
            foreach (FileInfo inf in Files)
            {
                Class.Folder.CopyFile(FolderPath, inf.Name, strDir + "\\" + FolderName);
            }
            foreach (DirectoryInfo Dir in Directorys)
            {
                if (Dir.Name != FolderName)
                    CopyDirectory(strDir + "\\" + FolderName, FolderPath + "\\" + Dir.Name);
            }
        }

        ArrayList path = new ArrayList();
        ArrayList oname = new ArrayList();
        ArrayList imgPath = new ArrayList();
        private void cut_Click(object sender, EventArgs e)
        {//剪切
            for (int i = 0; i < lv_allinfo.SelectedItems.Count; i++)
            {
                path.Add(lv_allinfo.SelectedItems[i].Tag);
                oname.Add(lv_allinfo.SelectedItems[i].Text);
                imgPath.Add(lv_allinfo.SelectedItems[i].ImageIndex);
                a = false;
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {//粘贴
            try
            {
                if (tb_currentpath.Text == "我的电脑")
                {
                    return;
                }
                else
                {
                    if (a)
                    {
                        string strDir = tb_currentpath.Text;
                        if (oldDri != "")
                        {
                            CopyDirectory(strDir, oldDri);
                        }
                        else
                        {
                            CopyFile(strDir, oldFile);
                        }
                        FillFilesView(tb_currentpath.Text);
                    }
                    else
                    {
                        for (int i = 0; i < path.Count; i++)
                        {
                            if (Convert.ToInt32(imgPath[i].ToString()) == 0)
                            {
                                Directory.Move(path[i].ToString(), CurPath[CurPath.Count - 1] + "\\" + oname[i]);
                            }
                            else if (Convert.ToInt32(imgPath[i].ToString()) == 1)
                            {
                                Directory.Move(path[i].ToString(), CurPath[CurPath.Count - 1] + "\\" + oname[i]);
                            }
                        }
                        FillFilesView(CurPath[CurPath.Count - 1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}