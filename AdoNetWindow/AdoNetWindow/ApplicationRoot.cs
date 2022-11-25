﻿using AppConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWindow
{
    public partial class ApplicationRoot : Form
    {
        protected ConfigurationMgr instance;
        public ApplicationRoot()
        {
            InitializeComponent();
            instance = ConfigurationMgr.Instance();
        }
    }
}
