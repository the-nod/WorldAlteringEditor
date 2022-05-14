﻿using Rampastring.Tools;
using System;

namespace TSMapEditor
{
    public static class Constants
    {
        public static int CellSizeX = 48;
        public static int CellSizeY = 24;

        public static string ExpectedClientExecutableName = "DTA.exe";
        public static string GameRegistryInstallPath = "SOFTWARE\\DawnOfTheTiberiumAge";

        public const int TextureSizeLimit = 16384;

        public static int MaxMapWidth = TextureSizeLimit / CellSizeX;
        public static int MaxMapHeight = TextureSizeLimit / CellSizeY;

        public const int ObjectHealthMax = 256;
        public const int FacingMax = 255;

        public const int MaxWaypoint = 100;

        // TODO parse from Rules.ini
        public const int ConditionYellowHP = 128;

        public const int UIEmptySideSpace = 10;
        public const int UIEmptyTopSpace = 10;
        public const int UIEmptyBottomSpace = 10;

        public const int UIHorizontalSpacing = 6;
        public const int UIVerticalSpacing = 6;

        public const int UIDefaultFont = 0;
        public const int UIBoldFont = 1;

        public const int UITextBoxHeight = 21;
        public const int UIButtonHeight = 23;

        public const int UITopBarMenuHeight = 23;

        public const int MAX_MAP_LENGTH_IN_DIMENSION = 512;
        public const int NO_OVERLAY = 255; // 0xFF
        public const int OverlayPackFormat = 80;

        public const string NoneValue1 = "<none>";
        public const string NoneValue2 = "None";

        public const bool HQRemap = true;
        public const float RemapBrightenFactor = 1.25f;

        public const bool DrawShadows = true;

        public const string ClipboardMapDataFormatValue = "ScenarioEditorCopiedMapData";

        public static void Init()
        {
            const string SectionName = "Constants";

            IniFile constantsIni = new IniFile(Environment.CurrentDirectory + "/Config/Constants.ini");

            CellSizeX = constantsIni.GetIntValue(SectionName, nameof(CellSizeX), CellSizeX);
            CellSizeY = constantsIni.GetIntValue(SectionName, nameof(CellSizeY), CellSizeY);
            ExpectedClientExecutableName = constantsIni.GetStringValue(SectionName, nameof(ExpectedClientExecutableName), ExpectedClientExecutableName);
            GameRegistryInstallPath = constantsIni.GetStringValue(SectionName, nameof(GameRegistryInstallPath), GameRegistryInstallPath);
        }
    }
}