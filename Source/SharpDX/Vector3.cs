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
    /// Represents a three dimensional mathematical vector.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Vector3
    {
        /// <summary>
        /// The size of the <see cref="SharpDX.Vector3"/> type, in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(typeof(Vector3));

        /// <summary>
        /// A <see cref="SharpDX.Vector3"/> with all of its components set to zero.
        /// </summary>
        public static readonly Vector3 Zero = new Vector3();

        /// <summary>
        /// The X unit <see cref="SharpDX.Vector3"/> (1, 0, 0).
        /// </summary>
        public static readonly Vector3 UnitX = new Vector3(1.0f, 0.0f, 0.0f);

        /// <summary>
        /// The Y unit <see cref="SharpDX.Vector3"/> (0, 1, 0).
        /// </summary>
        public static readonly Vector3 UnitY = new Vector3(0.0f, 1.0f, 0.0f);

        /// <summary>
        /// The Z unit <see cref="SharpDX.Vector3"/> (0, 0, 1).
        /// </summary>
        public static readonly Vector3 UnitZ = new Vector3(0.0f, 0.0f, 1.0f);

        /// <summary>
        /// A <see cref="SharpDX.Vector3"/> with all of its components set to one.
        /// </summary>
        public static readonly Vector3 One = new Vector3(1.0f, 1.0f, 1.0f);

        /// <summary>
        /// A unit <see cref="SharpDX.Vector3"/> designating up (0, 1, 0).
        /// </summary>
        public static readonly Vector3 Up = new Vector3(0.0f, 1.0f, 0.0f);

        /// <summary>
        /// A unit <see cref="SharpDX.Vector3"/> designating down (0, -1, 0).
        /// </summary>
        public static readonly Vector3 Down = new Vector3(0.0f, -1.0f, 0.0f);

        /// <summary>
        /// A unit <see cref="SharpDX.Vector3"/> designating left (-1, 0, 0).
        /// </summary>
        public static readonly Vector3 Left = new Vector3(-1.0f, 0.0f, 0.0f);

        /// <summary>
        /// A unit <see cref="SharpDX.Vector3"/> designating right (1, 0, 0).
        /// </summary>
        public static readonly Vector3 Right = new Vector3(1.0f, 0.0f, 0.0f);

        /// <summary>
        /// A unit <see cref="SharpDX.Vector3"/> designating forward in a right-handed coordinate system (0, 0, -1).
        /// </summary>
        public static readonly Vector3 ForwardRH = new Vector3(0.0f, 0.0f, -1.0f);

        /// <summary>
        /// A unit <see cref="SharpDX.Vector3"/> designating forward in a left-handed coordinate system (0, 0, 1).
        /// </summary>
        public static readonly Vector3 ForwardLH = new Vector3(0.0f, 0.0f, 1.0f);

        /// <summary>
        /// A unit <see cref="SharpDX.Vector3"/> designating backward in a right-handed coordinate system (0, 0, 1).
        /// </summary>
        public static readonly Vector3 BackwardRH = new Vector3(0.0f, 0.0f, 1.0f);

        /// <summary>
        /// A unit <see cref="SharpDX.Vector3"/> designating backward in a left-handed coordinate system (0, 0, -1).
        /// </summary>
        public static readonly Vector3 BackwardLH = new Vector3(0.0f, 0.0f, -1.0f);

        /// <summary>
        /// The X component of the vector.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the vector.
        /// </summary>
        public float Y;

        /// <summary>
        /// The Z component of the vector.
        /// </summary>
        public float Z;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Vector3"/> struct.
        /// </summary>
        /// <param name="value">The value that will be assigned to all components.</param>
        public Vector3(float value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Vector3"/> struct.
        /// </summary>
        /// <param name="x">Initial value for the X component of the vector.</param>
        /// <param name="y">Initial value for the Y component of the vector.</param>
        /// <param name="z">Initial value for the Z component of the vector.</param>
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Vector3"/> struct.
        /// </summary>
        /// <param name="value">A vector containing the values with which to initialize the X and Y components.</param>
        /// <param name="z">Initial value for the Z component of the vector.</param>
        public Vector3(Vector2 value, float z)
        {
            X = value.X;
            Y = value.Y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpDX.Vector3"/> struct.
        /// </summary>
        /// <param name="values">The values to assign to the X, Y, and Z components of the vector. This must be an array with three elements.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="values"/> contains more or less than three elements.</exception>
        public Vector3(float[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 3)
                throw new ArgumentOutOfRangeException("values", "There must be three and only three input values for Vector3.");

            X = values[0];
            Y = values[1];
            Z = values[2];
        }
    }
}
