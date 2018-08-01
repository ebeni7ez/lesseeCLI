# leeseCLI

ASP MVC Client for managing hardware leasing.

## Dependencies

- RestSharp/106.3.0
- Microsoft.AspNetCore/2.1.0

## REST API base url 

Callers/ICaller.cs
```
static class Constants
{
    public const string baseUrl = "http://localhost:5000/";
}
```

## Obstacles

There was a problem with setting up Docker

https://github.com/docker/for-win/issues/464

A Docker file is created and docker-compose.py file, however it wasnt possible 
to make the app running this way. Running locally on Visual Studio instead.