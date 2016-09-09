/* sort by last name THEN limit to 50 */
select * from Student 
order by Student.LastName desc 
limit 50;


/* limit to 50 THEN sort by last name */
select * from
(
	select * from Student limit 0, 50
) temp
order by temp.LastName desc;
