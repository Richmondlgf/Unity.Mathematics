// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double4x4 : System.IEquatable<double4x4>, IFormattable
    {
        public double4 c0;
        public double4 c1;
        public double4 c2;
        public double4 c3;

        /// <summary>double4x4 identity transform.</summary>
        public static readonly double4x4 identity = new double4x4(1.0, 0.0, 0.0, 0.0,   0.0, 1.0, 0.0, 0.0,   0.0, 0.0, 1.0, 0.0,   0.0, 0.0, 0.0, 1.0);

        /// <summary>double4x4 zero value.</summary>
        public static readonly double4x4 zero = new double4x4(0.0, 0.0, 0.0, 0.0,   0.0, 0.0, 0.0, 0.0,   0.0, 0.0, 0.0, 0.0,   0.0, 0.0, 0.0, 0.0);


        /// <summary>Constructs a double4x4 matrix from 4 double4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(double4 c0, double4 c1, double4 c2, double4 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a double4x4 matrix from 16 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(double m00, double m01, double m02, double m03,
                         double m10, double m11, double m12, double m13,
                         double m20, double m21, double m22, double m23,
                         double m30, double m31, double m32, double m33)
        { 
            this.c0 = new double4(m00, m10, m20, m30);
            this.c1 = new double4(m01, m11, m21, m31);
            this.c2 = new double4(m02, m12, m22, m32);
            this.c3 = new double4(m03, m13, m23, m33);
        }

        /// <summary>Constructs a double4x4 matrix constructed from a single double value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(double v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a double4x4 matrix from a single bool value by converting it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(bool v)
        {
            this.c0 = math.select(new double4(0.0), new double4(1.0), v);
            this.c1 = math.select(new double4(0.0), new double4(1.0), v);
            this.c2 = math.select(new double4(0.0), new double4(1.0), v);
            this.c3 = math.select(new double4(0.0), new double4(1.0), v);
        }

        /// <summary>Constructs a double4x4 matrix from a bool4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(bool4x4 v)
        {
            this.c0 = math.select(new double4(0.0), new double4(1.0), v.c0);
            this.c1 = math.select(new double4(0.0), new double4(1.0), v.c1);
            this.c2 = math.select(new double4(0.0), new double4(1.0), v.c2);
            this.c3 = math.select(new double4(0.0), new double4(1.0), v.c3);
        }

        /// <summary>Constructs a double4x4 matrix from a single int value by converting it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a double4x4 matrix from a int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(int4x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        /// <summary>Constructs a double4x4 matrix from a single uint value by converting it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a double4x4 matrix from a uint4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(uint4x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        /// <summary>Constructs a double4x4 matrix from a single float value by converting it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a double4x4 matrix from a float4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x4(float4x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x4(double v) { return new double4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double4x4(bool v) { return new double4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double4x4(bool4x4 v) { return new double4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x4(int v) { return new double4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x4(int4x4 v) { return new double4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x4(uint v) { return new double4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x4(uint4x4 v) { return new double4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x4(float v) { return new double4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x4(float4x4 v) { return new double4x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator * (double4x4 lhs, double4x4 rhs) { return new double4x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator * (double4x4 lhs, double rhs) { return new double4x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator * (double lhs, double4x4 rhs) { return new double4x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator + (double4x4 lhs, double4x4 rhs) { return new double4x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator + (double4x4 lhs, double rhs) { return new double4x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator + (double lhs, double4x4 rhs) { return new double4x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator - (double4x4 lhs, double4x4 rhs) { return new double4x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator - (double4x4 lhs, double rhs) { return new double4x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator - (double lhs, double4x4 rhs) { return new double4x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator / (double4x4 lhs, double4x4 rhs) { return new double4x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator / (double4x4 lhs, double rhs) { return new double4x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator / (double lhs, double4x4 rhs) { return new double4x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator % (double4x4 lhs, double4x4 rhs) { return new double4x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator % (double4x4 lhs, double rhs) { return new double4x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator % (double lhs, double4x4 rhs) { return new double4x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator ++ (double4x4 val) { return new double4x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator -- (double4x4 val) { return new double4x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (double4x4 lhs, double4x4 rhs) { return new bool4x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (double4x4 lhs, double rhs) { return new bool4x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (double lhs, double4x4 rhs) { return new bool4x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (double4x4 lhs, double4x4 rhs) { return new bool4x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (double4x4 lhs, double rhs) { return new bool4x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (double lhs, double4x4 rhs) { return new bool4x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (double4x4 lhs, double4x4 rhs) { return new bool4x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (double4x4 lhs, double rhs) { return new bool4x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (double lhs, double4x4 rhs) { return new bool4x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (double4x4 lhs, double4x4 rhs) { return new bool4x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (double4x4 lhs, double rhs) { return new bool4x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (double lhs, double4x4 rhs) { return new bool4x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator - (double4x4 val) { return new double4x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 operator + (double4x4 val) { return new double4x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (double4x4 lhs, double4x4 rhs) { return new bool4x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (double4x4 lhs, double rhs) { return new bool4x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (double lhs, double4x4 rhs) { return new bool4x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (double4x4 lhs, double4x4 rhs) { return new bool4x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (double4x4 lhs, double rhs) { return new bool4x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (double lhs, double4x4 rhs) { return new bool4x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // [int index] 
        unsafe public double4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double4x4* array = &this) { return ((double4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double4x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double4x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z, c0.w, c1.w, c2.w, c3.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider), c3.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a double4x4 matrix constructed from 4 double4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(double4 c0, double4 c1, double4 c2, double4 c3) { return new double4x4(c0, c1, c2, c3); }

        /// <summary>Returns a double4x4 matrix constructed from from 16 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(double m00, double m01, double m02, double m03,
                                          double m10, double m11, double m12, double m13,
                                          double m20, double m21, double m22, double m23,
                                          double m30, double m31, double m32, double m33)
        {
            return new double4x4(m00, m01, m02, m03,
                                 m10, m11, m12, m13,
                                 m20, m21, m22, m23,
                                 m30, m31, m32, m33);
        }

        /// <summary>Returns a double4x4 matrix constructed from a single double value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(double v) { return new double4x4(v); }

        /// <summary>Returns a double4x4 matrix constructed from a single bool value by convering it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(bool v) { return new double4x4(v); }

        /// <summary>Return a double4x4 matrix constructed from a bool4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(bool4x4 v) { return new double4x4(v); }

        /// <summary>Returns a double4x4 matrix constructed from a single int value by convering it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(int v) { return new double4x4(v); }

        /// <summary>Return a double4x4 matrix constructed from a int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(int4x4 v) { return new double4x4(v); }

        /// <summary>Returns a double4x4 matrix constructed from a single uint value by convering it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(uint v) { return new double4x4(v); }

        /// <summary>Return a double4x4 matrix constructed from a uint4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(uint4x4 v) { return new double4x4(v); }

        /// <summary>Returns a double4x4 matrix constructed from a single float value by convering it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(float v) { return new double4x4(v); }

        /// <summary>Return a double4x4 matrix constructed from a float4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 double4x4(float4x4 v) { return new double4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 rotate(double4x4 a, double3 b)
        {
            return (a.c0 * b.x + a.c1 * b.y + a.c2 * b.z).xyz;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 transform(double4x4 a, double3 b)
        {
            return (a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3).xyz;
        }

        /// <summary>Return the double4x4 transpose of a double4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x4 transpose(double4x4 v)
        {
            return double4x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w,
                v.c3.x, v.c3.y, v.c3.z, v.c3.w);
        }

        public static double4x4 inverse(double4x4 m)
        {
            double4 c0 = m.c0;
            double4 c1 = m.c1;
            double4 c2 = m.c2;
            double4 c3 = m.c3;

            double4 r0y_r1y_r0x_r1x = movelh(c1, c0);
            double4 r0z_r1z_r0w_r1w = movelh(c2, c3);
            double4 r2y_r3y_r2x_r3x = movehl(c0, c1);
            double4 r2z_r3z_r2w_r3w = movehl(c3, c2);

            double4 r1y_r2y_r1x_r2x = shuffle(c1, c0, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightZ);
            double4 r1z_r2z_r1w_r2w = shuffle(c2, c3, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightZ);
            double4 r3y_r0y_r3x_r0x = shuffle(c1, c0, ShuffleComponent.LeftW, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightX);
            double4 r3z_r0z_r3w_r0w = shuffle(c2, c3, ShuffleComponent.LeftW, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightX);

            double4 r0_wzyx = shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);
            double4 r1_wzyx = shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightW);
            double4 r2_wzyx = shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);
            double4 r3_wzyx = shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightW);
            double4 r0_xyzw = shuffle(r0y_r1y_r0x_r1x, r0z_r1z_r0w_r1w, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);

            // Calculate remaining inner term pairs. inner terms have zw=-xy, so we only have to calculate xy and can pack two pairs per vector.
            double4 inner12_23 = r1y_r2y_r1x_r2x * r2z_r3z_r2w_r3w - r1z_r2z_r1w_r2w * r2y_r3y_r2x_r3x;
            double4 inner02_13 = r0y_r1y_r0x_r1x * r2z_r3z_r2w_r3w - r0z_r1z_r0w_r1w * r2y_r3y_r2x_r3x;
            double4 inner30_01 = r3z_r0z_r3w_r0w * r0y_r1y_r0x_r1x - r3y_r0y_r3x_r0x * r0z_r1z_r0w_r1w;

            // Expand inner terms back to 4 components. zw signs still need to be flipped
            double4 inner12 = shuffle(inner12_23, inner12_23, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            double4 inner23 = shuffle(inner12_23, inner12_23, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            double4 inner02 = shuffle(inner02_13, inner02_13, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            double4 inner13 = shuffle(inner02_13, inner02_13, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            // Calculate minors
            double4 minors0 = r3_wzyx * inner12 - r2_wzyx * inner13 + r1_wzyx * inner23;

            double4 denom = r0_xyzw * minors0;

            // Horizontal sum of denominator. Free sign flip of z and w compensates for missing flip in inner terms.
            denom = denom + shuffle(denom, denom, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightZ);   // x+y        x+y            z+w            z+w
            denom = denom - shuffle(denom, denom, ShuffleComponent.LeftZ, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.RightX);   // x+y-z-w  x+y-z-w        z+w-x-y        z+w-x-y

            double4 rcp_denom_ppnn = double4(1.0) / denom;
            double4x4 res;
            res.c0 = minors0 * rcp_denom_ppnn;

            double4 inner30 = shuffle(inner30_01, inner30_01, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            double4 inner01 = shuffle(inner30_01, inner30_01, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            double4 minors1 = r2_wzyx * inner30 - r0_wzyx * inner23 - r3_wzyx * inner02;
            res.c1 = minors1 * rcp_denom_ppnn;

            double4 minors2 = r0_wzyx * inner13 - r1_wzyx * inner30 - r3_wzyx * inner01;
            res.c2 = minors2 * rcp_denom_ppnn;

            double4 minors3 = r1_wzyx * inner02 - r0_wzyx * inner12 + r2_wzyx * inner01;
            res.c3 = minors3 * rcp_denom_ppnn;
            return res;
        }

        // Fast matrix inverse for rigid transforms (Orthonormal basis and translation)
        public static double4x4 fastinverse(double4x4 m)
        {
            double4 c0 = m.c0;
            double4 c1 = m.c1;
            double4 c2 = m.c2;
            double4 pos = m.c3;

            double4 zero = double4(0);

            double4 t0 = unpacklo(c0, c2);
            double4 t1 = unpacklo(c1, zero);
            double4 t2 = unpackhi(c0, c2);
            double4 t3 = unpackhi(c1, zero);

            double4 r0 = unpacklo(t0, t1);
            double4 r1 = unpackhi(t0, t1);
            double4 r2 = unpacklo(t2, t3);

            pos = -(r0 * pos.x + r1 * pos.y + r2 * pos.z);
            pos.w = 1.0f;

            return double4x4(r0, r1, r2, pos);
        }

        public static double determinant(double4x4 m)
        {
            double4 c0 = m.c0;
            double4 c1 = m.c1;
            double4 c2 = m.c2;
            double4 c3 = m.c3;

            double m00 = c1.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c1.z * c3.w - c1.w * c3.z) + c3.y * (c1.z * c2.w - c1.w * c2.z);
            double m01 = c0.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c2.w - c0.w * c2.z);
            double m02 = c0.y * (c1.z * c3.w - c1.w * c3.z) - c1.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c1.w - c0.w * c1.z);
            double m03 = c0.y * (c1.z * c2.w - c1.w * c2.z) - c1.y * (c0.z * c2.w - c0.w * c2.z) + c2.y * (c0.z * c1.w - c0.w * c1.z);

            return c0.x * m00 - c1.x * m01 + c2.x * m02 - c3.x * m03;
        }

        /// <summary>Returns a uint hash code of a double4x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double4x4 v)
        {
            return csum(fold_to_uint(v.c0) * uint4(0xE857DCE1u, 0xF62213C5u, 0x9CDAA959u, 0xAA269ABFu) + 
                        fold_to_uint(v.c1) * uint4(0xD54BA36Fu, 0xFD0847B9u, 0x8189A683u, 0xB139D651u) + 
                        fold_to_uint(v.c2) * uint4(0xE7579997u, 0xEF7D56C7u, 0x66F38F0Bu, 0x624256A3u) + 
                        fold_to_uint(v.c3) * uint4(0x5292ADE1u, 0xD2E590E5u, 0xF25BE857u, 0x9BC17CE7u)) + 0xC8B86851u;
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a double4x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(double4x4 v)
        {
            return (fold_to_uint(v.c0) * uint4(0x64095221u, 0xADF428FFu, 0xA3977109u, 0x745ED837u) + 
                    fold_to_uint(v.c1) * uint4(0x9CDC88F5u, 0xFA62D721u, 0x7E4DB1CFu, 0x68EEE0F5u) + 
                    fold_to_uint(v.c2) * uint4(0xBC3B0A59u, 0x816EFB5Du, 0xA24E82B7u, 0x45A22087u) + 
                    fold_to_uint(v.c3) * uint4(0xFC104C3Bu, 0x5FFF6B19u, 0x5E6CBF3Bu, 0xB546F2A5u)) + 0xBBCF63E7u;
        }

    }
}
