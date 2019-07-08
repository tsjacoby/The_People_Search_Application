Instructions for testing The People Search Application:
1) If not already installed, please install Microsoft SQL Server Express so that a SQL server is running compatible with the following connection string "Server=localhost\\SQLEXPRESS;Database=peoplesearch;Trusted_Connection=True;". Alternatively, the connection string can be modified in the application to match a different SQL server.
2) If not already installed, please install Microsoft Visual Studio 2019. This is necessary in order to build and launch the server side of the application.
3) If not already installed, please install Google Chrome. This is not strictly necessary, but is the easiest path. Alternatively, you may use another browser, but must add a security exception for the certificate from "https://localhost:5001/" so that the call from the client to the server works as expected.
4) Open ".\Server\The_People_Search_Application\The_People_Search_Application.sln" with Microsoft Visual Studio 2019.
5) Run THE_PEOPLE_SEARCH_APPLICATION. This will open a browser tab and complete a search without any client side functionality. Please leave this new tab open so that the server continues to run.
6) Open ".\Client\index.html" with Google Chrome (or another browser if you have added the necessary security exception).
7) Perform searches on the page and view results. The DB is seeded with a handful of people with the following information:
	{ Name = "Billy", Address = "1 Foo Rd, Bellingham, WA", Age = 45, Interests = "Billy enjoys running and eating.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-1.png" },
	{ Name = "Bob", Address = "2 Foo Rd, Bellingham, WA", Age = 2, Interests = "Bob enjoys sleeping, crying, and eating.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-2.png" },
	{ Name = "Bob", Address = "8 Bar Ln, Seattle, WA", Age = 35, Interests = "Bob enjoys entertaining.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-3.png" },
	{ Name = "Bobby", Address = "14 Fir Rd, Bellingham, WA", Age = 24, Interests = "Bobby enjoys sleeping.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-4.png" },
	{ Name = "Jen", Address = "18 Baz St, Seattle, WA", Age = 62, Interests = "Jen enjoys jumping.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-5.png" },
	{ Name = "Jan", Address = "3 Foo Rd, Bellingham, WA", Age = 89, Interests = "Jan enjoys reading.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-6.png" },
	{ Name = "Fred", Address = "9 Foo Rd, Bellingham, WA", Age = 71, Interests = "Fred enjoys gardening.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-7.png" },
	{ Name = "Erin", Address = "4 Foo Rd, Bellingham, WA", Age = 32, Interests = "Erin enjoys sleeping and jumping around.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-8.png" }
