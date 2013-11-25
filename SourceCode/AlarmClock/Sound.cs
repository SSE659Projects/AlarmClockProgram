using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace AlarmClock
{
    class Sound
    {
        private string _command;
        public bool isOpen;
        private bool isPaused;
        public bool Loop = false;
        public bool Playing = false;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        public void close()
        {
            _command = "close MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        public void open(string sFileName)
        {
            _command = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = true;
        }

        public void pause()
        {
            if (isOpen)
            {
                if (!isPaused)
                {
                    _command = "pause MediaFile";
                    mciSendString(_command, null, 0, IntPtr.Zero);
                    return;
                }
                    play();
                }
        }

        public void play()
        {
            isPaused = false;
            Playing = true;
            _command = "play MediaFile";
            if (Loop)
                _command += "REPEAT";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }

        public void stop()
        {
            Playing = false;
            _command = "stop MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }
    }
}
