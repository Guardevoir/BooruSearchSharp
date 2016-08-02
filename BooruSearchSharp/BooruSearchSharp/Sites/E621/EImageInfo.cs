﻿using System.Collections.Generic;

namespace BooruSearchSharp.E621
{
    public class EImageInfo
    {
        public int ID { get; set; }
        public string Tags { get; set; }
        public string Description { get; set; }
        public Creation Created_At { get; set; }
        public int Creator_ID { get; set; }
        public string Author { get; set; }
        public int Change { get; set; }
        public string Source { get; set; }
        public int Score { get; set; }
        public string MD5 { get; set; }
        public int File_Size { get; set; }
        public string File_URL { get; set; }
        public string File_Ext { get; set; }
        public string Preview_URL { get; set; }
        public int Preview_Width { get; set; }
        public int Preview_Height { get; set; }
        public string Sample_URL { get; set; }
        public int Sample_Width { get; set; }
        public int Sample_Height { get; set; }
        public char Rating { get; set; }
        public string Status { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Has_Comments { get; set; }
        public bool Has_Notes { get; set; }
        public bool Has_Children { get; set; }
        public string Children { get; set; }
        public string Parent_ID { get; set; }
        public string[] Artist { get; set; }
        public string[] Sources { get; set; }
    }

    public class Creation
    {
        public string JSON_Class { get; set; }
        public int S { get; set; }
        public int N { get; set; }
    }
}