# Rogers Reminders Unit 22

# Table of contents
<!-- toc -->

- [Requirements Specification](#requirements-specification)
  * [Evaluating the computing and business needs of Rogers Reminders](#evaluating-the-computing-and-business-needs-of-rogers-reminders)
    + [The services the organisation provides](#the-services-the-organisation-provides)
    + [The Aims and goals of the organisation](#the-aims-and-goals-of-the-organisation)
    + [The customer's needs, expectations and how the app will be delivered](#the-customers-needs-expectations-and-how-the-app-will-be-delivered)
    + [The staff's needs, working styles and patterns](#the-staffs-needs-working-styles-and-patterns)
  * [Evaluating the factors affecting the success and failure of the new application in regards to the following](#evaluating-the-factors-affecting-the-success-and-failure-of-the-new-application-in-regards-to-the-following)
    + [The risk associated with completion of tasks on time and within budget](#the-risk-associated-with-completion-of-tasks-on-time-and-within-budget)
    + [Costs and time constraints](#costs-and-time-constraints)
    + [Staff skills and the maintenance of the IOS application](#staff-skills-and-the-maintenance-of-the-ios-application)
    + [Change of management and user involvement in the development process](#change-of-management-and-user-involvement-in-the-development-process)
  * [Requirements specification regarding the application](#requirements-specification-regarding-the-application)
    + [The scope and boundaries of the proposed application](#the-scope-and-boundaries-of-the-proposed-application)
    + [The inputs, outputs and processes of the proposed system](#the-inputs-outputs-and-processes-of-the-proposed-system)
    + [The timescales and milestones](#the-timescales-and-milestones)
    + [The risks and constraints](#the-risks-and-constraints)
    + [Recommendations for future action](#recommendations-for-future-action)
      - [Geofencing + Google Maps](#geofencing--google-maps)
      - [Preset reminders](#preset-reminders)
  * [Emailing to request a meeting to discuss the quality of the proposed IOS application and the suitability of the original requirements.](#emailing-to-request-a-meeting-to-discuss-the-quality-of-the-proposed-ios-application-and-the-suitability-of-the-original-requirements)
  * [Creating a questionnaire to take to the meeting to ensure that all information that is required, is gathered.](#creating-a-questionnaire-to-take-to-the-meeting-to-ensure-that-all-information-that-is-required-is-gathered)
  * [Discussing how we are going to carry out document analysis and the protocols that will be used for carrying out the investigation.](#discussing-how-we-are-going-to-carry-out-document-analysis-and-the-protocols-that-will-be-used-for-carrying-out-the-investigation)
- [Designing the IOS application](#designing-the-ios-application)
  * [Producing a detailed design documentation](#producing-a-detailed-design-documentation)
    + [Input and output requirements](#input-and-output-requirements)
      - [Screen layouts for mobile devices and alternative layout for desktop pc](#screen-layouts-for-mobile-devices-and-alternative-layout-for-desktop-pc)
      - [Hardware and software requirements](#hardware-and-software-requirements)
      - [Data Flow Diagram](#data-flow-diagram)
  * [Producing a plan for testing, maintaining and updating the desktop application](#producing-a-plan-for-testing-maintaining-and-updating-the-desktop-application)
    + [Testing methods to be used](#testing-methods-to-be-used)
    + [Test data boundaries in relation to normal, abnormal and extreme data](#test-data-boundaries-in-relation-to-normal-abnormal-and-extreme-data)
    + [Proposed test schedule](#proposed-test-schedule)
    + [Proposed maintenance and update schedule](#proposed-maintenance-and-update-schedule)
    + [My Time management and planning](#my-time-management-and-planning)
    + [How I used feedback from my manager](#how-i-used-feedback-from-my-manager)
    + [Investigation techniques used for the interview](#investigation-techniques-used-for-the-interview)
    + [How I managed the system expectations](#how-i-managed-the-system-expectations)
    + [My behaviour and the impact on the outcomes of the system, to include professionalism, etiquette, supportive of others, timely and appropriate leadership and accountability](#my-behaviour-and-the-impact-on-the-outcomes-of-the-system-to-include-professionalism-etiquette-supportive-of-others-timely-and-appropriate-leadership-and-accountability)
    + [Evaluating my recommendations and decisions](#evaluating-my-recommendations-and-decisions)

<!-- tocstop -->

# Requirements Specification

## Evaluating the computing and business needs of Rogers Reminders


4 views, original designs (DESKTOP)
4 views of alternate design
1 mobile/tablet
1 alternate design mobile/tablet


### The services the organisation provides
Rogers Reminders is looking to create an application to fill a gap in the market for a decent reminder, application. Many applications do some features and then other applications do others. This app is going to encompass them all within one application. Below is a basic list of some of the features that this IOS Application will include.

Key = (Tick = Easy feature to implement, No Tick = Hard feature to implement)
- [ ] Login System (Username/Password, Social login, Active directory login (Enterprise use))
- [ ] Local Encrypted databases to store reminders
- [x] Reminders (Goal based, time based)
- [x] Calander events
- [X] Alerts via notification and email
- [X] Native application (not web based)

### The Aims and goals of the organisation
The aim of the organisation is to create a final solution for reminder applications, hopefully, this application will include every feature that users need. The application will include a feature request form that will allow users to request features that they require. 

### The customer's needs, expectations and how the app will be delivered
The customer requires a very well built IOS application that gives the ability for reminders to be created however a user wants and to be able to notify the user if so required. The app will be delivered using a continuous integration system that will allow updates to be pushed automatically to the end user every week. This will allow the client to not need to worry about updates as it will be handled by the continuous integration system. Rogers Reminders is trying to produce an application to help those with poor time management skills and organisational skills. 

### The staff's needs, working styles and patterns
The staff's needs will be somewhere pleasant to work, whether that be in an office or in their own home and work remotely, which is becoming a big trend in software development. Staff will also need to be in teams so they don't feel like all of the work is on them and they also need colleagues they can go to for advice on issues they are having. Staff should also be able to use flexi-hours which will allow them, within reason, to work when they want to work, rather than being forced into set schedules. An ideal schedule would be a fixed amount of time every weekday to see a continuous stream of updates. However, this may not be feasible so work times are flexible.

## Evaluating the factors affecting the success and failure of the new application in regards to the following

### The risk associated with completion of tasks on time and within budget
Creating an application comes with many risks, the main issue is budget. Most applications fail because the company behind them or the client asking for the application runs out of money to keep the development going. This can be mitigated against by conducting a thorough requirements specification and analysing every feature to ensure that the budget encompasses it and that there is enough time for that feature to be completed.

### Costs and time constraints
Within application development using the waterfall method as an example, if a team fails to complete work by a deadline and the next team is waiting for that completed work, both teams will end up falling behind which will create a domino effect causing most teams to fall behind which will start to cost a lot of money very quickly. This does not exist in some other system lifecycle methodologies, however.

### Staff skills and the maintenance of the IOS application
The staff will all require different skills depending on which team they are in. Analysts will need to be analytic, designers will need to be good at designing and programmers will need skills in Swift and or other programming languages associated with IOS development.

### Change of management and user involvement in the development process
For a change of management to be smooth, policies need to be put in place to ensure that documentation of the developers work has been created before they leave to allow the new developer to be able to understand the work that they need to pick up on. The same applies to designers and management roles too; they must create ample documentation to allow new staff to easily take over their roles.

Allowing the user to be involved in the development process can be a virtue and a disaster. It's good because it means and problems can be corrected before release due to the customer having a complete oversight. However, it means the customer could start to ask for too much and cause the development team to fall behind making alterations here and there. The same problem could occur if the management team of the client changes and want different styles or functions.

I have had a personal experience with this issue when working with a client. At first, it was a few changes, but then it became changing almost everything upon every update which slowed development down to almost a halt. 

## Requirements specification regarding the application

### The scope and boundaries of the proposed application
There may be one major boundary that needs to be addressed before development begins and that is how the app will remain stable when many users are using it at once. A sudden influx of users could crash the servers if a solution is not put in place to protect against this. One fix is to go down a route that supports containers. This way a limit can be set so that one container can support let's say, 50 users. Once 45 users connect another container is started in preparation for the new users. This solution would also have another server managing incoming connections and redirecting them to the container with the least amount of users to ensure that all containers are kept at an even level.

The scope of this applications is quite limited, as this is only a reminders application. It is not meant to be a one app solution for everything on someone's phone. That being said, however, it can still include a lot of features that have mostly already been said. It will have an advanced login system which will contain social logins as well as support for organisations using LAPD/Active Directory. Authorised organisations will be able to request to have their LDAP server added into our system so employees/students can log in through the standard login credentials they know. Reminders can be as invasive as the user wants as well. Due to the users allowing email/push notifications, alarms and other modes of communication it ensures that the user gets the final say on how the reminder is handled.

### The inputs, outputs and processes of the proposed system
Inputs | Outputs | Processes
------------ | ------------- | -------------
Login details|account details sent to client|Hashing password
New feature requests|Reminders sent to client|Sending emails
New reminders|App notifications|Sending app notifications
||Email notifications|Adding a new reminder
|||Removing reminder
|||Checking if a notification needs to be sent
|||Email verification
|||Password reset

### The timescales and milestones
Timescales and milestones can be set up within this GitHub repository which will add a date to an issue informing everyone that it needs to be resolved by X date. Github can also set up milestones where you have a checklist of things that need to be done before the milestone is complete and it will also show you how long you have until the milestone should be complete. Below is an example milestone that I could create. It shows you % complete, issues causing the milestone not to be complete, and how long each issue has left to be completed.

![Example milestone](https://help.github.com/assets/images/help/issues/milestone-info-page.png)
### The risks and constraints
There are risks when developing an application. The biggest risk is there not being enough funding to sustain development. This can be mitigated against by planning out the development so that each feature has a budget and timescale. Some constraints of application development are the fact that if one team falls behind on their work, it will cause other teams relying on that work to also fall behind. This costs time and a lot of money.

### Recommendations for future action
Future actions to improve this application would include, in my professional opinion would be to implement the following:

#### Geofencing + Google Maps
The inclusion of geofencing for reminders would be the process of being able to setup a reminder for a specific location. For example, when you enter the geofence for your home you could be reminded to do the washing up. With Google maps, the maps would look good and be easily implemented. 

#### Preset reminders
These reminders would be reminders that you can set to remind you every day, every specific day, or every few hours etc. 

## Emailing to request a meeting to discuss the quality of the proposed IOS application and the suitability of the original requirements.
![Email to Rogers Reminders](https://image.ibb.co/kBSYhR/Capture.png)

## Creating a questionnaire to take to the meeting to ensure that all information that is required, is gathered.
I have created a questionnaire to create a feasibility overview to see if this project is worth the time and effort of the team and to see if the team has the equipment they require to complete the task and create the Rogers Reminders application.
[Google Form](https://goo.gl/forms/fLs7G42uaT2O680n1)

## Discussing how we are going to carry out document analysis and the protocols that will be used for carrying out the investigation.
Document analysis is the process of using predefined protocols and methods to analyse a document and extract useful data from it. It allows researchers to look at preexisting documents, online or physical to determine certain factors. For Rogers Reminders a document analysis can be conducted on reviews of popular reminder applications which will allow us to extract the good and bad parts of current reminder applications in hopes to make the application better.

# Designing the IOS application

## Producing a detailed design documentation
For this application, I have produced a variety of designs that meet the requirements of the client. I have made one design with four different layouts, and two more layouts for mobile and tablet devices. I have also designed one other design with a layout for a computer, tablet and phone device. I will evaluate these designs using the requirements specification as a guide to justify why I have made certain design choices. Even though this is a windows application, I have created mobile and tablet designs to show how the application can be adapted to other devices in the future.

### Input and output requirements
This application will require quite a few inputs and outputs to perform its actions. On a desktop computer, users will have the choice of using a local database to store their reminders or use an online server to store their database files, this will allow them to use the software on multiple devices. The main inputs and outputs for this application will use a protocol called SQL. SQL uses a query based approach so within the application I can create a query and have place data from the forms within the query to add it to the database. The main output of the application will be Windows 10 Alerts which can be found in the action centre. These alerts will let a user know when their reminders are up or if there is a deadline coming up soon.

![The Activity Centre](https://i.imgur.com/i83i2kO.png)

#### Screen layouts for mobile devices and alternative layout for desktop pc
![Main Design](https://i.imgur.com/1a35oJw.png)

This is how the main window of the application will look. This is where the user can see the current reminders, create a new reminder and filter the reminders. This design will only very slightly change for a mobile device and that change is the left column will collapse and expand with a button to save screen space on the small device

![Creating a new reminder](https://i.imgur.com/SOcUpMc.png)

This is how creating a new reminder will look. It will allow users to enter details about the reminder and define if the reminder should be time-based (with an alert) or if it should be goal based. This design won't change on mobile devices as it already has a slim design.

![Delete Reminder](https://i.imgur.com/MsLFONk.png)

This is the message box that will appear when a user selects that they want to delete a reminder. This design could be used for other yes/no style questions. The design will be expanded to fit the whole screen on a mobile device.

![Application Settings](https://i.imgur.com/XtZE7tS.png)

This is how the settings for the application will look. It shows how different inputs will be handled and how the user can enter them. It features a slim design like the creating a new reminder design to keep consistent. Again it will not change on mobile.

#### Hardware and software requirements
The hardware required for this application is a basic computer which can run the operating system Microsoft Windows 7 and above. The application relies on Windows Forms which do not require any advanced hardware requirements and run on any Windows 7 and above.

#### Data Flow Diagram
I have created a data flow diagram which will outline how the data will traverse through the application in an offline state:

![Data Flow Diagram](https://raw.githubusercontent.com/jacobgc/Rogers-Reminders/master/Designs/Data%20Flow%20Diagram.png)

## Producing a plan for testing, maintaining and updating the desktop application

### Testing methods to be used
For this application, only basic user input tests will be completed. These involve testing different data in an input box and checking the result of buttons being pressed.

### Test data boundaries in relation to normal, abnormal and extreme data
Data will be tested in three ways.
* Normal: If the textbox expects a number give it a number E.G: 3.
* Abnormal: If the textbox expects a number give it a string E.G: "Apple" and see if it handles the incorrect data type
* Extreme: If the textbox expects a number give it a very large number E.G: 4564564686798

### Proposed test schedule
Testing should be done after a new feature is added and any related features should also be tested again to ensure that they have not stopped working due to the new feature.

### Proposed maintenance and update schedule
Maintenance and updates should be done once a week to avoid stress on the user updating the application too much. Once a week is a good balance and allows time for more advanced features to be added within the week as well.

Test Number | Test Type | Target | Purpose | Test Data | Expected Result| Actual Result|
------------ | ------------- | ------------- | ------------- | ------------- | ------------- | -------------
0 | Button | Main Form | To identify any issues with the buttons on the target | Left Mouse Click | Button to open menu associated with the button as per the specification | ??
1 | Text Input | Main Form | To identify any issues with the search box on the target | Normal / Abnormal / Extreme | Searches for the string and returns matching reminders| ??
2 | Scroll | Main Form| To identify any issues with the scrolling over the reminders | Mouse Wheel Scroll Up/Down | scrolls only the reminders and not the tags | ??
3 | Text box | New Reminder Form | To identify any issues with the "Reminder Name" Text box and see if error checking works | Normal / Abnormal / Extreme | Text box to only allow alphanumeric characters | ??
4 | Text box | New Reminder Form | To identify any issues with the "Reminder Description" Text box and see if error checking works | Normal / Abnormal / Extreme | Text box to only allow alphanumeric characters | ??
5 | Radio Button | New Reminder Form | To identify any problems with the radio button selections | Left Mouse Button | To change the questions post to this one depending on the input | ??
6 | Text Selection | New Reminder Form | To identify any problems with the text selection box | Left Mouse Button| To select the goals specified in the text selection box | ??
7 | Button | New Reminder Form | To identify any issues with the "Add Reminder" button on the target | Left Mouse Button | The form should search for errors in the users input and if there are none, create the reminder. | ??
8 | Button | Delete Confirmation | To identify any issues with the buttons on the target | Left Mouse Button | The buttons should either delete the reminder or preserve it as the user canceled | ??
9 |

