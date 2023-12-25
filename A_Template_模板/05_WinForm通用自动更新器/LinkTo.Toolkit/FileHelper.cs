using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTo.Toolkit
{
    public class FileHelper
    {
        private readonly string strUpdateFilesPath;

        public FileHelper(string strDirector)
        {
            strUpdateFilesPath = strDirector;
        }

        //保存所有的文件信息
        private List<FileInfo> listFiles = new List<FileInfo>();

        public List<FileInfo> GetAllFilesInDirectory(string strDirector)
        {
            DirectoryInfo directory = new DirectoryInfo(strDirector);
            DirectoryInfo[] directoryArray = directory.GetDirectories();
            FileInfo[] fileInfoArray = directory.GetFiles();
            if (fileInfoArray.Length > 0) listFiles.AddRange(fileInfoArray);

            foreach (DirectoryInfo item in directoryArray)
            {
                DirectoryInfo directoryA = new DirectoryInfo(item.FullName);
                DirectoryInfo[] directoryArrayA = directoryA.GetDirectories();
                GetAllFilesInDirectory(item.FullName);
            }
            return listFiles;
        }

        public string[] GetUpdateList(List<FileInfo> listFileInfo)
        {
            var fileArrary = listFileInfo.Cast<FileInfo>().Select(s => s.FullName.Replace(strUpdateFilesPath, "")).ToArray();
            return fileArrary;
        }

        /// <summary>
        /// 删除文件夹下的所有文件但不删除目录
        /// </summary>
        /// <param name="dirRoot"></param>
        public static void DeleteDirAllFile(string dirRoot)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(dirRoot));
            FileInfo[] files = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
            foreach (FileInfo item in files)
            {
                File.Delete(item.FullName);
            }
        }
    }
}
