﻿using RefApp.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.Contracts.Views
{
    public interface IView
    {
        IViewModel ViewModel { get; }
    }
}
