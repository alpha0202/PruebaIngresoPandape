﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Presenter
{
    public interface IPresenter<T>
    {
        public T Content { get; }
    }
}
