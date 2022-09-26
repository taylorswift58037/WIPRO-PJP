select title 
from titles 
where advance > any
   (select advance 
    from publishers, titles 
    where titles.pub_id = publishers.pub_id 
	AND pub_name='Algodata Infosystems'
    )