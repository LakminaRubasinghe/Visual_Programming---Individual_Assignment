using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopApplication
{
    internal class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsWall { get; set; }
        public bool IsStart { get; set; }
        public bool IsEnd { get; set; }
        public bool IsVisited { get; set; }
        public bool IsPath { get; set; }
        public Node Parent { get; set; }

        public Node(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
