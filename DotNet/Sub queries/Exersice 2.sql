select title from titles
where price >any
(select price from titles
where titles.price = titles.price
AND type != 'Business')