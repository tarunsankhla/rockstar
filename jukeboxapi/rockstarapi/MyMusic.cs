using System;
using System.IO;

namespace rockstarwebapi
{
    public class MyMusic
    {
        public string Faith { get; set; }
        public string RocketMan { get; set; }

        public MyMusic()
        {
            if (File.Exists("faith.txt"))
            {
                Faith = File.ReadAllText("faith.txt");
            }
            else
            {
                Faith = "??";
            }

            if (File.Exists("rocketman.txt"))
            {
                RocketMan = File.ReadAllText("rocketman.txt");
            }
            else
            {
                RocketMan = "??";
            }
        }
    }
}