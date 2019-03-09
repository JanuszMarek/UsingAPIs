# Using APIs
> This project were created to learn to use third-part APIs in ASP.NET Core.

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Features](#features)
* [Solved problems](#solved-problems)
* [Setup](#setup)
* [Status](#status)
* [Contact](#contact)

## General info
Project use three third-part APIs like PokéAPI, GIPHY API and YouTube Data API. 
<br>PokéAPI is a RESTful Pokémon API. This API deliver information on Pokémon, their moves, abilities, types, egg groups and much, much more.
<br>GIPHY's GIF library is the largest library of GIFs from across the entire internet.
<br>Thanks to YouTube Data API developers can add YouTube functionality to their sites. 
<br><br>
GIPHY and YouTube sections in my web site provides search bar for search a content from APIs e.g. user can search for "funny cats" and he will get search results of GIFs with cats (in GIPHY section) and videos with cats (in YouTube section) which are linked to YouTube page with this videos.
<br>Pokemon section contain list of all pokemons and details page of Pokemon with data from API.
In the future I want to add 4th API for Google Calendar with reading events of current day and possibility to add new events.

## Technologies
* ASP.NET Core - 2.1.1
* EntityFramework - version 6.2.0
* JQuery - version 3.3.1
* Boostrap - version 3.3.7

## Features
Done:
- GIPHY - searching for user phrase using API
- YouTube - searching for user phrase using API
- Pokemon - list with Pokemons using API, detail view of Pokemon with his skills, moves, evolution chain, etc.
- pagination in each section

To do:
- add new API - Google Calendar with reading events of current day and possibility to add new events.

## Solved problems
Getting data from PokemonAPI - my first concept was to get data from API for every request but I found this to be inefficient. I created then repository with Singleton object. In constructor I was getting data of all Pokemon (807 at this moment), it caused very long response time on first request. My final solution is checking if requested Pokemon data already exist in repository. If not data is getting from API and added to repository.

## Setup
For proper application work You have to insert __api_keys.json__ file to root folder with your API keys.
<br>
Structure of file:
```
{ "APIKeys": { "GIPHY": "{Your API Key}", "YouTube": "{Your API Key}" } }
```

## Status
Project is _in progres_.

## Contact
Created by [Janusz Marek](https://https://www.linkedin.com/in/janusz-marek/) - feel free to contact me!
