using System;
namespace SmartSchool.Customization.Data.StudentExtension
{
    /// <summary>
    /// 學生學期科目成績資訊(New)
    /// </summary>
    public interface SemesterSubjectScoreInfo_New : SemesterSubjectScoreInfo
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