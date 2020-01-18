﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextArt.Options;

namespace TextArt.Generators
{
    public class TextArtGenerator
    {
        private Image m_source;
        private TextArtGeneratorOptions m_options { get; set; }

        public TextArtGenerator(Image source, TextArtGeneratorOptions options) 
        {
            m_source = source;
            m_options = options;
        }

        public Image Generate()
        {
            var random = new Random(m_options.Seed);
            var original_width = m_source.Width;
            var original_height = m_source.Height;
            var x_step = m_options.x_step;
            var y_step = m_options.y_step;

            var generated = new Bitmap(original_width, original_height);

            Graphics gfx_generated = Graphics.FromImage(generated);

            for (int x = 0; x < original_width; x += x_step)
            {
                for (int y = 0; y < original_height; y += y_step)
                {
                    var fontSize = random.Next(m_options.MinimumFontSize, m_options.MaximumFontSize);
                    var font = new Font(m_options.FontName, fontSize);
                    var pixel = ((Bitmap)m_source).GetPixel(x, y);
                    var brush = new SolidBrush(pixel);
                    var character = m_options.Alphabet[random.Next(0, m_options.Alphabet.Length)].ToString();

                    var character_dimension = gfx_generated.MeasureString(character, font);

                    var width = character_dimension.Width;
                    var height = character_dimension.Height;

                    PointF point = GetOffsetCoordinates(x, y, width, height);

                    gfx_generated.DrawString(character, font, brush, point);
                }
            }

           return generated;
        }

        private PointF GetOffsetCoordinates(float x, float y, float width, float height )
        {
            var centered_x = (x - (width / 2F));
            var centered_y = (y - (height / 2F));

            return new PointF(centered_x, centered_y);
        }
    }
}

         
    

