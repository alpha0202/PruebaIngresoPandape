﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.OutputPort.SalidaCandidatos
{
    public interface IDeleteCandidateOutputPort
    {
        public void Handler(int id);
    }
}
