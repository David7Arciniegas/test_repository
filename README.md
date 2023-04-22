-   Install Git: If you haven't already, download and install Git on your machine.
    
-   Clone the repository: Open a command prompt and navigate to the directory where you want to clone the repository. Then, use the `git clone` command to clone the repository, like so:
        
-   `git clone <repository URL>` 
    
-   Open the project in Visual Studio: Open Visual Studio and click on "Open a project or solution" on the start page. Navigate to the directory where you cloned the repository and select the `.sln` file for the project.
    
-   Restore dependencies: Once the project is open, Visual Studio will automatically restore the project's dependencies. However, if you run into any issues, you can manually restore them by running the following command in the Package Manager Console:
    
-   `dotnet restore` 
    
-   Run the project: You can run the project by clicking on "Debug > Start Debugging" or pressing `F5`. This will launch the project in the configured runtime environment (e.g., IIS Express or Kestrel).

-   By default your web browser should open pointing to localhost:port/index.html. Remove the ".html" extension in the address bar to navigate to the index page. You can use the index page to build the search page as described in the email. You can visit `localhost:port/swagger` to get a overview of all available API endpoints. Use the ` localhost:port/search` endpoint for the JavaScript framework part of the task. Example request: `https://localhost:7051/search?prefix=Doctor&location=Berlin`
