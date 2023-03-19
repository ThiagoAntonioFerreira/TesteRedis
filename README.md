
# Create an example using Redis

I'm using Redis to maintain i have some informations. I've created this app to test the redis functionalities.

Now, I'm working in a project that manipulate a huge of informations, but some informations don't change during a period of time.
So, I've created a structure to maintain this information in chace for a period of time.

You can use my example .

First of all, open your visual studio or vscode. I'm using visual studio comunity 2002.

File ->  new -> project - Console App.

Before start the code, you should download redis from the link https://redis.io/download/. I'm using docker, so I've created a container with redis like this:

![image](https://user-images.githubusercontent.com/2035948/220613418-fe8e88a2-3e90-4939-8e14-c9a6f2717663.png)


Now that i have redis installed let's go to the code

You can install Redis in your VS by typing:
PM> Install-Package StackExchange.Redis

In this line I will connect to redis.

//address and port </br>
ConnectionMultiplexer conn = ConnectionMultiplexer.Connect("localhost:6379");

//Obtain an interactive connection to a database inside redis.<br>
IDatabase database = conn.GetDatabase();

//now I'm creating a register inside the redis database <br>
database.StringSet("redisKey", "redisvalue");
