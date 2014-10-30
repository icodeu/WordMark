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
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Diagnostics;

namespace FileManager
{
    public partial class Form1 : Form
    {
        //string oldDri = "";
        //string oldFile = "";

        //bool a;

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

        /*
         *最初是为了杀死wps的进程 现在没用了 因为成功关闭了word 
         */
        void killProgress()
        {
            Process[] processArr = Process.GetProcessesByName("wps");
            foreach (Process item in processArr)
                item.Kill();
        }

        void FillFilesView(string FullName)
        {//获得当前目录文件夹信息及子目录文件信息并显示在ListView上
            lv_allinfo.Clear();
            lv_allinfo.View = View.Details;
            lv_allinfo.Columns.Add("名称", lv_allinfo.Width / 3, HorizontalAlignment.Left);             //增加一个显示字段，显示文件名称
            lv_allinfo.Columns.Add("类型", lv_allinfo.Width / 6, HorizontalAlignment.Center);
            lv_allinfo.Columns.Add("大小(字节)", lv_allinfo.Width / 6, HorizontalAlignment.Right);
            lv_allinfo.Columns.Add("密级类型", lv_allinfo.Width / 3, HorizontalAlignment.Left);
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
                lvi.SubItems.Add("");        //设置文件密级
                lv_allinfo.Items.Add(lvi);
            }

