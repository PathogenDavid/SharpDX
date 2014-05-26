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
// THE SOFTWARE.using System;

using System;
using System.Runtime.InteropServices;

namespace SharpDX
{
    /// <summary>
    /// Direct2D Matrix3x2. Supports implicit cast from <see cref="SharpDX.Matrix"/>.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Matrix3x2
    {
        /// <summary>
        /// Gets the identity matrix.
        /// </summary>
        /// <value>The identity matrix.</value>
        public readonly static Matrix3x2 Identity = new Matrix3x2(1, 0, 0, 1, 0, 0);

        /// <summary>
        /// Element (1,1)
        /// </summary>
        public float M11;

        /// <summary>
        /// Element (1,2)
        /// </summary>
        public float M12;

        /// <summary>
        /// Element (2,1)
        /// </summary>
        public float M21;

        /// <summary>
        /// Element (2,2)
        /// </summary>
        public float M22;

        /// <summary>
        /// Element (3,1)
        /// </summary>
        public float M31;

        /// <summary>
        /// Element (3,2)
        /// </summary>
        public float M32;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Matrix3x2"/> struct.
        /// </summary>
        /// <param name="value">The value that will be assigned to all components.</param>
        public Matrix3x2(float value)
        {
            M11 = M12 = 
            M21 = M22 = 
            M31 = M32 = value; 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Matrix3x2"/> struct.
        /// </summary>
        /// <param name="M11">The value to assign at row 1 column 1 of the matrix.</param>
        /// <param name="M12">The value to assign at row 1 column 2 of the matrix.</param>
        /// <param name="M21">The value to assign at row 2 column 1 of the matrix.</param>
        /// <param name="M22">The value to assign at row 2 column 2 of the matrix.</param>
        /// <param name="M31">The value to assign at row 3 column 1 of the matrix.</param>
        /// <param name="M32">The value to assign at row 3 column 2 of the matrix.</param>
        public Matrix3x2(float M11, float M12, float M21, float M22, float M31, float M32)
        {
            this.M11 = M11; this.M12 = M12;
            this.M21 = M21; this.M22 = M22;
            this.M31 = M31; this.M32 = M32;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Matrix3x2"/> struct.
        /// </summary>
        /// <param name="values">The values to assign to the components of the matrix. This must be an array with six elements.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="values"/> contains more or less than six elements.</exception>
        public Matrix3x2(float[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 6)
                throw new ArgumentOutOfRangeException("values", "There must be six input values for Matrix3x2.");

            M11 = values[0];
            M12 = values[1];

            M21 = values[2];
            M22 = values[3];

            M31 = values[4];
            M32 = values[5];
        }

        /// <summary>
        /// Creates an array containing the elements of the matrix.
        /// </summary>
        /// <returns>A sixteen-element array containing the components of the matrix.</returns>
        public float[] ToArray()
        {
            return new[] { M11, M12, M21, M22, M31, M32 };
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="SharpDX.Matrix"/> to <see cref="SharpDX.Matrix3x2"/>.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Matrix3x2(Matrix matrix)
        {
            return new Matrix3x2
            {
                M11 = matrix.M11,
                M12 = matrix.M12,
                M21 = matrix.M21,
                M22 = matrix.M22,
                M31 = matrix.M41,
                M32 = matrix.M42
            };
        }
    }
}
