﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExternalCrosshair
{
    [Serializable]
    public class CrosshairConfig
    {
        public string TargetProcessName;

        [XmlIgnore]
        public Color Color;
        [XmlIgnore]
        public Color OutlineColor;

        [XmlElement("Color")]
        public string ColorHtml
        {
            get { return ColorTranslator.ToHtml(Color); }
            set { Color = ColorTranslator.FromHtml(value); }
        }

        [XmlElement("OutlineColor")]
        public string OutlineColorHtml
        {
            get { return ColorTranslator.ToHtml(OutlineColor); }
            set { OutlineColor = ColorTranslator.FromHtml(value); }
        }

        public bool CenterPoint;
        public int Thickness;
        public int OutlineThickness;
        public int Separation;
        public int Size;
        public int Rotation;
        public double Opacity;

        public void DrawToSurface(Graphics g)
        {
            Pen outline = new Pen(OutlineColor, Thickness + OutlineThickness + 1);
            Pen inline = new Pen(Color, Thickness);
            g.TranslateTransform(g.ClipBounds.Width / 2, g.ClipBounds.Height / 2);
            g.RotateTransform(Rotation);

            // Left
            if (OutlineThickness > 0)
            {
                g.DrawLine(outline,
                    -(Separation + Size + OutlineThickness), 0,
                    -(Separation - OutlineThickness - 1), 0);
                g.DrawLine(outline,
                    +(Separation - OutlineThickness), 0,
                    +(Separation + Size + OutlineThickness + 1), 0);
                g.DrawLine(outline,
                    0, -(Separation + Size + OutlineThickness + 1),
                    0, -(Separation - OutlineThickness));
                g.DrawLine(outline,
                    0, +(Separation - OutlineThickness - 1),
                    0, +(Separation + Size + OutlineThickness));
            }

            if (Thickness > 0)
            {
                g.DrawLine(inline,
                    -(Separation + Size), 0,
                    -(Separation), 0);
                g.DrawLine(inline,
                    +(Separation), 0,
                    +(Separation + Size), 0);
                g.DrawLine(inline,
                    0, -(Separation + Size),
                    0, -(Separation));
                g.DrawLine(inline,
                    0, +(Separation),
                    0, +(Separation + Size));
            }

            if (CenterPoint && OutlineThickness > 0)
            {
                g.DrawLine(outline,
                    -(Thickness / 2 + OutlineThickness), 0,
                    +(Thickness / 2 + OutlineThickness + 1), 0);
            }

            if (CenterPoint && Thickness > 0)
            {
                g.DrawLine(inline,
                    -(Thickness / 2), 0,
                    +(Thickness / 2), 0);
            }
        }
    }
}