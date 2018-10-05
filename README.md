# RestApiNetCore
.Net Core RestFul Api using DI Unity
*************************************************************

Web Api build using the .Net Core and Unity as a Console application.
App ID(app_id) and App Key(app_key) managed using the Manage User Secrets.
These keys can be chnaged anytime from the secrets.json (Secrets folder).
SOC have been implemented. 
Async Task have been used.

*************************************************************
Instruction to Download this Repo.

1. Create a new folder on 'C:\' Name as "Projects" 
2. Clone/Download (zip) repo under "Projects" folder.
3. Clone/Download repo from this link (https://github.com/janatdev/ApiTest) under "Projects" folder. Hopefully it will load both projects this way.
4. Open the Tfl application (note. don't open the Tfl.sln)
5. Restore the Nugget packages.
6. Add AppId and App key in the secrets.json file under the GUID Folder.
7. Build the App
8. Run the App.

*************************************************************

Application Running Details:

1. Program.cs is the main file from here the application starts.
2. Once you run the application it will ask you to enter the Road Name.
3. Enter the Road Name such as A2 or A1 (a Valid Road Name)
4. Program will display the Road Status.
5. Program will as you to exit or do you want to continue checking the RoadStatus.
6. In case you want to check anothe Road status you need to Press first and then the program will ask you again the Road Name.
7. If the Road name is valid it will display the Road status. Otherwise will give you a message.
8. When the Road name is not valid it will display that the Road is not valid.

*************************************************************
Few TestCase is implemented too. 
*************************************************************

If anything which is not clear please contact me. 
Due to the time shortage I have done this work so far.

Hope this time it works. I have actually created the console project and test project using the dotnet commands. I am not sure if thats causing some dependency issue or what. for me its working fine. Let me know if it still doesnt work I will look to send by some other ways.
