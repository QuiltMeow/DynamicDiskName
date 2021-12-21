using System.Collections.Generic;
using System.Threading;

namespace DynamicDiskName
{
    public class LabelChangeTask
    {
        private bool start;
        private int current;
        private readonly LabelData data;

        public LabelChangeTask(LabelData data)
        {
            start = true;
            this.data = data;
        }

        private string next()
        {
            IList<string> animation = data.animation;
            string ret = animation[current++];
            if (current >= animation.Count)
            {
                current = 0;
            }
            return ret;
        }

        public void stop()
        {
            start = false;
        }

        public void run()
        {
            while (start)
            {
                LabelChangeUtil.setVolumeLabel(data.name, next());
                Thread.Sleep(data.interval * 1000);
            }
        }
    }
}