            foreach (FileInfo file in files)
            {
                ListViewItem lvi = new ListViewItem();

                if (file.Extension == ".doc" || file.Extension == ".docx")
                {
                    Word.Application oWord;
                    Word._Document oDoc;
                    oWord = new Word.Application();
                    oWord.Visible = false;
                    object oMissing = Missing.Value;
                    try
                    { 
                        object oDocBuiltInProps;
                        object oDocCustomProps;

                        //Create an instance of Microsoft Word and make it visible.

                        object wordfile = null;
                        wordfile = file.FullName;
                        oDoc = oWord.Documents.Open(
                        ref wordfile, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                        oDocCustomProps = oDoc.CustomDocumentProperties;
                        Type typeDocCustomProps = oDocCustomProps.GetType();

                        string strIndex = "Secret Flag";
                        string strValue = "";

                        object oMyProp = typeDocCustomProps.InvokeMember("Item", System.Reflection.BindingFlags.GetProperty, null, oDocCustomProps, new object[] { strIndex });
                        Type myPropType = oMyProp.GetType();
                        strValue = myPropType.InvokeMember("Value", System.Reflection.BindingFlags.GetProperty, null, oMyProp, new object[] { }).ToString();


                        lvi.Text = file.Name;
                        lvi.ImageIndex = 4;
                        lvi.Tag = file.FullName;        //获得文件的完全路径
                        lvi.SubItems.Add("文件");       //设置类型
                        lvi.SubItems.Add(file.Length.ToString());   //设置文件大小
                        lvi.SubItems.Add(strValue);       //设置文件密级
                        lv_allinfo.Items.Add(lvi);

                        oWord.Documents.Close(ref oMissing, ref oMissing, ref oMissing);

                        oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
                    }
                    catch (Exception ex)
                    {
                        lvi.Text = file.Name;
                        lvi.ImageIndex = 5;
                        lvi.Tag = file.FullName;        //获得文件的完全路径
                        lvi.SubItems.Add("文件");       //设置类型
                        lvi.SubItems.Add(file.Length.ToString());   //设置文件大小
                        lvi.SubItems.Add("无密级");       //设置文件密级
                        lv_allinfo.Items.Add(lvi);

                        oWord.Documents.Close(ref oMissing, ref oMissing, ref oMissing);

                        oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
                    }
                    
                    
                }

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
        {   //标记为秘密
            markDegree("秘密");
        }

        private void copy_Click(object sender, EventArgs e)
        {//标记为机密
            markDegree("机密");
        }
        
        private void cut_Click(object sender, EventArgs e)
        {//标记为绝密
            markDegree("绝密");
        }

        private void paste_Click(object sender, EventArgs e)
        {//查询该文件密级属性

            try
            {
                if (lv_allinfo.SelectedItems.Count > 0)
                {
                        for (int i = 0; i < lv_allinfo.SelectedItems.Count; i++)
                        {
                            if (lv_allinfo.SelectedItems[i].SubItems[1].Text == "文件夹")   //如果选中项的类型为“文件夹”
                            {
                                //string strDir = lv_allinfo.SelectedItems[i].Tag.ToString();          //获得选中的文件夹的全部名称
                                //Directory.Delete(strDir, true);                                    //删除选中的文件夹(true不保护)
                            }
                            else
                            {
                                string strFile = lv_allinfo.SelectedItems[i].Tag.ToString();

                                Word.Application oWord;
                                Word._Document oDoc;
                                object oMissing = Missing.Value;
                                object oDocBuiltInProps;
                                object oDocCustomProps;

                                //Create an instance of Microsoft Word and make it visible.
                                oWord = new Word.Application();
                                oWord.Visible = false;

                                object file = null;
                                file = strFile;
                                oDoc = oWord.Documents.Open(
                                ref file, ref oMissing, ref oMissing,
                                ref oMissing, ref oMissing, ref oMissing,
                                ref oMissing, ref oMissing, ref oMissing,
                                ref oMissing, ref oMissing, ref oMissing,
                                ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                                oDocCustomProps = oDoc.CustomDocumentProperties;
                                Type typeDocCustomProps = oDocCustomProps.GetType();

                                string strIndex = "Secret Flag";
                                string strValue = "";

                                object oMyProp = typeDocCustomProps.InvokeMember("Item", System.Reflection.BindingFlags.GetProperty, null, oDocCustomProps, new object[] {strIndex}); 
                                Type myPropType = oMyProp.GetType();
                                strValue = myPropType.InvokeMember("Value", System.Reflection.BindingFlags.GetProperty, null, oMyProp, new object[] {}).ToString();

                                MessageBox.Show(strValue);

                                oDoc.Close(ref oMissing, ref oMissing, ref oMissing);

                                oWord.Documents.Close(ref oMissing, ref oMissing, ref oMissing);

                                oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
                            }
                        }
                        
                        string CurFullPath = CurPath[CurPath.Count - 1];            //获得当前路径
                        FillFilesView(CurFullPath);                         //刷新
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 只显示秘密文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //只显示秘密文件
            string CurFullPath = CurPath[CurPath.Count - 1];            //获得当前路径
            //showMIMIOnly(CurFullPath); 
            showOneOnly(CurFullPath, "秘密");
        }

        private void 只显示机密文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //只显示机密文件
            string CurFullPath = CurPath[CurPath.Count - 1];            //获得当前路径
            //showJIMIOnly(CurFullPath); 
            showOneOnly(CurFullPath, "机密");
        }

        private void 只显示绝密文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //只显示绝密文件
            string CurFullPath = CurPath[CurPath.Count - 1];            //获得当前路径
            //showJUEMIOnly(CurFullPath); 
            showOneOnly(CurFullPath, "绝密");
        }

        private void lv_allinfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
         *只显示某一密级文件
         *Fullname:文件路径
         *Degree:显示某一级别，“秘密”“机密”“绝密” “全部”
         */
        void showOneOnly(string FullName, string Degree)
        {
            //获得当前目录文件夹信息及子目录文件信息并显示在ListView上
            lv_allinfo.Clear();
            lv_allinfo.View = View.Details;
            lv_allinfo.Columns.Add("名称", lv_allinfo.Width / 3, HorizontalAlignment.Left);             //增加一个显示字段，显示文件名称
            lv_allinfo.Columns.Add("类型", lv_allinfo.Width / 6, HorizontalAlignment.Center);
            lv_allinfo.Columns.Add("大小(字节)", lv_allinfo.Width / 6, HorizontalAlignment.Right);
            lv_allinfo.Columns.Add("密级类型", lv_allinfo.Width / 3, HorizontalAlignment.Left);
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
                lvi.SubItems.Add("");        //设置文件密级
                lv_allinfo.Items.Add(lvi);
            }

            foreach (FileInfo file in files)
            {
                ListViewItem lvi = new ListViewItem();

                if (file.Extension == ".doc" || file.Extension == ".docx")
                {
                    Word.Application oWord;
                    Word._Document oDoc;
                    oWord = new Word.Application();
                    oWord.Visible = false;
                    object oMissing = Missing.Value;
                    try
                    {
                        object oDocBuiltInProps;
                        object oDocCustomProps;

                        //Create an instance of Microsoft Word and make it visible.

                        object wordfile = null;
                        wordfile = file.FullName;
                        oDoc = oWord.Documents.Open(
                        ref wordfile, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                        oDocCustomProps = oDoc.CustomDocumentProperties;
                        Type typeDocCustomProps = oDocCustomProps.GetType();

                        string strIndex = "Secret Flag";
                        string strValue = "";

                        object oMyProp = typeDocCustomProps.InvokeMember("Item", System.Reflection.BindingFlags.GetProperty, null, oDocCustomProps, new object[] { strIndex });
                        Type myPropType = oMyProp.GetType();
                        strValue = myPropType.InvokeMember("Value", System.Reflection.BindingFlags.GetProperty, null, oMyProp, new object[] { }).ToString();

                        if (strValue == Degree)
                        {
                            lvi.Text = file.Name;
                            lvi.ImageIndex = 4;
                            lvi.Tag = file.FullName;        //获得文件的完全路径
                            lvi.SubItems.Add("文件");       //设置类型
                            lvi.SubItems.Add(file.Length.ToString());   //设置文件大小
                            lvi.SubItems.Add(strValue);       //设置文件密级
                            lv_allinfo.Items.Add(lvi);
                        }


                        else if (Degree == "全部")
                        {
                            lvi.Text = file.Name;
                            lvi.ImageIndex = 4;
                            lvi.Tag = file.FullName;        //获得文件的完全路径
                            lvi.SubItems.Add("文件");       //设置类型
                            lvi.SubItems.Add(file.Length.ToString());   //设置文件大小
                            lvi.SubItems.Add(strValue);       //设置文件密级
                            lv_allinfo.Items.Add(lvi);
                        }

                        oWord.Documents.Close(ref oMissing, ref oMissing, ref oMissing);

                        oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
                    }
                    catch (Exception ex)
                    {
                        lvi.Text = file.Name;
                        lvi.ImageIndex = 5;
                        lvi.Tag = file.FullName;        //获得文件的完全路径
                        lvi.SubItems.Add("文件");       //设置类型
                        lvi.SubItems.Add(file.Length.ToString());   //设置文件大小
                        lvi.SubItems.Add("无密级");       //设置文件密级
                        lv_allinfo.Items.Add(lvi);

                        oWord.Documents.Close(ref oMissing, ref oMissing, ref oMissing);

                        oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
                    }

                }

            }

        }


        /*
         *标记密级属性
         *strValue:"秘密" "机密" "绝密"
         */
        void markDegree(String strValue)
        {
            try
            {
                if (lv_allinfo.SelectedItems.Count > 0)
                {
                    DialogResult ret = MessageBox.Show("是否确认标记为" + strValue + "？", "确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    {
                        for (int i = 0; i < lv_allinfo.SelectedItems.Count; i++)
                        {
                            if (lv_allinfo.SelectedItems[i].SubItems[1].Text == "文件夹")   //如果选中项的类型为“文件夹”
                            {
                                //string strDir = lv_allinfo.SelectedItems[i].Tag.ToString();          //获得选中的文件夹的全部名称
                                //Directory.Delete(strDir, true);                                    //删除选中的文件夹(true不保护)
                            }
                            else
                            {
                                string strFile = lv_allinfo.SelectedItems[i].Tag.ToString();
                                //MessageBox.Show(strFile);
                                //File.Delete(strFile);


                                Word.Application oWord;
                                Word._Document oDoc;
                                object MissingValue = Missing.Value;
                                object oDocCustomProps;

                                oWord = new Word.Application();
                                oWord.Visible = false;

                                object file = null;
                                //OpenFileDialog dialog = new OpenFileDialog();
                                //if (dialog.ShowDialog() == DialogResult.OK)
                                //file = dialog.FileName;
                                //MessageBox.Show(dialog.FileName);
                                file = strFile;
                                oDoc = oWord.Documents.Open(
                                ref file, ref MissingValue, ref MissingValue,
                                ref MissingValue, ref MissingValue, ref MissingValue,
                                ref MissingValue, ref MissingValue, ref MissingValue,
                                ref MissingValue, ref MissingValue, ref MissingValue,
                                ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

                                oDocCustomProps = oDoc.CustomDocumentProperties;
                                Type typeDocCustomProps = oDocCustomProps.GetType();

                                string strIndex = "Secret Flag";

                                object[] oArgs = {strIndex,false,
                     MsoDocProperties.msoPropertyTypeString,
                     strValue};

                                typeDocCustomProps.InvokeMember("Add", BindingFlags.Default |
                                                           BindingFlags.InvokeMethod, null,
                                                           oDocCustomProps, oArgs);

                                Word.Paragraph parag = oDoc.Content.Paragraphs.Add(ref MissingValue);
                                parag.Range.InsertParagraph();

                                oDoc.SaveAs(ref file, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);

                                oDoc.Close(ref MissingValue, ref MissingValue, ref MissingValue);

                                oWord.Documents.Close(ref MissingValue, ref MissingValue, ref MissingValue);

                                oWord.Quit(ref MissingValue, ref MissingValue, ref MissingValue);

                            }
                        }
                        MessageBox.Show("设置" + strValue + "成功！");
                        string CurFullPath = CurPath[CurPath.Count - 1];            //获得当前路径
                        FillFilesView(CurFullPath);                         //刷新

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("非授权操作,禁止更改密级");
            }
        }


        ArrayList path = new ArrayList();
        ArrayList oname = new ArrayList();
        ArrayList imgPath = new ArrayList();

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

        private void 取消文件密级ToolStripMenuItem_Click(object sender, EventArgs e)
        {//显示全部密级文件
            string CurFullPath = CurPath[CurPath.Count - 1];            //获得当前路径
            showOneOnly(CurFullPath, "全部");
        }

    }
}