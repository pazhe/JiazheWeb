using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VO
{
    public class ManagersVO
    {
        private int mID;
        public int MID
        {
            get { return mID; }
            set { mID = value; }
        }
        private string mName;
        public string MName
        {
            get { return mName; }
            set { mName = value; }
        }
        private string mPassword;
        public string MPassword
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
    }
}
