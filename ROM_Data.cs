﻿using System;
using System.Collections.Generic;

namespace MMRando
{

    public partial class ROMFuncs
    {

        static int FileTable = 0x1A500;
        static int SignAddr = 0x1A4D0;
        static int TxTFile = 0xAD1000;
        static int ObjTable = 0xC58C80;
        static int SceneTable = 0xC5A1E0;
        static int SceneFlagMasks = 0xC5C500;
        static int TxtTable = 0xC5D0D8;
        static int SeqTable = 0xC77B80;
        static int InstSetMap = 0xC77A60;

        static int GetItemTable = 0;
        static int BottleCatchTable = 0xCD7C08;

        static int GossipStart = 0x20B0;
        static int GossipEnd = 0x20E8;
        static int[] GossipExclude = { 0x20D0, 0x20D1, 0x20D2 };

        private class MMFile
        {
            public int Addr = new int();
            public int End = new int();
            public int Cmp_Addr = new int();
            public int Cmp_End = new int();
            public byte[] Data;
            public bool IsCompressed = false;
            public bool WasEdited = false;
        }

        private class vec16
        {
            public short x = new short();
            public short y = new short();
            public short z = new short();
        }

        private class MMMsg
        {
            public int Addr = new int();
            public int Size = new int();
        }

        private class MMSeq
        {
            public int Addr = new int();
            public int Size = new int();
            public byte[] Data;
        }

        private class Scene
        {
            public int File = new int();
            public int Number = new int();
            public List<Map> Maps = new List<Map>();
        }

        private class Map
        {
            public int File = new int();
            public int Header = new int();
            public int ActorAddr = new int();
            public int ObjAddr = new int();
            public List<int> Objects = new List<int>();
            public List<Actor> Actors = new List<Actor>();
        }

        private class Actor
        {
            //not fully reading actor data
            //probably won't need to?
            public int m = new int();
            public int n = new int();
            public vec16 p = new vec16();
            public vec16 r = new vec16();
            public int v = new int();
        }

        private class GetItemEntry
        {
            public byte ItemGained = new byte();
            public byte Flag = new byte();
            public byte Index = new byte();
            public byte Type = new byte();
            public short Message = new byte();
            public short Object = new byte();
        }

        private class BottleCatchEntry
        {
            public short Identifier = new short();
            public byte Type = new byte();
            public byte ItemGained = new byte();
            public byte Index = new byte();
            public byte Message = new byte();
        }

        static List<MMFile> MMFileList;
        static List<Scene> SceneList;
        static List<GetItemEntry> GetItemList;
        static List<BottleCatchEntry[]> BottleList;
        static List<int> GetItemIndices;
        static List<int[]> BottleIndices;

    }

}