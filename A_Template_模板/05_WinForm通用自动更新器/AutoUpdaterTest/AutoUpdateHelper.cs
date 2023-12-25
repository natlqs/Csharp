using LinkTo.Toolkit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoUpdaterTest
{
    /// <summary>
    /// 配置文件的读写。
    /// </summary>
    public class AutoUpdateHelper
    {
        private readonly string AutoUpdateMode = string.Empty;

        public AutoUpdateHelper(string autoUpdateMode)
        {
            AutoUpdateMode = autoUpdateMode;
        }

        /// <summary>
        /// 加载本地自动更新配置文件
        /// </summary>
        /// <returns></returns>
        public static AutoUpdateConfig Load()
        {
            string filePath = string.Empty, fileContent = string.Empty;
            filePath = Path.Combine(Application.StartupPath, GlobalParam.AutoUpdateConfig_XmlFileName);
            AutoUpdateConfig config = new AutoUpdateConfig();
            fileContent = FileUtility.ReadFile(filePath);
            object obj = XmlUtility.Deserialize(typeof(AutoUpdateConfig), fileContent);
            config = obj as AutoUpdateConfig;
            return config;
        }

        /// <summary>
        /// 获取远端自动更新信息的版本号
        /// </summary>
        /// <returns></returns>
        public string GetRemoteAutoUpdateInfoVersion()
        {
            XDocument doc = new XDocument();
            doc = XDocument.Parse(GetRemoteAutoUpdateInfoXml());
            return doc.Element("AutoUpdateInfo").Element("NewVersion").Value;
        }

        /// <summary>
        /// 获取远端自动更新信息的XML文件内容
        /// </summary>
        /// <returns></returns>
        public string GetRemoteAutoUpdateInfoXml()
        {
            string remoteXmlAddress = AppConfig.Instance.AutoUpdateConfigData.AutoUpdateHttpUrl + "/" + GlobalParam.AutoUpdateInfo_XmlFileName;
            string receiveXmlPath = Path.Combine(AppConfig.Instance.TempPath, GlobalParam.AutoUpdateInfo_XmlFileName);
            string xmlString = string.Empty;

            if (Directory.Exists(AppConfig.Instance.TempPath) == false)
            {
                Directory.CreateDirectory(AppConfig.Instance.TempPath);
            }

            if (AutoUpdateMode.ToUpper() == "HTTP")
            {
                WebClient client = new WebClient();
                client.DownloadFile(remoteXmlAddress, receiveXmlPath);
            }

            if (File.Exists(receiveXmlPath))
            {
                xmlString = FileUtility.ReadFile(receiveXmlPath);
                return xmlString;
            }

            return string.Empty;
        }

        /// <summary>
        /// 写入本地自动更新配置的XML文件内容
        /// </summary>
        /// <returns></returns>
        public string WriteLocalAutoUpdateInfoXml()
        {
            string xmlPath = string.Empty, xmlValue = string.Empty;

            xmlPath = Path.Combine(AppConfig.Instance.TempPath, GlobalParam.AutoUpdateConfig_XmlFileName);
            xmlValue = XmlUtility.Serializer(typeof(AutoUpdateConfig), AppConfig.Instance.AutoUpdateConfigData);

            if (File.Exists(xmlPath))
            {
                File.Delete(xmlPath);
            }

            bool blSuccess = FileUtility.WriteFile(xmlPath, xmlValue);
            return blSuccess == true ? xmlPath : "";
        }
    }
}
