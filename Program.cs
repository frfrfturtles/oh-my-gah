using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace oh_my_gah
{
    class Program
    {
        static void Main(string[] args)
        {
            int milliseconds = 1800;
            while (true)
            {
                System.Diagnostics.Process.Start("https://raw.githubusercontent.com/frfrfturtles/oh-my-gah/main/oh%20my%20gah.jpg");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"https://cdn.discordapp.com/attachments/904945940262170638/1007590664155967528/oh_my_gah.wav");
                player.Play();

                Thread.Sleep(milliseconds);
            }

        }
    }
}
