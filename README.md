# Requirements Specification

## Evaluating the computing and business needs of Rodgers Reminders

### The services the organisation provides
The Rodgers Reminders IOS application is being created to fill a gap in the market for a decent reminders, application. Many applications do some features and then other applications do others. This app is going to encompass them all within one application. Below is a basic list of some of the features that this IOS Application will include.

Key = (Tick = Easy feature to implement, No Tick = Hard feature to implement)
- [ ] Login System (Username/Password, Social login, Active directory login (Enterprise use))
- [x] Reminders (Goal based, time based)
- [x] Calander events
- [X] Alerts via notification and email
- [X] Native application (not web based)

### The Aims and goals of the organisation
The aim of the organisation is to create a final solution for reminder applications, hopefully, this application will include every feature that users need. The application will include a feature request form that will allow users to request features that they require.

### The customer's needs, expectations and how the app will be delivered
The customer requires a very well built IOS application that gives the ability for reminders to be created however a user wants and to be able to notify the user if so required. The app will be delivered using a continuous integration system that will allow updates to be pushed automatically to the end user every week. This will allow the client to not need to worry about updates as it will be handled by the CI system.

### The staff's needs, working styles and patterns
The staff's needs will be somewhere pleasant to work, whether that be in an office or in their own home and work remotely, which is becoming a big trend in software development. Staff will also need to be in teams so they don't feel like all of the work is on them and they also need colleagues they can go to for advice on issues they are having. Staff should also be able to use flexi-hours which will allow them, within reason, to work when they want to work, rather than being forced into set schedules.

## Evaluating the factors affecting the success and failure of the new IOS application in regards to the following

### The risk associated with completion of tasks on time and within budget
Creating an application comes with many risks, the main issue is budget. Most applications fail because the company behind them or the client asking for the application runs out of money to keep the development going. This can be mitigated against by conducting a thorough requirements specification and analysing every feature to ensure that the budget encompasses it and that there is enough time for that feature to be completed.

### Costs and time constraints
*Did I not just cover that above?*
*Talk about different teams falling behind causing other teams to fall behind due to other work not being completed*

### Staff skills and the maintenance of the IOS application
The staff will all require different skills depending on which team they are in. Analysts will need to be analytic, designers will need to be good at designing and programmers will need skills in Swift and or other programming languages associated with IOS development.

### Change of management and user involvement in the development process
Allowing the user to be involved within the development process can be a virtue and a disaster. Its good because it menas and problems can be corrected before release due to the customer haveing a complete oversight. However it means the customer could start to ask for too much and cause the development teem to fall behind making alterations here and there. The same problem could occur if the management team of the client changes and want different styles or functions.

I have had a personal experaince with this issue when working with a client. At first it was a few changes, but then it became changing almost everything upon every update which slowed development down to almost a hault. 

## Requirements specification regarding the IOS app

### The scope and boundaries of the proposed IOS application
There may be one major boundary that needs to be addressed before development begins and that is how the app will remain stable when many users are using it at once. A suden influx of users could crash the servers if a solution is not put in place to protect against this. One fix is to go down a route that supports containers. This way a limit can be set so that one container can support lets say 50 users. Once 45 users connect another container is started in preperation for the new users. This solution would also have another server managing incomming connections and redirecting them to the container with the least amount of users to ensure that all containers are kept at an even level.

The scope of this applications is quite limited, as this is only a reminders application. It is not meant to be a one app solution for everything on someones phone. That being said however, it can still include a lot of features that have mostly already been said. It will have an advanced login system which will contain social logins as well as support for organisations using LAPD/Active Directory. Authorised organisations will be able to request to have their LDAP server added into our system so employees/students can login through their standard login credentials they know. Reminders can be as invasive as the user wants as well. Due to the users allowing email/push notifications, alarms and other modes of comunication it ensures that the user gets the final say on how the reminder is handled.

### The inputs, outputs and processes of the proposed system
Inputs | Outputs | Processes
------------ | ------------- | -------------
Login details|account details sent to client|Hashing password
New feature requests|Reminders sent to client|Sending emails
New reminders|App notifications|Sending app notifications
.|Email notifications|Adding a new reminder
.|.|Removing reminder
.|.|Checking if a notification needs to be sent
.|.|Email verification
.|.|Password reset

### The timescales and milestones
Timescales and milestones can be setup within this github repository which will add a date to an issue informing everyone that it needs to be resolved by X date. Github can also setup milestones where you have a checklist of things that needs to be done before the milestone is complte and it will also show you how long you have until the milestone should be complete. Below is an example milestone that I could create. It shows you % complte, issues causing the milestone not to be complete, and how long each issue has left to be complted.

![Example milestone](https://help.github.com/assets/images/help/issues/milestone-info-page.png)
### The risks and constraints
There are risks when developing an application. THe biggest risk is there not being enough funding to sustane development. THis can be mitigated against by planning out the development so that each feature has a budget and timescale. Some constraints of application development is the fact that if one team falls behind on their work, it will cause other teams relying on that work to also fall behind. This costs time and a lot of money.

### Recomendations for furure action
?

## Emailing to request a meeting to discuss the quality of the proposed IOS application and the suitability of the original requirements.
![Email to Rodgers Reminders](https://image.ibb.co/kBSYhR/Capture.png)

## Discussing how we are going to carry out document analysis and the protocols that will be used for carrying out the investigation.
Document analysis is the process of using pre-defined protocols ad methods to analyse a document and extract useful data from it. It allows researchers to look at pre-existing documents, online or physical to determain certain factors. For Rodgers Reminders a document analysis can be conduced on reviews of popular reminder applications which will allow us to extract the good and bad parts of current reminder applications in hopes to make the application better.

## Creating a questionnaire to take to the meeting to ensure that all information that is required, is gathered.
I have created a form which will be printed off and brought with me to the meeting to ensure that the requirements specification is just how the customer (Rodgers Reminders) wants it.
![Google Form](https://goo.gl/forms/fLs7G42uaT2O680n1)
## Keeping a record of all correspondence and meetings and update the requirements specification in light of the discussions

## Evaluating my requirements specifications to show how it fulfils the requirements for the IOS application.

# Designing the IOS application

## Producing a detailed design documentation  showing

### Input and output requirements

#### Screen layouts for mobile devices and alternative layout for desktop pc

#### Data entry forms, including layout and structure, proposed fields and data entry methods

#### Report forms

#### Hardware and software requirements

### Data Requirements

#### Data flow diagrams

#### Data dictionaries identifying entities and validation

#### Decision tables and activity diagrams

## Producing a plan for testing, maintaining and updating the IOS application

### Testing methods to be used

### Test data boundaries in relation to normal, abnormal and extreme data

### Identify the test users

### Proposed test schedule

### Proposed maintenance and update schedule

## Evaluating the design against the organisation's requirements

## Evaluating your skills, knowledge and behaviour

### My Time management and planning

### How I used feedback from my manager

### Investigation techniques used for the interview

### How I managed the system expectations

### My behaviour and the impact on the outcomes of the system, to include professionalism, etiquette, supportive of others, timely and appropriate leadership and accountability

### Evaluating my recommendations and decisions 
