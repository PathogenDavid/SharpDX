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
    /// Represents a four dimensional mathematical vector of bool (32 bits per bool value).
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Bool4
    {
        /// <summary>
        /// The size of the <see cref = "Bool4" /> type, in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(typeof (Bool4));

        /// <summary>
        /// A <see cref = "Bool4" /> with all of its components set to false.
        /// </summary>
        public static readonly Bool4 False = new Bool4();

        /// <summary>
        /// The X unit <see cref = "Bool4" /> (true, 0, 0, 0).
        /// </summary>
        public static readonly Bool4 UnitX = new Bool4(true, false, false, false);

        /// <summary>
        /// The Y unit <see cref = "Bool4" /> (0, true, 0, 0).
        /// </summary>
        public static readonly Bool4 UnitY = new Bool4(false, true, false, false);

        /// <summary>
        /// The Z unit <see cref = "Bool4" /> (0, 0, true, 0).
        /// </summary>
        public static readonly Bool4 UnitZ = new Bool4(false, false, true, false);

        /// <summary>
        /// The W unit <see cref = "Bool4" /> (0, 0, 0, true).
        /// </summary>
        public static readonly Bool4 UnitW = new Bool4(false, false, false, true);

        /// <summary>
        /// A <see cref = "Bool4" /> with all of its components set to true.
        /// </summary>
        public static readonly Bool4 One = new Bool4(true, true, true, true);

        /// <summary>
        /// The X component of the vector.
        /// </summary>
        private int iX;

        /// <summary>
        /// The Y component of the vector.
        /// </summary>
        private int iY;

        /// <summary>
        /// The Z component of the vector.
        /// </summary>
        private int iZ;

        /// <summary>
        /// The W component of the vector.
        /// </summary>
        private int iW;

        /// <summary>
        /// The X component of the vector.
        /// </summary>
        public bool X
        {
            get
            {
                return iX != 0;
            }
            set
            {
                iX = value ? 1 : 0;
            }
        }

        /// <summary>
        /// The Y component of the vector.
        /// </summary>
        public bool Y
        {
            get
            {
                return iY != 0;
            }
            set
            {
                iY = value ? 1 : 0;
            }
        }

        /// <summary>
        /// The Z component of the vector.
        /// </summary>
        public bool Z
        {
            get
            {
                return iZ != 0;
            }
            set
            {
                iZ = value ? 1 : 0;
            }
        }

        /// <summary>
        /// The W component of the vector.
        /// </summary>
        public bool W
        {
            get
            {
                return iW != 0;
            }
            set
            {
                iW = value ? 1 : 0;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Bool4" /> struct.
        /// </summary>
        /// <param name = "value">The value that will be assigned to all components.</param>
        public Bool4(bool value)
        {
            iX = value ? 1 : 0;
            iY = value ? 1 : 0;
            iZ = value ? 1 : 0;
            iW = value ? 1 : 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Bool4" /> struct.
        /// </summary>
        /// <param name = "x">Initial value for the X component of the vector.</param>
        /// <param name = "y">Initial value for the Y component of the vector.</param>
        /// <param name = "z">Initial value for the Z component of the vector.</param>
        /// <param name = "w">Initial value for the W component of the vector.</param>
        public Bool4(bool x, bool y, bool z, bool w)
        {
            iX = x ? 1 : 0;
            iY = y ? 1 : 0;
            iZ = z ? 1 : 0;
            iW = w ? 1 : 0; 
        }


        /// <summary>
        /// Initializes a new instance of the <see cref = "Bool4" /> struct.
        /// </summary>
        /// <param name = "values">The values to assign to the X, Y, Z, and W components of the vector. This must be an array with four elements.</param>
        /// <exception cref = "ArgumentNullException">Thrown when <paramref name = "values" /> is <c>null</c>.</exception>
        /// <exception cref = "ArgumentOutOfRangeException">Thrown when <paramref name = "values" /> contains more or less than four elements.</exception>
        public Bool4(bool[] values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            if (values.Length != 4)
                throw new ArgumentOutOfRangeException(
                    "values",
                    "There must be four and only four input values for Bool4.");

            iX = values[0] ? 1 : 0;
            iY = values[1] ? 1 : 0;
            iZ = values[2] ? 1 : 0;
            iW = values[3] ? 1 : 0;
        }
    }
}
