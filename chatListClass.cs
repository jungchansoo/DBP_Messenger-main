using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_off_proj
{
    class chatListClass
    {
        private string userId_;
        private int roomId_;
        private int count_;
        private string contents_;
        private string timeStamp_;

        public chatListClass(string userId, int roomId)
        {
            this.userId_ = userId;
            this.roomId_ = roomId;
        }

        public void setCount(int count) { this.count_ = count; }
        public void setContents(string contents) { this.contents_ = contents; }
        public void setTimeStamp(string time) { this.timeStamp_ = time; }

        public string getUID() { return userId_; }
        public int getRID() { return roomId_; }
        public int getCount() { return count_; }
        public string getContents() { return contents_; }

    }
}
