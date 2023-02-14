using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TdInterface
{
    internal static class Theme
    {
        // Colors - prep for themes to come

        static Theme()
        {
            bool isDark = false;
            if (isDark)
            {
                // Dark Mode - Not Complete

                // Background
                PrimaryBack = Color.FromArgb(22, 26, 37);
                SecondaryBack = Color.Red;

                // Text
                PrimaryText = Color.FromArgb(209, 212, 220);
                SecondaryText = Color.FromArgb(255, 0, 0);

                // Positive
                PrimaryPositive = Color.FromArgb(38, 166, 154);
                SecondaryPositive = Color.FromArgb(179, 237, 220);

                // Negative
                PrimaryNegative = Color.FromArgb(239, 83, 80);
                SecondaryNegative = Color.FromArgb(255, 203, 212);
            }
            else
            {
                // Light Mode

                // Background
                PrimaryBack = Color.FromArgb(240, 240, 240);
                SecondaryBack = Color.White;

                // Text
                PrimaryText = Color.Black;
                SecondaryText = Color.Black;

                // Positive
                PrimaryPositive = Color.FromArgb(0, 194, 136);
                SecondaryPositive = Color.FromArgb(179, 237, 220);

                // Negative
                PrimaryNegative = Color.FromArgb(255, 82, 109);
                SecondaryNegative = Color.FromArgb(255, 203, 212);
            }

            // Dark
        }

        public static Color PrimaryPositive
        { get; }

        public static Color SecondaryPositive
        { get; }

        public static Color PrimaryNegative
        { get; }

        public static Color SecondaryNegative
        { get; }

        public static Color PrimaryText
        { get; }

        public static Color SecondaryText
        { get; }

        public static Color PrimaryBack
        { get; }

        public static Color SecondaryBack
        { get; }
    }
}
