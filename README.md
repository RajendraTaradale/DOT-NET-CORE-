# DOT-NET-CORE-
.Net Core Security

:green_book: https://github.com/RajendraTaradale/CleanArchitecture  Structure a .NET Solution - project separation & architecture layers.

:green_book: https://code-maze.com/ Best blogs realted to .Net core

:green_book: https://dotnetcorecentral.com/ Everything .Net Core

:curly_loop: https://github.com/RajendraTaradale/Northwind-EFCore3 Entity Framework boilerplate

![Screenshot](https://github.com/RajendraTaradale/DOT-NET-CORE-/blob/master/Rajendra%20taradale%20clean%20architecture.PNG)

![Screenshot](https://github.com/RajendraTaradale/DOT-NET-CORE-/blob/master/CQRS%20Architecture%20Diagram.PNG)

:green_book: https://sites.google.com/site/craigandera/craigs-stuff/scalability-considerations/five-considerations-for-large-scale-systems

:green_book: https://sql-plsql.blogspot.com/2013/08/multiple-choice-questions-sql-server.html

:green_book: https://www.youtube.com/watch?v=0acSdHJfk64&t=633s (Logging into Elasticsearch using Serilog and viewing logs in Kibana)

:curly_loop: https://github.com/RajendraTaradale/elastic-kibana-netcore-serilog

:green_book: .Net Core EF Content Code First- 

💡  https://www.learnentityframeworkcore.com/ - A to Z about EF

1. add-migration
2. update-database
3. remove-migration
4. update-database <old_migration_name>
5. script-migration

:green_book: Database first approach

1. Connecting to the existing database.
2. Adding the Connection String to the AppSettings.JSON file.
3. Installing the necessary packages.
4. Using the Scaffold command to generate the models.

The Scaffold Command: 
-----------------------------------------
Scaffold-DbContext {-Connection-string-in-quotations-} Microsoft.EntityFrameWorkCore.SqlServer -outputdir Repository/Models -context {-databasename-}DbContext -contextdir Repository -DataAnnotations -Force

```
Scaffold-DbContext "Server=.\SQLExpress;Database=RTDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

**The -OutputDir parameter specifies the directory where we want to generate all the classes which is the Models folder in this case.

Scaffold-DbContext "Server=.\;Database=RajendraDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model -Context "RajendraContext" -DataAnnotations

--data-annotations -> if you prefer to use Data Annotations for configuration, by specifying the -d or --data-annotations

--force  -> If you want to re-scaffold the model after database schema any new changes have been made, -> by specifying the -f or --force

```
Other

https://www.indeed.com/career-advice/interviewing/most-common-behavioral-interview-questions-and-answers
https://coderbyte.com/starter-course/algorithms-and-data-structures
1. Repl.it
2. Codechef
3. Turorialspoint
4. DotnetFiddle
5. Coderbyte
6. OnlineGdb
7. Resxtester
8. HackerEarth


:green_book: https://www.diagrameditor.com/

:green_book: https://dev.to/tomeraitz/tricky-javascript-questions-7nk?utm_source=digest_mailer&utm_medium=email&utm_campaign=digest_email

:green_book: https://www.csharpstar.com/csharp-program-to-implement-binary-search-tree/

:green_book: https://studyalgorithms.com/

:green_book: https://cp-algorithms.com/

:green_book: https://www.educative.io/courses/grokking-the-system-design-interview/3jEwl04BL7Q

:green_book: https://lethain.com/introduction-to-architecting-systems-for-scale/

:green_book: https://www.fullstack.cafe/interview-questions/angular 

:green_book: https://www.interviewbit.com/angular-interview-questions/
