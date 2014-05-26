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
    /// Define a RectangleF. This structure is slightly different from System.Drawing.RectangleF as it is
    /// internally storing Left,Top,Right,Bottom instead of Left,Top,Width,Height.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RectangleF
    {
        private float _left;
        private float _top;
        private float _right;
        private float _bottom;

        /// <summary>
        /// An empty rectangle.
        /// </summary>
        public static readonly RectangleF Empty;

        /// <summary>
        /// An infinite rectangle. See remarks.
        /// </summary>
        /// <remarks>
        /// http://msdn.microsoft.com/en-us/library/windows/desktop/dd372261%28v=vs.85%29.aspx
        /// Any properties that involve computations, like <see cref="Center"/>, <see cref="Width"/> or <see cref="Height"/>
        /// may return incorrect results - <see cref="float.NaN"/>.
        /// </remarks>
        public static readonly RectangleF Infinite;

        static RectangleF()
        {
            Empty = new RectangleF();
            Infinite = new RectangleF
                       {
                           Left = float.NegativeInfinity,
                           Top = float.NegativeInfinity,
                           Right = float.PositiveInfinity,
                           Bottom = float.PositiveInfinity
                       };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleF"/> struct.
        /// </summary>
        /// <param name="x">The left.</param>
        /// <param name="y">The top.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public RectangleF(float x, float y, float width, float height)
        {
            _left = x;
            _top = y;
            _right = x + width;
            _bottom = y + height;
        }

        /// <summary>
        /// Gets or sets the X position of the left edge.
        /// </summary>
        /// <value>The left.</value>
        public float Left
        {
            get { return _left; }
            set { _left = value; }
        }

        /// <summary>
        /// Gets or sets the top.
        /// </summary>
        /// <value>The top.</value>
        public float Top
        {
            get { return _top; }
            set { _top = value; }
        }

        /// <summary>
        /// Gets or sets the right.
        /// </summary>
        /// <value>The right.</value>
        public float Right
        {
            get { return _right; }
            set { _right = value; }
        }

        /// <summary>
        /// Gets or sets the bottom.
        /// </summary>
        /// <value>The bottom.</value>
        public float Bottom
        {
            get { return _bottom; }
            set { _bottom = value; }
        }
    }
}
