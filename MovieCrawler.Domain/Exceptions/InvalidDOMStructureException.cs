﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCrawler.Domain
{
    public class InvalidDOMStructureException : Exception
    {
        public InvalidDOMStructureException(string message)
            : base(message)
        {
        }
    }
}