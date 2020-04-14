# Pierre's Treats

#### _ Many to many C# app, 4/12/2020_

#### By _**Steven Fleming**_

## Description

_Tracks inventory of treats and the treats respective flavors for a specific shop owner._

## Setup/Installation Requirements

- _Download .NET from here: https://dotnet.microsoft.com/download/dotnet-core/current_
- _Download .NET script in the Terminal with this command { dotnet tool install -g dotnet-script }_
- _Download MySQL from here: https://dev.mysql.com/downloads/_
- _Git clone Or download the zip file from gihub { https://github.com/stevenfleming/PierresTreats.Solution }_
- _In the Terminal run this command { dotnet ef migrations add Initial }_
- _In the Terminal run this command { dotnet ef database update }_
- _In the Terminal run this command { dotnet build }_
- _In the Terminal run this command { dotnet run }_

## Specs

- _Spec:_ When user opens localhost:5000.

- The application supports user authentication and a many-to-many relationship.
- A user should be able to log in and log out.
- Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.
- There should be a many-to-many relationship.
- A user should be able to navigate to a splash page that lists all instances of each class. Users should be able to click on an individual instance to see all the instances that belong to it.
- All classes have all CRUD methods implemented
- able to view both sides of the many-many relationship. For a particular instance of a class, you may view all of the instances of the other class that are related to it?
- Users are able to register, log in and log out with Identity.
- Create, Update and Delete functionality are limited to authenticated users

## Known Bugs

_No known bugs_

## Support and contact details

_Email: 12flemings@gmail.com_

- Contributions to the code are encouraged

## Technologies Used

_C#, .NET, MSTest, MySQL, Html, Entity Framework_

### License

\*Copyright (c)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN\*

Copyright (c) 2020 **_Steven Fleming_**
