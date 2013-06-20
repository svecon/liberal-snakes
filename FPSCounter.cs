using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Snakes
{
    static class FPSCounter
    {

        static Label label;
        static DateTime last;
        static List<int> partitions = new List<int>();

        public static void CreateLabel(Form form)
        {
            last = DateTime.Now;

            label = new System.Windows.Forms.Label();
            label.Text = "0";
            label.Name = "fps";
            label.AutoSize = true;
            label.Dock = System.Windows.Forms.DockStyle.Right;
            label.BackColor = System.Drawing.Color.Transparent;
            label.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = System.Drawing.Color.Yellow;
            label.Parent = form;
            label.BringToFront();
        }

        public static void Tick()
        {
            if ((last == null) || (last.AddMilliseconds(100) < DateTime.Now))
            {
                last = DateTime.Now;
                partitions.Add(0);
                label.Text = getFPS().ToString();
            }

            if (partitions.Count > 10)
                partitions.RemoveAt(0);

            partitions[partitions.Count - 1]++;

        }

        public static int getFPS()
        {
            int sum = 0;

            for (int i = 0; i < partitions.Count; i++)
            {
                sum += 10 * partitions[i];
            }

            return sum / 10;
        }

        static double normalizeFPS()
        {
            return (getFPS()) / 10 * 10;
        }

        public static double AdjustSpeed()
        {
            return 60 / normalizeFPS();
        }

    }
}
