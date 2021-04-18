select * from Country
select * from State

-- CROSS JOIN
--select * from Country
--cross join State

-- inner join in old way as per SQL ANSI 89
--select * from Country as c, State as s
--where c.CountryId=s.CountryId

-- inner join as per new standard SQL ANSI 92 onwards
--select * from Country as c 
--inner join state as s
--on s.CountryId=c.CountryId

----left join
--select * from Country as c 
--left outer join state as s
--on c.CountryId=s.CountryId

--right join
--select * from Country as c 
--right outer join state as s
--on c.CountryId=s.CountryId

-- full outer join
select * from Country as c 
full outer join state as s
on c.CountryId=s.CountryId
