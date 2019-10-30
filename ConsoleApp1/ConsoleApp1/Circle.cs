using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circle
    {
        private double radius;
        private string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
        public Circle(double r, string c)
        {
            radius = r;
            color = c;
        }
        public void setRadius(double newRadius)
        {
            radius = newRadius;
        }
        public void setColor(string newColor)
        {
            color = newColor;
        }
        public string getColor()
        {
            return color;
        }
        public double getCircumference()
        {
            return radius * 2 * Math.PI;
        }
        public double getRadius()
        {
            return radius;
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("Circle [radius = {0}, color = {1}]", getRadius(), getColor());
            return String.Format("Circle [radius = {0}]", getRadius());
            //return base.ToString();
        }
    }
}

