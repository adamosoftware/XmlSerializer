﻿using AdamOneilSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class SampleDoc : Document
    {
        public SampleDoc()
        {
            FilenamePrompt = delegate (out string fileName)
            {
                fileName = @"C:\Users\Adam\Desktop\hello.xml";
                return true;
            };
        }

        public string FirstName { get { return Get<string>(); }  set { Set(value); } }

        public string LastName {  get { return Get<string>(); } set { Set(value); } }

        public DateTime BirthDate {  get { return Get<DateTime>(); } set { Set(value); } }
    }
}
