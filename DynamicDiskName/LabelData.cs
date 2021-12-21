using System.Collections.Generic;
using System.Text;

namespace DynamicDiskName
{
    public class LabelData
    {
        public string name
        {
            get;
            private set;
        }

        public int interval
        {
            get;
            set;
        }

        public IList<string> animation
        {
            get;
            set;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder().Append("磁碟機標籤 : ").AppendLine(name).Append("間隔 : ").AppendLine(interval.ToString()).Append("動態文字 : [");
            foreach (string data in animation)
            {
                sb.Append("\"").Append(data).Append("\", ");
            }
            sb.Length -= 2;
            sb.Append("]");
            return sb.ToString();
        }

        public LabelData()
        {
        }

        public LabelData(string name, int interval, IList<string> animation)
        {
            this.name = name;
            this.interval = interval;
            this.animation = animation;
        }
    }
}