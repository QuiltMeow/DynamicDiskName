using System.Collections.Generic;
using System.IO;
using System.Threading;
using YamlDotNet.Serialization;

namespace DynamicDiskName
{
    public class Config
    {
        public IDictionary<string, LabelData> setting
        {
            get;
            private set;
        }

        public IDictionary<Thread, LabelChangeTask> taskData
        {
            get;
            private set;
        }

        public Config()
        {
            setting = new Dictionary<string, LabelData>();
            taskData = new Dictionary<Thread, LabelChangeTask>();
        }

        public void loadSetting(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                using (StringReader data = new StringReader(streamReader.ReadToEnd()))
                {
                    Deserializer deserializer = new Deserializer();
                    IDictionary<string, LabelData> raw = deserializer.Deserialize<IDictionary<string, LabelData>>(data);
                    ISet<string> diskSet = new HashSet<string>();
                    foreach (KeyValuePair<string, LabelData> check in raw)
                    {
                        if (string.IsNullOrWhiteSpace(check.Key))
                        {
                            throw new EWException("設定檔案名稱錯誤");
                        }

                        LabelData rawSetting = check.Value;
                        if (string.IsNullOrWhiteSpace(rawSetting.name) || rawSetting.interval <= 0 || rawSetting.animation.Count <= 0)
                        {
                            throw new EWException("設定檔案資料錯誤");
                        }

                        if (diskSet.Contains(rawSetting.name))
                        {
                            throw new EWException("重複磁碟機標籤");
                        }
                        diskSet.Add(rawSetting.name);
                    }
                    setting = raw;
                }
            }
        }

        public void saveSetting(string save)
        {
            using (TextWriter writer = new StreamWriter(save))
            {
                Serializer serializer = new Serializer();
                serializer.Serialize(writer, setting);
            }
        }

        public void startAnimation()
        {
            foreach (KeyValuePair<string, LabelData> data in setting)
            {
                LabelChangeTask task = new LabelChangeTask(data.Value);
                Thread thread = new Thread(task.run);
                taskData.Add(thread, task);
                thread.Start();
            }
        }

        public void shutdown()
        {
            foreach (KeyValuePair<Thread, LabelChangeTask> task in taskData)
            {
                task.Value.stop();

                Thread thread = task.Key;
                thread.Abort();
                while (thread.ThreadState != ThreadState.Aborted)
                {
                }
            }
            taskData.Clear();
        }
    }
}