OMDB-Database-Retrieval
=======================

A movie search created in ASP.NET using C#, JSON.NET, and jQuery Flipster

Overview
--------
An preliminary ASP.NET application that uses the [OMDb API] (http://www.omdbapi.com/) to search for a variety of movies from IMDB.

Features
--------
Currently you are able to search for a movie and find the top 7 hits associated with it. The results show up in a "cover-flow" like
context with the poster images representing the movies. On click, the movie information is shown.

Known Issues
------------
When fewer than 7 items are found from the OMDb database, if the service is on initial search, it does not work. If it is not on initial search, then the first few images are replaced by the new search, but the rest remain on the previous search.


