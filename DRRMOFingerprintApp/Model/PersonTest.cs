﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRRMOFingerprintApp.Model
{
    public class PersonTest
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public byte[] Fingerprint { get; set; }
    }
}
