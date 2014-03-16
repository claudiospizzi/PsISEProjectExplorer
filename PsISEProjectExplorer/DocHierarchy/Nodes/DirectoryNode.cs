﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExplorer.DocHierarchy.Nodes
{
    public class DirectoryNode : FileSystemNode
    {
        public override int OrderValue { get { return -1; } }

        public DirectoryNode(string path, string name, INode parent)
            : base(path, name, parent)
        {
        }
    }
}