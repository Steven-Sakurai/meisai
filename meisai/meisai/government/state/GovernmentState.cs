﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meisai.government.state
{
    class GovernmentState
    {
        //个人拥有的资产总和
        public int allMoney = 0;
        //政府所拥有的资产
        public int govMoney = 0;
        public int GDP;
        public double GDPvarience;//国内生产总值和方差
        public int GDH;
        public double GDHvarience;//国内幸福总值和方差


    }
}
