select title,pub_name from titles 
JOIN publishers
ON titles.pub_id = publishers.pub_id

where title = 'Net Etiquette' 