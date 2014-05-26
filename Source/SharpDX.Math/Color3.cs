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
using System.Runtime.InteropServices;

namespace SharpDX
{
    /// <summary>
    /// Represents a color in the form of rgb.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Color3
    {
        private const string toStringFormat = "Red:{0} Green:{1} Blue:{2}";

        /// <summary>
        /// The Black color (0, 0, 0).
        /// </summary>
        public static readonly Color3 Black = new Color3(0.0f, 0.0f, 0.0f);

        /// <summary>
        /// The White color (1, 1, 1, 1).
        /// </summary>
        public static readonly Color3 White = new Color3(1.0f, 1.0f, 1.0f);

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
        /// Initializes a new instance of the <see cref="SharpDX.Color3"/> struct.
        /// </summary>
        /// <param name="value">The value that will be assigned to all components.</param>
        public Color3(float value)
        {
            Red = Green = Blue = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Color3"/> struct.
        /// </summary>
        /// <param name="red">The red component of the color.</param>
        /// <param name="green">The green component of the color.</param>
        /// <param name="blue">The blue component of the color.</param>
        public Color3(float red, float green, float blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Color3"/> struct.
        /// </summary>
        /// <param name="rgb">A packed integer containing all three color components in RGB order.
        /// The alpha component is ignored.</param>
        public Color3(int rgb)
        {
            Blue = ((rgb >> 16) & 255) / 255.0f;
            Green = ((rgb >> 8) & 255) / 255.0f;
            Red = (rgb & 255) / 255.0f;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Color3"/> struct.
        /// </summary>
        /// <param name="values">The values to assign to the red, green, and blue components of the color. This must be an array with three elements.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="values"/> contains more or less than four elements.</exception>
        public Color3(float[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 3)
                throw new ArgumentOutOfRangeException("values", "There must be three and only three input values for Color3.");

            Red = values[0];
            Green = values[1];
            Blue = values[2];
        }
    }
}
