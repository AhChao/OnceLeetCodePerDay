using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/course-schedule-iii/
    public class L630CourseScheduleIIITests
    {
        private L630CourseScheduleIII _l630CourseScheduleIii;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l630CourseScheduleIii = new L630CourseScheduleIII();
            MaxCanTakeCourseCountFromCourses(3, new int[][]
                                                {
                                                    new[] {100, 200}, new[] {200, 1300},
                                                    new[] {1000, 1250}, new[] {2000, 3200}
                                                });
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l630CourseScheduleIii = new L630CourseScheduleIII();
            MaxCanTakeCourseCountFromCourses(1, new int[][]
                                                {
                                                    new[] {1, 2}
                                                });
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _l630CourseScheduleIii = new L630CourseScheduleIII();
            MaxCanTakeCourseCountFromCourses(0, new int[][]
                                                {
                                                    new[] {3, 2},
                                                    new[] {4, 3}
                                                });
        }

        [Test]
        public void Example4_Should_Return_As_Expected()
        {
            _l630CourseScheduleIii = new L630CourseScheduleIII();
            MaxCanTakeCourseCountFromCourses(2, new int[][]
                                                {
                                                    new[] {5, 5},
                                                    new[] {4, 6},
                                                    new[] {2, 6}
                                                });
        }

        private void MaxCanTakeCourseCountFromCourses(int expected, int[][] courses)
        {
            Assert.AreEqual(expected,
                            _l630CourseScheduleIii.ScheduleCourse(courses));
        }
    }
}