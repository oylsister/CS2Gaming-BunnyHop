namespace BunnyHop
{
    public class PlayerJumpCount
    {
        public PlayerJumpCount(int jump = 0, bool complete = false)
        {
            _jumpCount = jump;
            _complete = complete;
        }

        private int _jumpCount;
        private bool _complete;

        public int JumpCount 
        { 
            get { return _jumpCount; } 
            set { _jumpCount = value; }
        }

        public bool Complete
        { 
            get { return _complete; } 
            set { _complete = value; }
        }
    }

    public class PlayerData : PlayerJumpCount
    {
        public PlayerData(string achieve, string reset, int count, bool complete = true)
        {
            _timeAcheived = achieve;
            _timeReset = reset;

            JumpCount = count;
            Complete = complete;
        }

        private string _timeAcheived;
        private string _timeReset;

        public string TimeAcheived
        {
            get { return _timeAcheived; }
            set { _timeAcheived = value; }
        }

        public string TimeReset
        {
            get { return _timeReset; }
            set { _timeReset = value; }
        }
    }
}
