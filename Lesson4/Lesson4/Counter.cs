﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Counter
    {
        public delegate void Messager();
        public event Messager Catch;
        public void Count()
        {
            for (int i=0;i<101;i++)
            {
                if (i==42)
                {
                    Catch?.Invoke();
                }
            }
        }
        
    }
}
