# Introduction 
This is a basic Web API created using ASP.net. You can perform a get request to get a random anime. Also you can add your own anime to the repository. Only thing required are the name of the anime and its genre.
I have also implemented simple swagger UI. I used AWS RDS for database. I used MS-SQL server as the database.

## Post Request JSON
{
  "animeName": "string",
  "genre": [
    0
  ]
}

animeName is the name of the anime.

genre gives the list of genre

The number represents the genre
0-> Action
1-> Romance
2-> Comedy
3-> SOL
4-> Mystery

## Future Work 
Might make the getting anime request more complex using some recommendation algorithm in the future.

