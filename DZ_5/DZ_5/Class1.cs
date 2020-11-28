using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_5
{
    class Room
    {
        public static int count = 0;

        double footage;
         double height;
        public int windows;
        public double a;// для площади a=0 
        public double b;
        double volume;



        public double A
        {
            get
            {
                return a;
            }
            set { a = value; }
        }
        public double B
        {
            get
            {
                return b;
            }
            set { b = value; }
        }

        public double Footage
        {
            get
            {
                return footage;
            }
            set {footage = value; }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set { height = value; }
        }
        public double Volume {get;set;}
        public int Windows
        {
            get
            {
                return Windows;
            }
            set { windows = value; }
        }


        public double SquareRectangle()
        {
            if (a * b != 0)
            {
                footage = a * b;
            }
            return footage;
        }

        public double VolumeRectangle()
        {
            volume = footage * height;
            return volume;
        }

        public Room()
        { 
            footage = 0;
            height = 0;
            windows = 0;

            count++;
        }

        public Room(double height,int windows,double a ,double b)
        {
            

            if (height < 0|| height == 0)
            {
                
                throw new Exception("Некорректная высота ");
            }
           this.height = height;

            if (windows < 0)
            {
               
                throw new Exception("Некорректное кол-во окон");
               
            }
            this.windows = windows;

            if (a < 0)
            {
                throw new Exception("Некорректное знач а");
            }
            this.a = a;

            if (b < 0)
            {
                throw new Exception("Некорректное знач а");
            }
            this.b = b;

     
            count++;
        }


        public Room(double footage, double height, int windows)
        {
            if (footage < 0)
            {
                throw new Exception("Некорректный метраж");
            }
            this.footage = footage;

            if (height < 0 || height == 0)
            {

                throw new Exception("Некорректная высота ");
            }
            this.height = height;

            if (windows < 0)
            {

                throw new Exception("Некорректное кол-во окон");

            }
            this.windows = windows;
        }

        public string info()
        {
            string footage_str;
            if (SquareRectangle() == 0 || footage == 0)
            {
                footage_str = "unknown";
            }
            else
            {
                footage_str = Convert.ToString(footage);
            }

            string ceilingHeight_str;
            if (height== 0)
            {
                ceilingHeight_str = "unknown";
            }
            else
            {
                ceilingHeight_str = Convert.ToString(height);
            }


            string windows_str;
            windows_str = Convert.ToString(windows);

            string volume_str;
            if (VolumeRectangle() == 0 || footage == 0)
            {
                volume_str = "unknown";
            }
            else
            {
                volume_str = Convert.ToString(volume);
            }



            return String.Format("Footage: {0}\n CeilingHeight: {1}\n Windows: {2}\n Volume: {3}",
           footage_str, ceilingHeight_str,windows_str,volume_str);
        }

    }
}
