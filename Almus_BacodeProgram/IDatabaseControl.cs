using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeSqliteLib;

namespace Almus_BacodeProgram
{
    interface IDatabaseControl
    {
        //DataSet GetTestResult();
        //void SetTestResult();

        BarcodeTestResultInfo GetTestResult();
        void SetTestResult(BarcodeTestResultInfo info);
    }
}
