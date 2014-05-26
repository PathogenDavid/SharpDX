// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// -----------------------------------------------------------------------------
// Original code from SlimMath project. http://code.google.com/p/slimmath/
// Greetings to SlimDX Group. Original code published with the following license:
// -----------------------------------------------------------------------------
/*
* Copyright (c) 2007-2011 SlimDX Group
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/
using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace SharpDX
{
    /// <summary>
    /// Represents a color in the form of rgba.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Color4
    {
        private const string toStringFormat = "Alpha:{0} Red:{1} Green:{2} Blue:{3}";

        /// <summary>
        /// The Black color (0, 0, 0, 1).
        /// </summary>
        public static readonly Color4 Black = new Color4(0.0f, 0.0f, 0.0f, 1.0f);

        /// <summary>
        /// The White color (1, 1, 1, 1).
        /// </summary>
        public static readonly Color4 White = new Color4(1.0f, 1.0f, 1.0f, 1.0f);

        /// <summary>
        /// The red component of the color.
        /// </summary>
        public float Red;

        /// <summary>
        /// The green component of the color.
        /// </summary>
        public float Green;

        /// <summary>
        /// The blue component of the color.
        /// </summary>
        public float Blue;

        /// <summary>
        /// The alpha component of the color.
        /// </summary>
        public float Alpha;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Color4"/> struct.
        /// </summary>
        /// <param name="value">The value that will be assigned to all components.</param>
        public Color4(float value)
        {
            Alpha = Red = Green = Blue = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Color4"/> struct.
        /// </summary>
        /// <param name="red">The red component of the color.</param>
        /// <param name="green">The green component of the color.</param>
        /// <param name="blue">The blue component of the color.</param>
        /// <param name="alpha">The alpha component of the color.</param>
        public Color4(float red, float green, float blue, float alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Color4"/> struct.
        /// </summary>
        /// <param name="rgba">A packed integer containing all four color components in RGBA order.</param>
        public Color4(uint rgba)
        {
            Alpha = ((rgba >> 24) & 255) / 255.0f;
            Blue = ((rgba >> 16) & 255) / 255.0f;
            Green = ((rgba >> 8) & 255) / 255.0f;
            Red = (rgba & 255) / 255.0f;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Color4"/> struct.
        /// </summary>
        /// <param name="rgba">A packed integer containing all four color components in RGBA order.</param>
        public Color4(int rgba)
        {
            Alpha = ((rgba >> 24) & 255) / 255.0f;
            Blue = ((rgba >> 16) & 255) / 255.0f;
            Green = ((rgba >> 8) & 255) / 255.0f;
            Red = (rgba & 255) / 255.0f;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Color4"/> struct.
        /// </summary>
        /// <param name="values">The values to assign to the red, green, blue, and alpha components of the color. This must be an array with four elements.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="values"/> contains more or less than four elements.</exception>
        public Color4(float[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 4)
                throw new ArgumentOutOfRangeException("values", "There must be four and only four input values for Color4.");

            Red = values[0];
            Green = values[1];
            Blue = values[2];
            Alpha = values[3];
        }
    }
}
