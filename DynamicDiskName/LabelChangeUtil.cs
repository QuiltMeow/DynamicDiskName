using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DynamicDiskName
{
    public class LabelChangeUtil
    {
        public static void setVolumeLabel(string volumeName, string volumeLabel)
        {
            string target = volumeName + ":\\";
            DriveInfo[] allDrive = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrive)
            {
                if (drive.IsReady && drive.Name == target)
                {
                    drive.VolumeLabel = volumeLabel;
                }
            }
        }

        public static string queryDiskLabel(string volumeName)
        {
            string target = volumeName + ":\\";
            DriveInfo[] allDrive = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrive)
            {
                if (drive.IsReady && drive.Name == target)
                {
                    return drive.VolumeLabel;
                }
            }
            return null;
        }

        public static IList<string> queryDiskList()
        {
            IList<string> ret = new List<string>();
            DriveInfo[] allDrive = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrive)
            {
                if (drive.IsReady)
                {
                    StringBuilder sb = new StringBuilder().Append(drive.Name);
                    sb.Length -= 2;
                    ret.Add(sb.ToString());
                }
            }
            return ret;
        }
    }
}