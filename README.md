# Http---Request
Create HTTP Request based WebAPI Service using .NET and C-Sharp without using Database. Following are the steps to create and excute the project. 

## Get Started 
1. Create a repository on GitHub and clone it into your local system. 
2. Move inside the directory. 
3. Execute the following list of commands 
    
    ``` bash
    dotnet --version
    ```
    Check the version of dotnet, update if required
    
    ``` bash
     dotnet new list
    ```
    Check list of all possible .NET framwork services

    ``` bash
    dotnet new create webapi
    ```
    Create new .NET WebAPI service
4. Move inside the folder. 
5. Create Model Folder and a model file. Copy the content of Model/Todo.cs
6. Open Controller folder and update the controller file. Copy the content of Controller/ToDoController.cs
7. To run the service, open terminal and run command
    ``` bash
    dotnet run
    ```
    Run the .NET
8. Open localhost - http://localhost:{port}
9. Add name of the controller - http://localhost:{port}/{ControllerName}
10. Open Swagger to perform the HTTP Request Operation - http://localhost:{port}/swagger/index.html