using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    internal class Quaternion
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double W { get; set; }

        public Quaternion(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public static Quaternion operator +(Quaternion a, Quaternion b)
        {
            return new Quaternion(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }

        public static Quaternion operator -(Quaternion a, Quaternion b)
        {
            return new Quaternion(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }

        public static Quaternion operator *(Quaternion a, Quaternion b)
        {
            return new Quaternion(
                a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y,
                a.W * b.Y - a.X * b.Z + a.Y * b.W + a.Z * b.X,
                a.W * b.Z + a.X * b.Y - a.Y * b.X + a.Z * b.W,
                a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z
            );
        }

        public double Norm()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
        }

        public Quaternion Conjugate()
        {
            return new Quaternion(-X, -Y, -Z, W);
        }

        public Quaternion Inverse()
        {
            double norm = Norm();
            if (norm == 0)
                throw new InvalidOperationException("Quaternion has zero norm; cannot compute inverse.");

            return new Quaternion(-X / norm, -Y / norm, -Z / norm, W / norm);
        }

        public static bool operator ==(Quaternion a, Quaternion b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
        }

        public static bool operator !=(Quaternion a, Quaternion b)
        {
            return !(a == b);
        }

        public double[,] ToRotationMatrix()
        {
            double xx = X * X;
            double xy = X * Y;
            double xz = X * Z;
            double xw = X * W;
            double yy = Y * Y;
            double yz = Y * Z;
            double yw = Y * W;
            double zz = Z * Z;
            double zw = Z * W;

            return new double[,]
            {
            { 1 - 2 * (yy + zz), 2 * (xy - zw), 2 * (xz + yw) },
            { 2 * (xy + zw), 1 - 2 * (xx + zz), 2 * (yz - xw) },
            { 2 * (xz - yw), 2 * (yz + xw), 1 - 2 * (xx + yy) }
            };
        }
    }

}

