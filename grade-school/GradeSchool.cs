using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private string Student;
    private int StudentGrade;
    private Dictionary<string, int> StudentGradeList = new Dictionary<string, int>();
    public void Add(string student, int grade)
    {
        Student = student;
        StudentGrade = grade;
        StudentGradeList.Add(Student, StudentGrade);

    }

    public IEnumerable<string> Roster()
    {
        List<string> studentRoster = new List<string>();
        var studentGrade = from student in StudentGradeList
                           //newGroup contains selection of students that grouped by different grades:1,2,3
                           group student by student.Value into newGroup
                           //newGroup.Key is the grade
                           orderby newGroup.Key
                           select newGroup;

        //gradeGroup is each selection of the newGroup
        foreach (var gradeGroup in studentGrade)
        {
            //s:student keyValuePair(eg. "Alex", 2) s.Key: student's name
            foreach (var student in gradeGroup.OrderBy(s => s.Key) )
            {
                studentRoster.Add(student.Key.ToString());
            }
        }

        return studentRoster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        List<string> gradeNameList = new List<string>();

        var studentName = from student in StudentGradeList
                          where student.Value == grade
                          orderby student.Key
                          select student.Key;

        foreach (var Key in studentName)
        {
            gradeNameList.Add(Key);
        }

        return gradeNameList;
    }
}