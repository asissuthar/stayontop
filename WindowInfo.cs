using System;

namespace StayOnTop
{
    class WindowInfo
    {

        public WindowInfo(string title, IntPtr handle)
        {
            this.Title = title;
            this.Handle = handle;
        }

        public string Title { get; set; }

        public IntPtr Handle { get; set; }
    }
}
