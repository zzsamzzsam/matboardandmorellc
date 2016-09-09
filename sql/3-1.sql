select Student.FirstName, Student.LastName, temp.Description from Student 
left join 
(
	select Enrollment.StudentID, Class.Description from Enrollment
	join Class 
	on Enrollment.ClassID = Class.ClassID
) temp
on Student.StudentID = temp.StudentID
where Student.StudentID = 1234;