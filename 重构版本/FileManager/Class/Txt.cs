using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace FileManager.Class
{
    public class Txt
    {
        public Txt()
        {
 
        }
        /// <summary>
        /// 新建文件
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <param name="path">文件路径</param>
        public static void NewFile(string filename,string path)
        {
            filename.Trim();
            if (filename == "")
            {
                MessageBox.Show("文件名不能为空~！");
            }
            else
            {
                if (File.Exists(path + "\\" + filename+".txt"))
                {
                    MessageBox.Show("该文件名已经存在，请重命名");
                }
                else
                {
                    string FullName = path + "\\" + filename + ".txt";   //获得文件完整信息
                    StreamWriter Sw = File.CreateText(FullName);
                }
            }
        }
        /// <summary>
        /// 新建文件（Enter键触发）
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <param name="path">文件路径</param>
        public static void Enter(string filename, string path)
        {
            filename.Trim();
            if (filename == "")
            {
                MessageBox.Show("文件名不能为空~！");
            }
            else
            {
                if (File.Exists(path + "\\" + filename+".txt"))
                {
                    MessageBox.Show("该文件名已经存在，请重命名");
                }
                else
                {
                    string FullName = path + "\\" + filename + ".txt";   //获得文件完整信息
                    StreamWriter Sw = File.CreateText(FullName);
                }
            }
        }
        /// <summary>
        /// 读取显示
        /// </summary>
        /// <param name="filename">文本文件名</param>
        /// <param name="contents">内容</param>
        public static string Display(string filename)
        {//读取显示
            try
            {
                string contents;
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);   //读出所打开的文本文件
                StreamReader reader = new StreamReader(fs);     //实例化一个streamreader
                contents = reader.ReadToEnd();           //将数据显示
                fs.Close();
                return contents;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        /// <summary>
        /// 打开
        /// </summary>
        /// <param name="ofd">打开对话框</param>
        /// <param name="fullname">文本文件名</param>
        /// <param name="contents">内容</param>
        public static void Open(OpenFileDialog ofd,string fullname,string contents)
        {//打开文本
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;     //文件名
                    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(fs);
                    fullname = fileName;
                    contents = reader.ReadToEnd();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="fullname">文本文件名</param>
        /// <param name="contents">内容</param>
        public static void Save(string fullname,string contents)
        {//保存
            try
            {
                StreamWriter writer = new StreamWriter(fullname);
                writer.Write(contents);      //用write()方法把txtContent的数据写入文件
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 另存为
        /// </summary>
        /// <param name="sfd">保存对话框</param>
        /// <param name="contents">内容</param>
        public static void SaveAs(SaveFileDialog sfd,string contents)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                try
                {
                    Stream stream = File.OpenWrite(fileName);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(contents);
                        writer.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// 粗体
        /// </summary>
        /// <param name="rtb"></param>
        public static void Bold(RichTextBox rtb)
        {
            Font newFont = new Font(rtb.SelectionFont,
                        (rtb.SelectionFont.Bold ?
                         rtb.SelectionFont.Style & ~FontStyle.Bold :
                         rtb.SelectionFont.Style | FontStyle.Bold));
            rtb.SelectionFont = newFont;
        }
        /// <summary>
        /// 斜体
        /// </summary>
        /// <param name="rtb"></param>
        public static void Italic(RichTextBox rtb)
        {
            Font newFont = new Font(rtb.SelectionFont,
           (rtb.SelectionFont.Italic ?
            rtb.SelectionFont.Style & ~FontStyle.Italic :
            rtb.SelectionFont.Style | FontStyle.Italic));
            rtb.SelectionFont = newFont;
        }
        /// <summary>
        /// 下划线
        /// </summary>
        /// <param name="rtb"></param>
        public static void Underline(RichTextBox rtb)
        {
            Font newFont = new Font(rtb.SelectionFont,
           (rtb.SelectionFont.Underline ?
            rtb.SelectionFont.Style & ~FontStyle.Underline :
            rtb.SelectionFont.Style | FontStyle.Underline));
            rtb.SelectionFont = newFont;
        }
        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="rtb"></param>
        public static void Copy(RichTextBox rtb)
        {
            if (rtb.SelectedText.Equals(""))
                return;
            Clipboard.SetDataObject(rtb.SelectedText, true);
        }
        /// <summary>
        /// 剪切
        /// </summary>
        /// <param name="rtb"></param>
        public static void Cut(RichTextBox rtb)
        {
            if (rtb.SelectedText.Length > 0)
            {
                try
                {
                    rtb.Cut();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// 粘贴
        /// </summary>
        /// <param name="rtb"></param>
        public static void Paste(RichTextBox rtb)
        {
            rtb.Paste();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="fullname">文本文件全名</param>
        /// <param name="contents">内容</param>
        public static void Exit(string fullname,string contents)
        {
            if (MessageBox.Show("      是否保存文件", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(fullname);
                    writer.Write(contents);      //用write()方法把txtContent的数据写入文件
                    writer.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// 在指定目录新建一个文本文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static StreamWriter CreateText(string path, string name)
        {
            return File.CreateText(path + "\\" + name);
        }

        /// <summary>
        /// 删除指定文件
        /// </summary>
        /// <param name="strFile">文件完整路径</param>
        public static void DeleteFile(string strFile)
        {
            File.Delete(strFile);
        }
    }
}
