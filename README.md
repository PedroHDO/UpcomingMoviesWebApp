# Upcoming Movies Web App
## Author
Pedro H.D. de Oliveira - phdo.pedro@gmail.com

## Demo
https://upcoming-movie-webapp.azurewebsites.net/search/

## Architecture
The project was builded with a react app on Frontend, connection with a .net core web API on Backend.

### Frontend 
- services - To centralize the request to backend
- store - To redux store and join the reducer
- pages - To primary pages
- features - to components and subcomponentes from a features
- components - to generic components, such form's inputs, navbar, buttons, etc
- common - to generic functions shared between the components

### Backend
- Web Api - To provide the entrypoints
- Domain - To centralize the application's domain. (Entities, Services, IRepositories)
- Infra.Data - To provide the data to Domain, connecting with the TMDbApi (Repositories implementations, Mapping)
- Common - To generic things shared between the project

## Assumptions
* Language: English

## Libraries
### Backend - C# .Net Core
* **Newtonsoft.Json** - to deserialize json
* **Autofac** - to inject the dependencies

### Frontend - React
* **create-react-app** - as boilerplate
* **reactstrap/bootstrap** - as a base css
* **axios** - to do the ajax requests to the backend API
* **query-string** - to parse and stringify query strings
* **moment** - to do the date presentations
* **redux** - to share the genre result with each instance as needed
