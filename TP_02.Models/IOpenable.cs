﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TP_02.Models
{
    public interface IOpenable : IClosable
    {
        void Show();
    }
}