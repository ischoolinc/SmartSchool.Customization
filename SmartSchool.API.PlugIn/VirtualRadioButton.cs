﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchool.API.PlugIn
{
    public class VirtualRadioButton:VirtualCheckItem
    {
        public VirtualRadioButton() { }
        public VirtualRadioButton(string text)
        {
            this.Text = text;
        }
        public VirtualRadioButton(string text, bool check)
            : this(text)
        {
            this.Checked = check;
        }
    }
}
