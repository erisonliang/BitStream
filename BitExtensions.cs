﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitStreams
{
    public static class BitExtensions
    {

        #region GetBit

        public static Bit GetBit(this byte n, int index)
        {
            return n >> index;
        }

        public static Bit GetBit(this short n, int index)
        {
            return n >> index;
        }

        public static Bit GetBit(this ushort n, int index)
        {
            return n >> index;
        }

        public static Bit GetBit(this int n, int index)
        {
            return n >> index;
        }

        public static Bit GetBit(this uint n, int index)
        {
            return (byte)(n >> index);
        }

        public static Bit GetBit(this long n, int index)
        {
            return (byte)(n >> index);
        }

        public static Bit GetBit(this ulong n, int index)
        {
            return (byte)(n >> index);
        }

        #endregion

        #region CircularShift

        public static byte CircularShift(this byte n, int bits, bool leftShift)
        {
            if (leftShift)
            {
                n = (byte)(n << bits | n >> (8 - bits));
            }
            else
            {
                n = (byte)(n >> bits | n << (8 - bits));
            }
            return n;
        }

        public static short CircularShift(this short n, int bits, bool leftShift)
        {
            if (leftShift)
            {
                n = (short)(n << bits | n >> (16 - bits));
            }
            else
            {
                n = (short)(n >> bits | n << (16 - bits));
            }
            return n;
        }

        public static ushort CircularShift(this ushort n, int bits, bool leftShift)
        {
            if (leftShift)
            {
                n = (ushort)(n << bits | n >> (16 - bits));
            }
            else
            {
                n = (ushort)(n >> bits | n << (16 - bits));
            }
            return n;
        }

        public static int CircularShift(this int n, int bits, bool leftShift)
        {
            if (leftShift)
            {
                n = (n << bits | n >> (32 - bits));
            }
            else
            {
                n = (n >> bits | n << (32 - bits));
            }
            return n;
        }

        public static uint CircularShift(this uint n, int bits, bool leftShift)
        {
            if (leftShift)
            {
                n = (uint)(n << bits | n >> (32 - bits));
            }
            else
            {
                n = (uint)(n >> bits | n << (32 - bits));
            }
            return n;
        }

        public static long CircularShift(this long n, int bits, bool leftShift)
        {
            if (leftShift)
            {
                n = (n << bits | n >> (64 - bits));
            }
            else
            {
                n = (n >> bits | n << (64 - bits));
            }
            return n;
        }

        public static ulong CircularShift(this ulong n, int bits, bool leftShift)
        {
            if (leftShift)
            {
                n = (ulong)(n << bits | n >> (64 - bits));
            }
            else
            {
                n = (ulong)(n >> bits | n << (64 - bits));
            }
            return n;
        }

        #endregion
    }
}
