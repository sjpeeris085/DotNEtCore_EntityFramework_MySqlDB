# DotNEtCore_EntityFramework_MySqlDB
DotNEtCore_EntityFramework_MySqlDB With All Steps

         Create New .Net Core Winform Project - NOT WinForm(.Net Framwork)
         Go to View -> Terminal
         Goto project folder by terminal:- cd <project_name>
         To Scaffolding a MySQL run follwing command with correct values
         dotnet ef dbcontext scaffold "Server=localhost;Database=myDatabase;User=userame;Password=password;" "Pomelo.EntityFrameworkCore.MySql"

         Ref : https://www.youtube.com/watch?v=iKSj3AyGq8w

         .Net Version : 5.0  (.Net Core)
         Packages Using : 
           - Microsoft.EntityFrameworkCore.Design  5.0.11
           - Pomelo.EntityFrameworkCore.MySql      5.0.2
           
         Install Packages :- Project explorer ->  Right click on the project -> Nuget package -> brows
