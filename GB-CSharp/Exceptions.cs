using System;
using System.Collections.Generic;
using System.Text;

namespace GB_CSharp
{
    [Serializable]
    class MyArraySizeException : Exception { }

    [Serializable]
    class MyArrayDataException : Exception
    {
        public int IdRow { get; set; }
        public int IdColumn { get; set; }
        public MyArrayDataException(int idrow, int idcolumn)
        {
            IdRow = idrow;
            IdColumn = idcolumn;
        }
    }
}
