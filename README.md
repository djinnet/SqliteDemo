# SqliteDemo
This is used as an demo for showing how to use sqlite for .net 5 solution with webapi and blazor. This is intended to showcase my skills on basic setup.

==WebApi==
This is an .net 5 webapi or known as backend. This is the only place where dept web api comes from. 
People can use different api to apply within the controller, but for this case I am just using entity framework core to do talking with sqlite.

==WebApp==
This is blazor in .net 5. This is the UI or the frontend of the website. This is also an PWA, so it can be used for mobile devices or desktop offline installation.

==Library==
Both project shared the same library. Why? Because the library contains models and DAL (data access layer). Webapp only need to know models and WebAPI need to know models and DAL.
To make it easier for maintaining, that is the primary reason to why both are shared the same library.

Remember this project do not always reflected my skills, since this is meant for an basic setup and not advanced setup. 
But it do show how I will approach an challenge and how I will do my setup.
The whole setup took me 1 hour (plus 20-30 mins debugging). I think I could do less time, so I could speedrun the basic setup if I want to. 
