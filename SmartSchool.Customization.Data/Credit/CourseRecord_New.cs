using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchool.Customization.Data
{
     /// <summary>
     /// 課程紀錄(New)
     /// </summary>
     public interface CourseRecord_New : CourseRecord
     {
          /// <summary>
          /// 學分數
          /// </summary>
          decimal CreditDec
          {
               get;
          }
     }
}
