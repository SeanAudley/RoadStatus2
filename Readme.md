﻿# TfL Coding Challenge
#
﻿Welcome to the **TfL Road Status** console application 
This is a simple command line client which checks the status of a major road. 
#
#### **1. How to Use**
To use, simply call from PowerShell RouteStatus passing the road as a parameter. 

For example:
.\RoadStatus.exe "A1"

If the road is valid, then the road status, and road status description is given. Otherwise, a descriptive error message is displayed.

To check the exit code of the program from the prompt, please enter $lastexitcode
#

#### **2. How to Configure & Build**
Simply locate the app.config file in both the RoadStatus and RoadStatusTdd folders and enter your TfL API credentials app-key and app-id.

#
#### **3. How to run the Tests**
In Visual Studio simply go to the menu bar and click the Test Menu,, select "Run" and "All Tests", alternatively press CTRL+R followed by A. If you have "Test Explorer pinned to Visual Studio you will see that RoadStatus has (5 tests) and it will Display "Passed Tests (5)" along with the test names underneath and whether they  passed or not.
#
#### **Any assumptions that was made and a brief to the design**
For this solution I followed the challenge to the brief. I used RestSharp, NewtonSoft.JSON and ConfigurationManager. These did the majority of the donkey work and in total the whole solution took roughly 20-25minutes to complete as to there is a really good tool that helps build the classes for the JSON responses called QuickType Json2CSharp (https://app.quicktype.io/#l=cs&r=json2csharp), this was really useful as it allows me to create a DTO/Class pattern for both a valid and invalid response from the TfL API and return whats according.
#

# ** Addendum 24/02/19 15:03**
- As I was driving to Pets at Home earlier it occurred to me that in my haste for Bound and Envelope properties they are indeed both collections and should have been coded as a List<Bound> which Bound would consist of say X,Y. The same would also apply to Envelope.
- An honest mistake!
- Also in hindsight for consistency of other projects I would of used a Factory design pattern if the API was doing more to demonstrate this. Once again sorry!
- Another example similar cand be looked at https://github.com/SeanAudley/AzureTDD

#
# Hope you Enjoy!





