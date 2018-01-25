﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.CFGParser.DataHolder
{
    public interface IGroundData : ISentenceData
    {
        float Metallic();
        float Smoothness();
    }
}