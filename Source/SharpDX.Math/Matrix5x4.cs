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
    /// Represents a 4x4 mathematical Matrix5x4.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Matrix5x4
    {
        /// <summary>
        /// The size of the <see cref="SharpDX.Matrix5x4"/> type, in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(typeof(Matrix5x4));

        /// <summary>
        /// A <see cref="SharpDX.Matrix5x4"/> with all of its components set to zero.
        /// </summary>
        public static readonly Matrix5x4 Zero = new Matrix5x4();

        /// <summary>
        /// The identity <see cref="SharpDX.Matrix5x4"/>.
        /// </summary>
        public static readonly Matrix5x4 Identity = new Matrix5x4() { M11 = 1.0f, M22 = 1.0f, M33 = 1.0f, M44 = 1.0f, M54 = 0.0f };

        /// <summary>
        /// Value at row 1 column 1 of the Matrix5x4.
        /// </summary>
        public float M11;

        /// <summary>
        /// Value at row 1 column 2 of the Matrix5x4.
        /// </summary>
        public float M12;

        /// <summary>
        /// Value at row 1 column 3 of the Matrix5x4.
        /// </summary>
        public float M13;

        /// <summary>
        /// Value at row 1 column 4 of the Matrix5x4.
        /// </summary>
        public float M14;

        /// <summary>
        /// Value at row 2 column 1 of the Matrix5x4.
        /// </summary>
        public float M21;

        /// <summary>
        /// Value at row 2 column 2 of the Matrix5x4.
        /// </summary>
        public float M22;

        /// <summary>
        /// Value at row 2 column 3 of the Matrix5x4.
        /// </summary>
        public float M23;

        /// <summary>
        /// Value at row 2 column 4 of the Matrix5x4.
        /// </summary>
        public float M24;

        /// <summary>
        /// Value at row 3 column 1 of the Matrix5x4.
        /// </summary>
        public float M31;

        /// <summary>
        /// Value at row 3 column 2 of the Matrix5x4.
        /// </summary>
        public float M32;

        /// <summary>
        /// Value at row 3 column 3 of the Matrix5x4.
        /// </summary>
        public float M33;

        /// <summary>
        /// Value at row 3 column 4 of the Matrix5x4.
        /// </summary>
        public float M34;

        /// <summary>
        /// Value at row 4 column 1 of the Matrix5x4.
        /// </summary>
        public float M41;

        /// <summary>
        /// Value at row 4 column 2 of the Matrix5x4.
        /// </summary>
        public float M42;

        /// <summary>
        /// Value at row 4 column 3 of the Matrix5x4.
        /// </summary>
        public float M43;

        /// <summary>
        /// Value at row 4 column 4 of the Matrix5x4.
        /// </summary>
        public float M44;

        /// <summary>
        /// Value at row 5 column 1 of the Matrix5x4.
        /// </summary>
        public float M51;

        /// <summary>
        /// Value at row 5 column 2 of the Matrix5x4.
        /// </summary>
        public float M52;

        /// <summary>
        /// Value at row 5 column 3 of the Matrix5x4.
        /// </summary>
        public float M53;

        /// <summary>
        /// Value at row 5 column 4 of the Matrix5x4.
        /// </summary>
        public float M54;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Matrix5x4"/> struct.
        /// </summary>
        /// <param name="value">The value that will be assigned to all components.</param>
        public Matrix5x4(float value)
        {
            M11 = M12 = M13 = M14 =
            M21 = M22 = M23 = M24 =
            M31 = M32 = M33 = M34 =
            M41 = M42 = M43 = M44 = 
            M51 = M52 = M53 = M54 = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Matrix5x4"/> struct.
        /// </summary>
        /// <param name="M11">The value to assign at row 1 column 1 of the Matrix5x4.</param>
        /// <param name="M12">The value to assign at row 1 column 2 of the Matrix5x4.</param>
        /// <param name="M13">The value to assign at row 1 column 3 of the Matrix5x4.</param>
        /// <param name="M14">The value to assign at row 1 column 4 of the Matrix5x4.</param>
        /// <param name="M21">The value to assign at row 2 column 1 of the Matrix5x4.</param>
        /// <param name="M22">The value to assign at row 2 column 2 of the Matrix5x4.</param>
        /// <param name="M23">The value to assign at row 2 column 3 of the Matrix5x4.</param>
        /// <param name="M24">The value to assign at row 2 column 4 of the Matrix5x4.</param>
        /// <param name="M31">The value to assign at row 3 column 1 of the Matrix5x4.</param>
        /// <param name="M32">The value to assign at row 3 column 2 of the Matrix5x4.</param>
        /// <param name="M33">The value to assign at row 3 column 3 of the Matrix5x4.</param>
        /// <param name="M34">The value to assign at row 3 column 4 of the Matrix5x4.</param>
        /// <param name="M41">The value to assign at row 4 column 1 of the Matrix5x4.</param>
        /// <param name="M42">The value to assign at row 4 column 2 of the Matrix5x4.</param>
        /// <param name="M43">The value to assign at row 4 column 3 of the Matrix5x4.</param>
        /// <param name="M44">The value to assign at row 4 column 4 of the Matrix5x4.</param>
        /// <param name="M51">The value to assign at row 5 column 1 of the Matrix5x4.</param>
        /// <param name="M52">The value to assign at row 5 column 2 of the Matrix5x4.</param>
        /// <param name="M53">The value to assign at row 5 column 3 of the Matrix5x4.</param>
        /// <param name="M54">The value to assign at row 5 column 4 of the Matrix5x4.</param>
        public Matrix5x4(float M11, float M12, float M13, float M14,
            float M21, float M22, float M23, float M24,
            float M31, float M32, float M33, float M34,
            float M41, float M42, float M43, float M44,
            float M51, float M52, float M53, float M54)
        {
            this.M11 = M11; this.M12 = M12; this.M13 = M13; this.M14 = M14;
            this.M21 = M21; this.M22 = M22; this.M23 = M23; this.M24 = M24;
            this.M31 = M31; this.M32 = M32; this.M33 = M33; this.M34 = M34;
            this.M41 = M41; this.M42 = M42; this.M43 = M43; this.M44 = M44;
            this.M51 = M51; this.M52 = M52; this.M53 = M53; this.M54 = M54;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Matrix5x4"/> struct.
        /// </summary>
        /// <param name="values">The values to assign to the components of the Matrix5x4. This must be an array with sixteen elements.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="values"/> contains more or less than sixteen elements.</exception>
        public Matrix5x4(float[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 20)
                throw new ArgumentOutOfRangeException("values", "There must be 20 input values for Matrix5x4.");

            M11 = values[0];
            M12 = values[1];
            M13 = values[2];
            M14 = values[3];

            M21 = values[4];
            M22 = values[5];
            M23 = values[6];
            M24 = values[7];

            M31 = values[8];
            M32 = values[9];
            M33 = values[10];
            M34 = values[11];

            M41 = values[12];
            M42 = values[13];
            M43 = values[14];
            M44 = values[15];

            M51 = values[16];
            M52 = values[17];
            M53 = values[18];
            M54 = values[19];
        }
    }
}
