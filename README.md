# SourceStats running on .NET Core 2.0
This project is supposed to be the next major version for the CustomPlayerStats, which was created for Left4Dead games. This version is generic and not bound to Left4Dead games (I don't know if it is doable, but we'll see?). The old version required some knowledge on MySQL server, PHP and configurations on systems. In this version there is no need for installing own PHP web site and MySQL. It will only require the installation of game server SourceMod plugin installation and the stats web service API installation is optional. I will provide a "global" statistics API for free to every game server owner to use, once I get this up and running.

# Global statistics?
It means all stats are collected to one huge database. However, I plan to give an option in the web application for players to filter stats based on a server. There will be a filter for every game and the different types will never mix (players Left4Dead statistics won't ever mix with CS:GO etc).

# Stats hacking?
Yes I'm sure there can be that, since the API is open for everyone to use. There will be a server identity token, which a game server owner generates using the web application and by using a valid token they can store data to the database. The stats will be moderated and if a misconduct is identified it will be easy to clear all data identified by the server identity token. I will probably mark all new server identity tokens as "not trusted" by default. Once there is enough data from a new server it can be granted global stats validity, or something similar?

# When is it ready?
I really don't know. Never maybe? Maybe in a few weeks? It really depends how much time I can spend sitting by my computer at home. I have a daytime job, two kids and other hobbies that I really want to spend time on too.

# Roadmap
1. Get the API as ready as possible (includes the database work) - Not that much work
2. Modify the existing SourceMod plugin to work with the API - Can be tough to crack and requires a lot of work
3. Create the web application to display the stats - Requires a lot of work (not sure how I will start with this)
4. Create game server control panel for the web application - Requires some work
5. Fix all big bugs and the smaller or cosmetic bugs as much as possible - Will probably continue for ever?
