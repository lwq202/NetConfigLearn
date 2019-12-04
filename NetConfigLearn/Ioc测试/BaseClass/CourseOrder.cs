namespace AOPLearn.BaseClass
{
    /// <summary>
    /// 课程订单实体类
    /// </summary>
    public class CourseOrder
    {
        public int OrderId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CoursePrice { get; set; }
        public int SchoolId { get; set; }//机构ID
    }
}
