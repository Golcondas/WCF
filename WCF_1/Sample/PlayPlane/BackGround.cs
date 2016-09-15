using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayPlane.Properties;

namespace PlayPlane
{
    public class BackGround:GameObject
    {
        //先导入背景图片
        private static Image imgBg = Resources.background;

        //给一个构造函数，调用父类的方法
        public BackGround(int x,int y,int speed):base(x,y,imgBg.Width,imgBg.Height,speed,0,Direction.Down)
        { }

        //绘制自己的图片
        public override void Draw(System.Drawing.Graphics drg)
        {
            this.Y += this.Speed;
            if (this.Y == 0)
            {
                this.Y = -850;
            }
            //坐标改变完之后，重新将背景写入到我们窗体中
            drg.DrawImage(imgBg, this.X, this.Y);


        }
    }
}
