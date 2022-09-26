select title ,qty , pub_name from titles 
join publishers
on publishers.pub_id = titles.pub_id
join sales
on titles.title_id=sales.title_id
where pub_name = 'New Moon Books'

