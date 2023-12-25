using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LinkTo.Toolkit
{
    public static class FileUtility
    {
        #region 读取文件
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static string ReadFile(string filePath)
        {
            string result = string.Empty;

            if (File.Exists(filePath) == false)
            {
                return result;
            }

            try
            {
                using (var streamReader = new StreamReader(filePath, Encoding.UTF8))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                result = string.Empty;
            }

            return result;
        }

        #endregion 读文件

        #region 写入文件
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="strValue">写入内容</param>
        /// <returns></returns>
        public static bool WriteFile(string filePath, string strValue)
        {
            try
            {
                if (File.Exists(filePath) == false)
                {
                    using (FileStream fileStream = File.Create(filePath)) { }
                }

                using (var streamWriter = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    streamWriter.WriteLine(strValue);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region 删除文件
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static bool DeleteFile(string filePath)
        {
            try
            {
                File.Delete(filePath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion 删除文件

        #region 为文件添加用户组的完全控制权限
        /// <summary>
        /// 为文件添加用户组的完全控制权限
        /// </summary>
        /// <param name="userGroup">用户组</param>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static bool AddSecurityControll2File(string userGroup, string filePath)
        {
            try
            {
                //获取文件信息
                FileInfo fileInfo = new FileInfo(filePath);
                //获得该文件的访问权限
                FileSecurity fileSecurity = fileInfo.GetAccessControl();
                //添加用户组的访问权限规则--完全控制权限
                fileSecurity.AddAccessRule(new FileSystemAccessRule(userGroup, FileSystemRights.FullControl, AccessControlType.Allow));
                //设置访问权限
                fileInfo.SetAccessControl(fileSecurity);
                //返回结果
                return true;
            }
            catch (Exception)
            {
                //返回结果
                return false;
            }
        }
        #endregion

        #region 为文件夹添加用户组的完全控制权限
        /// <summary>
        /// 为文件夹添加用户组的完全控制权限
        /// </summary>
        /// <param name="userGroup">用户组</param>
        /// <param name="dirPath">文件夹路径</param>
        /// <returns></returns>
        public static bool AddSecurityControll2Folder(string userGroup, string dirPath)
        {
            try
            {
                //获取文件夹信息
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                //获得该文件夹的所有访问权限
                DirectorySecurity dirSecurity = dir.GetAccessControl(AccessControlSections.All);
                //设定文件ACL继承
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                //添加用户组的访问权限规则--完全控制权限
                FileSystemAccessRule usersFileSystemAccessRule = new FileSystemAccessRule(userGroup, FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
                dirSecurity.ModifyAccessRule(AccessControlModification.Add, usersFileSystemAccessRule, out bool isModified);
                //设置访问权限
                dir.SetAccessControl(dirSecurity);
                //返回结果
                return true;
            }
            catch (Exception)
            {
                //返回结果
                return false;
            }
        }
        #endregion
    }
}
