using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBoard
{
    internal class Board
    {
        public float length;
        public float width;
        public float height;
        public int edgeWidth;
        public bool edgeWidth1;
        public bool edgeWidth2;
        public int edgeLength;
        public bool edgeLength1;
        public bool edgeLength2;
        public int edgebandWaste = 60;
        public float edgebandCost = 0.002F;
        public Board(float aLength, float aWidth, float aHeight, int aEdgeWidth, int aEdgeLength)
        {
            length = aLength;
            width = aWidth; height = aHeight;
            switch (aEdgeWidth)
            {
                case 0: edgeWidth1 = false; edgeWidth2 = false; edgeWidth = 0; break;
                case 1: edgeWidth1 = true; edgeWidth2 = false; edgeWidth = 1; break;
                case 2: edgeWidth1 = true; edgeWidth2 = true; edgeWidth = 2; break;
                default: edgeWidth1 = false; edgeWidth2 = false; edgeWidth = 0; break;
            }
            switch (aEdgeLength)
            {
                case 0: edgeLength1 = false; edgeLength2 = false; edgeLength = 0; break;
                case 1: edgeLength1 = true; edgeLength2 = false; edgeLength = 1; break;
                case 2: edgeLength1 = true; edgeLength2 = true; edgeLength = 2; break;
                default: edgeLength1 = false; edgeLength2 = false; edgeLength = 0; break;
            }
        }
        public bool TooBig()
        {
            if (height > 3000 || width > 3000) return true;
            else return false;
        }
        public float CostOfEdgeband()
        {
            return (edgeLength * (length + edgebandWaste) + edgeWidth * (width + edgebandWaste)) * edgebandCost;
        }
    }
}
