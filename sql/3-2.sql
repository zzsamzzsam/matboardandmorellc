select * from Class 
where Class.Capacity > 
(
	select count(Enrollment.ClassID) from Enrollment
	where Enrollment.ClassID = Class.ClassID
);