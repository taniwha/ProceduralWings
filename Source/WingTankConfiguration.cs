﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pWings
{
    public class WingTankConfiguration : IConfigNode
    {
        public Dictionary<string, WingTankResource> resources = new Dictionary<string, WingTankResource>();

        public WingTankConfiguration(ConfigNode node)
        {
            Load(node);
        }

        public void Load(ConfigNode node)
        {
            ConfigNode[] nodes = node.GetNodes("Resource");
            for (int i = 0; i < nodes.Length; ++i)
            {
                WingTankResource res = new WingTankResource(nodes[i]);
                resources.Add(res.resource.name, res);
            }
        }

        public void Save(ConfigNode node) { }
    }
}