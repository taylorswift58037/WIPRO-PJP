select title,price from titles
JOIN publishers
ON titles.pub_id = publishers.pub_id 
where title LIKE 'B%'