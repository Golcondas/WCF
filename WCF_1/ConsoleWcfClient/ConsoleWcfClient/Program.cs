using ConsoleWcfClient.ServicePeople;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyClient client = new FlyClient();
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var a=client.Fly("大漠孤烟直")+"";
            watch.Stop();
            Console.WriteLine(a);
            Console.WriteLine("请求时间：" + formatLongToTimeStr((int)watch.ElapsedMilliseconds) + " 毫秒：" + watch.ElapsedMilliseconds);
            Console.ReadLine();
        }

         static String formatLongToTimeStr(int l)
        {
            String str = "";
            int hour = 0;
            int minute = 0;
            int second = 0;
            second = (int)l / 1000;

            if (second > 60)
            {
                minute = second / 60;
                second = second % 60;
            }
            if (minute > 60)
            {
                hour = minute / 60;
                minute = minute % 60;
            }
            return (hour.ToString() + "小时" + minute.ToString() + "分钟"
                + second.ToString() + "秒");
        }
    }
}
