using pract1test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pract1test
{
    public class Password
    {
        public string _password;

        public Password(string password)
        {
            _password = password;
        }

        public int GetLength()
        {
            return _password.Length;
        }

        public bool Length(int minimumLength)
        {
            return GetLength() >= minimumLength;
        }

        public bool Special()
        {
            return Regex.IsMatch(_password, @"[!@#$%^&*(),.?""':;{}|<>№;:]");
        }

        public bool Numbers()
        {
            return Regex.IsMatch(_password, @"[1234567890]");
        }
        public bool SmallWords()
        {
            return Regex.IsMatch(_password, @"[a-z]");
        }
        public bool BigWords()
        {
            return Regex.IsMatch(_password, @"[A-Z]");
        }
        public class Yspeh
        {
            private static int good = 0;

            protected static void YspehGood()
            {
                good++;
            }

            public static int kolvoGood()
            {
                return good;
            }
        }
    }
}