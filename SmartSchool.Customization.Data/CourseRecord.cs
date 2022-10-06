using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchool.Customization.Data
{
    /// <summary>
    /// �ҵ{����
    /// </summary>
    public interface CourseRecord
    {

        /// <summary>
        /// �t�νs��
        /// </summary>
        int CourseID
        {
            get;
        }

        /// <summary>
        /// �ҵ{�W��
        /// </summary>
        string CourseName
        {
            get;
        }

        /// <summary>
        /// ���
        /// </summary>
        string Domain
        {
            get;
        }

        /// <summary>
        /// ���
        /// </summary>
        string Subject
        {
            get;
        }

        /// <summary>
        /// ��دŧO
        /// </summary>
        string SubjectLevel
        {
            get;
        }

        /// <summary>
        /// �Ǧ~��
        /// </summary>
        int SchoolYear
        {
            get;
        }

        /// <summary>
        /// �Ǵ�
        /// </summary>
        int Semester
        {
            get;
        }

        /// <summary>
        /// �Ǥ���
        /// </summary>
        [Obsolete("�w�L��,�Ч��CourseRecord_New,�Ǥ��ƫ��A�w�אּdecimal")]
        int Credit
        {
            get;
        }

        /// <summary>
        /// �������O
        /// </summary>
        string Entry
        {
            get;
        }

        /// <summary>
        /// ���p�Ǥ�
        /// </summary>
        bool NotIncludedInCredit
        {
            get;
        }

        /// <summary>
        /// ���ݵ��q
        /// </summary>
        bool NotIncludedInCalc
        {
            get;
        }

        /// <summary>
        /// �ҵ{���O
        /// </summary>
        CategoryCollection CourseCategorys
        {
            get;
        }

        /// <summary>
        /// �׽Ҿǥ͸��(�������I�sFillStudentAttend)
        /// </summary>
        List<StudentAttendCourseRecord> StudentAttendList
        {
            get;
        }

        /// <summary>
        /// ��L������(�ݥ��I�sFillField��J�ݭn�����)
        /// </summary>
        System.Collections.Generic.Dictionary<string, object> Fields
        {
            get;
        }

        /// <summary>
        /// �׽Ҿǥͦ��Z(�������I�sFillExamScore)
        /// </summary>
        System.Collections.Generic.List<SmartSchool.Customization.Data.ExamScoreInfo> ExamScoreList
        {
            get;
        }

        /// <summary>
        /// �ճ��q
        /// </summary>
        string RequiredBy
        {
            get;
        }

        /// <summary>
        /// �����
        /// </summary>
        bool Required
        {
            get;
        }

        /// <summary>
        /// �ҸղM��(�������I�sFillExam)
        /// </summary>
        List<string> ExamList
        {
            get;
        }
    }
}
