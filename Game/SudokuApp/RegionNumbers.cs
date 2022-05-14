using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMatrix
{
    public class RegionNumbers
    {
        private List<int> P0_0, P0_1, P0_2, P1_0, P1_1, P1_2, P2_0, P2_1, P2_2;
        private string RegionName;
        private int Value;
        public RegionNumbers()
        {
            P0_0= new List<int>(9);
            P0_1 = new List<int>(9);
            P0_2 = new List<int>(9);

            P1_0 = new List<int>(9);
            P1_1 = new List<int>(9);
            P1_2 = new List<int>(9);

            P2_0 = new List<int>(9);
            P2_1 = new List<int>(9);
            P2_2 = new List<int>(9);
        }
        public void AddRegionNumberList(string RegionName, int Value)
        {
            List<int> returnList = new List<int>();
            switch (RegionName)
            {
                case "P0_0":
                    P0_0.Add(Value);
                    break;
                case "P0_1":
                    P0_1.Add(Value);
                    break;
                case "P0_2":
                    P0_2.Add(Value);
                    break;
                case "P1_0":
                    P1_0.Add(Value);
                    break;
                case "P1_1":
                    P1_1.Add(Value);
                    break;
                case "P1_2":
                    P1_2.Add(Value);
                    break;
                case "P2_0":
                    P2_0.Add(Value);
                    break;
                case "P2_1":
                    P2_1.Add(Value);
                    break;
                case "P2_2":
                    P2_2.Add(Value);
                    break;
            }
        }
        public List<int> GetRegionNumberList(string RegionName)
        {
            List<int> returnList = new List<int>();
            switch (RegionName)
            {
                case "P0_0":
                    returnList = P0_0;
                    break;
                case "P0_1":
                    returnList = P0_1;
                    break;
                case "P0_2":
                    returnList = P0_2;
                    break;
                case "P1_0":
                    returnList = P1_0;
                    break;
                case "P1_1":
                    returnList = P1_1;
                    break;
                case "P1_2":
                    returnList = P1_2;
                    break;
                case "P2_0":
                    returnList = P2_0;
                    break;
                case "P2_1":
                    returnList = P2_1;
                    break;
                case "P2_2":
                    returnList = P2_2;
                    break;
            }
            return returnList;
        } 
    }
}
