using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileManager.Class
{
    public class Folder
    {
        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="filename">文件夹名</param>
        /// <param name="path">文件夹路径</param>
        public static void NewFolder(string foldername, string path)
        {
            foldername.Trim();
            //如果输入信息为空，提示
            if (foldername == "")
            {
                MessageBox.Show("目录名不能为空");
                return;
            }
            else
            {
                string FullName = path + "\\" + foldername;
                //如果该文件以及存在
                if (Directory.Exists(FullName))
                {
                    MessageBox.Show("该目录已经存在，请重命名");
                    return;
                }
                else
                {
                    //新建文件夹
                    Directory.CreateDirectory(FullName);
                }
            }
        }

        /// <summary>
        /// 新建文件夹（Enter键触发）
        /// </summary>
        /// <param name="filename">文件夹名</param>
        /// <param name="path">文件夹路径</param>
        public static void Enter(string foldername, string path)
        {
            foldername.Trim();
            if (foldername == "")
            {
                MessageBox.Show("目录名不能为空！");
                return;
            }
            else if (Directory.Exists(path + "\\" + foldername))
            {
                MessageBox.Show("该目录以及存在，请重新命名");
                return;
            }
            else
            {
                Directory.CreateDirectory(path + "\\" + foldername);
            }

        }

        /// <summary>
        /// //获取文件夹名，截取“\”
        /// </summary>
        /// <param name="DirectoryPath">文件夹完整路径</param>
        /// <returns></returns>
        internal static int DirectoryName(string DirectoryPath)
        {
            int j = 0;
            char[] c = DirectoryPath.ToCharArray();
            for (int i = c.Length - 1; i >= 0; i--)//从后面截取
            {
                j = i;
                if (c[i].ToString() == "\\")
                {
                    break;//遇"\"调处,并返回"\"的位置
                }
            }
            return j + 1;
        }
        /// <summary>
        /// 在指定目录下新建一个文件夹
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        public static void CreateDir(string path, string name)
        {
            Directory.CreateDirectory(path + "\\" + name);
        }

        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="oldDir">原文件所在文件夹路径</param>
        /// <param name="Name">文件名</param>
        /// <param name="newDir">新文件夹路径</param>
        public static void CopyFile(string oldDir, string Name, string newDir)
        {
            File.Copy(oldDir + "\\" + Name, newDir + "\\" + Name);
        }

        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="oldDir">原文件所在文件夹路径</param>
        /// <param name="newDir">新文件夹路径</param>
        public static void CopyFile(string oldDir, string newDir)
        {
            string name = oldDir.Substring(DirectoryName(oldDir));
            File.Copy(oldDir, newDir + "\\" + name);
        }

        /// <summary>
        /// 删除指定文件夹
        /// </summary>
        /// <param name="strDir">文件夹完整路径</param>
        /// <param name="recursive">是否删除文件夹子项</param>
        public static void DeleteFolder(string strDir, bool recursive)
        {
            Directory.Delete(strDir, recursive);
        }

        /// <summary>
        /// 返回指定路径的DirectoryInfo
        /// </summary>
        /// <returns></returns>
        public static DirectoryInfo GetDir(string path)
        {
            return new DirectoryInfo(path);
        }
    }
}
