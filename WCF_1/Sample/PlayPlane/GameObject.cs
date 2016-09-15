using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayPlane
{
    public enum Direction
    {
        /// <summary>
        /// 上
        /// </summary>
        Up,
        /// <summary>
        ///  下
        /// </summary>
        Down,
        /// <summary>
        /// 左
        /// </summary>
        Left,
        /// <summary>
        /// 右
        /// </summary>
        Right
    }
    /// <summary>
    /// 这个是游戏所需要的所有对象，封装所有的公共子类的成员
    /// </summary>
    public abstract class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Speed { get; set; }
        public int Life { get; set; }
        public Direction Dir { get; set; }

        public GameObject(int x, int y, int width, int height, int speed, int life, Direction dir)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Speed = speed;
            this.Life = life;
            this.Dir = dir;
        }

        //每个游戏对象在使用GDI+对象绘制图像时，绘制的方式都是不一样的
        //所以我需要在公共的方法里抽象出一个方法来绘制对象

        public abstract void Draw(Graphics drg);

        #region 在提供一个碰撞减速的函数，当前游戏函数的矩形
        /// <summary>
        /// 在提供一个碰撞减速的函数，当前游戏函数的矩形
        /// </summary>
        /// <returns></returns>
        public Rectangle GetRectangle()
        {
            return new Rectangle(this.X, this.Y, this.Width, this.Height);
        } 
        #endregion

        /// <summary>
        /// 移动的虚方法，每个子类如果有不同方向的地方，则需要重写
        /// </summary>
        public virtual void Move()
        {
            switch (this.Dir)
            {
                case Direction.Up:
                    this.Y -= this.Speed;
                    break;
                case Direction.Down:
                    this.Y += this.Speed;
                    break;
                case Direction.Left:
                    this.X -= this.Speed;
                    break;
                case Direction.Right:
                    this.X += this.Speed;
                    break;
            }

            //移动完成之后，可以产科是否超出了窗体
            if (this.X <= 0)
            {
                this.X = 0;
            }
            if(this.X>=400)
            {
                this.X = 400;
            }
            if(this.Y<=0)
            {
                this.Y = 0;
            }
            if(this.Y>=850)
            {
                this.Y = 850;
            }
        }
    }


}
