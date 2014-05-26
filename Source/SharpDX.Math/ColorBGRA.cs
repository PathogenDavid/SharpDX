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
using System;
using System.Runtime.InteropServices;

namespace SharpDX
{
    /// <summary>
    /// Represents a 32-bit color (4 bytes) in the form of BGRA (in byte order: B, G, B, A).
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct ColorBGRA
    {
        private const string toStringFormat = "A:{0} R:{1} G:{2} B:{3}";

        /// <summary>
        /// The blue component of the color.
        /// </summary>
        public byte B;

        /// <summary>
        /// The green component of the color.
        /// </summary>
        public byte G;

        /// <summary>
        /// The red component of the color.
        /// </summary>
        public byte R;

        /// <summary>
        /// The alpha component of the color.
        /// </summary>
        public byte A;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="value">The value that will be assigned to all components.</param>
        public ColorBGRA(byte value)
        {
            A = R = G = B = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="value">The value that will be assigned to all components.</param>
        public ColorBGRA(float value)
        {
            A = R = G = B = ToByte(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="red">The red component of the color.</param>
        /// <param name="green">The green component of the color.</param>
        /// <param name="blue">The blue component of the color.</param>
        /// <param name="alpha">The alpha component of the color.</param>
        public ColorBGRA(byte red, byte green, byte blue, byte alpha)
        {
            R = red;
            G = green;
            B = blue;
            A = alpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="red">The red component of the color.</param>
        /// <param name="green">The green component of the color.</param>
        /// <param name="blue">The blue component of the color.</param>
        /// <param name="alpha">The alpha component of the color.</param>
        public ColorBGRA(float red, float green, float blue, float alpha)
        {
            R = ToByte(red);
            G = ToByte(green);
            B = ToByte(blue);
            A = ToByte(alpha);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="value">The red, green, blue, and alpha components of the color.</param>
        public ColorBGRA(Vector4 value)
        {
            R = ToByte(value.X);
            G = ToByte(value.Y);
            B = ToByte(value.Z);
            A = ToByte(value.W);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="value">The red, green, and blue components of the color.</param>
        /// <param name="alpha">The alpha component of the color.</param>
        public ColorBGRA(Vector3 value, float alpha)
        {
            R = ToByte(value.X);
            G = ToByte(value.Y);
            B = ToByte(value.Z);
            A = ToByte(alpha);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="bgra">A packed integer containing all four color components in BGRA order.</param>
        public ColorBGRA(uint bgra)
        {
            A = (byte)((bgra >> 24) & 255);
            R = (byte)((bgra >> 16) & 255);
            G = (byte)((bgra >> 8) & 255);
            B = (byte)(bgra & 255);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="bgra">A packed integer containing all four color components in BGRA.</param>
        public ColorBGRA(int bgra)
        {
            A = (byte)((bgra >> 24) & 255);
            R = (byte)((bgra >> 16) & 255);
            G = (byte)((bgra >> 8) & 255);
            B = (byte)(bgra & 255);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="values">The values to assign to the red, green, and blue, alpha components of the color. This must be an array with four elements.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="values"/> contains more or less than four elements.</exception>
        public ColorBGRA(float[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 4)
                throw new ArgumentOutOfRangeException("values", "There must be four and only four input values for ColorBGRA.");

            B = ToByte(values[0]);
            G = ToByte(values[1]);
            R = ToByte(values[2]);
            A = ToByte(values[3]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.ColorBGRA"/> struct.
        /// </summary>
        /// <param name="values">The values to assign to the red, green, and blue, alpha components of the color. This must be an array with four elements.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="values"/> contains more or less than four elements.</exception>
        public ColorBGRA(byte[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 4)
                throw new ArgumentOutOfRangeException("values", "There must be four and only four input values for ColorBGRA.");

            B = values[0];
            G = values[1];
            R = values[2];
            A = values[3];
        }

        private static byte ToByte(float component)
        {
            var value = (int)(component * 255.0f);
            return (byte)(value < 0 ? 0 : value > 255 ? 255 : value);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="SharpDX.Color4"/> to <see cref="SharpDX.ColorBGRA"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator ColorBGRA(Color4 value)
        {
            return new ColorBGRA(value.Red, value.Green, value.Blue, value.Alpha);
        }

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all four color components.</returns>
        public int ToBgra()
        {
            int value = B;
            value |= G << 8;
            value |= R << 16;
            value |= A << 24;

            return (int)value;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="SharpDX.Color"/> to <see cref="SharpDX.ColorBGRA"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator ColorBGRA(Color value)
        {
            return new ColorBGRA(value.R, value.G, value.B, value.A);
        }
    }
}
