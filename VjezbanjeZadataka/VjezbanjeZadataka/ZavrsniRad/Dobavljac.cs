﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeZadataka.ZavrsniRad
{
    public class Dobavljac : Entitet
    {
        public string  Naziv { get; set; }
        public string Adresa { get; set; }
        public string Iban { get; set; }
    }
}
