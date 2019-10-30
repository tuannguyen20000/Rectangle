﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle
    {
        private float length;
        private float width;
        public Rectangle()
        {
            this.length = 1.0f;
            this.width = 1.0f;
        }
        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        public float getLength()
        {
            return length;
        }
        public void setLength(float length)
        {
            this.length = length;
        }
        public float getWidth()
        {
            return width;
        }
        public void setWidth(float width)
        {
            this.width = width;
        }
        public double getArea()
        {
            return length * width;
        }
        public double getPerimeter()
        {
            return (length + width) * 2;
        }
        public override string ToString()
        {
            return string.Format("Rectangle [length={0}, width={1}]", getLength(), getWidth());
            //return base.ToString();
        }
    }
}
    

