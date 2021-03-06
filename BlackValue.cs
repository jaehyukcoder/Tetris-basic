﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static class BlackValue 
    {
        static public readonly int[,,,] bvals = new int[7, 4, 4, 4]
        {
            {
            #region 벽돌 1
                {
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {1,1,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {1,1,1,1 },
                    {0,0,0,0 }
                }
            },
            #endregion 벽돌 1
            #region 벽돌 2
            {
              {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                }
             },
            #endregion 벽돌 2
            #region 벽돌 3
            {
              {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,1 },
                    {0,1,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,1 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,1,1,1 },
                    {0,1,0,0 }
                }
             },
            #endregion 벽돌 3
            #region 벽돌 4
            {
              {
                    {0,0,0,0 },
                    {0,0,1,1 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,1,1,1 },
                    {0,0,0,1 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,1,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,0,0 },
                    {0,1,1,1 },
                    {0,0,0,0 }
                }
             },
            #endregion 벽돌 4
            #region 벽돌 5
            {
              {
                    {0,0,1,0 },
                    {0,0,1,1 },
                    {0,0,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,1 },
                    {0,0,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,1,0 },
                    {0,1,1,0 },
                    {0,0,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,1,0 },
                    {0,1,1,1 },
                    {0,0,0,0 },
                    {0,0,0,0 }
                }
             },
            #endregion 벽돌 5
            #region 벽돌 6
            {
              {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,1 },
                    {0,0,1,1 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,1 },
                    {0,0,1,1 },
                    {0,0,1,0 }
                }
             },
            #endregion 벽돌 6
            #region 벽돌 7
            {
              {
                    {0,0,0,0 },
                    {0,0,1,1 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,1 },
                    {0,0,1,1 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,1 },
                    {0,0,0,0 }
                }
             }
            #endregion 벽돌 7
        };
    }
}
