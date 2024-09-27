# Project Overview

This project is divided into two sub-projects: a RESTful .NET API for managing GitHub projects and a web portfolio created with the .NET MVC framework. The portfolio content has been designed after the course content and the design is a personal retro-inspired design.

Portfolio landing page
<img src="https://kimmoprojectstorage.blob.core.windows.net/project/portfolio.webp" />

Project carousel
<img src="https://kimmoprojectstorage.blob.core.windows.net/project/portolio-project-carousel.png" />
### Project Links
- **Portfolio:** [View Portfolio](https://project-2-kimmo.azurewebsites.net/)
- **API:** [View API](https://project-2-api-kimmo.azurewebsites.net/swagger/index.html)

## Portfolio
The web portfolio is developed using the .NET MVC framework and is a single page application. It showcases various projects of mine and provides an overview of skills and experience used in these project. 
The portfolio itself (this project you are viewing right now) has used several different patterns used in C# development:

### Service patterns
Service patterns and view models have been used to separate database entities from business logic.

### Library for database
Database logic has been placed in a separate library to encourage separation of concern. Entity Framework Core has been used as an ORM and SqlServer has been the database of choice.

### HTML, CSS and Javascript
This portolio uses CSS and HTML for its design. The design is inspired by retro design with sharp angles, thick borders and shadows as well as a minimalistic color choice with a lot of spacing.

### Features
- Display of GitHub projects
- A contact form which opens your email client of choice.

## API
The RESTful API is built with C# and follows the MVC pattern, providing endpoints to manage and retrieve information about GitHub projects. This api has been kept very simple by design and any CRUD operations other than Read (all) have been omitted.

### Features
- Receive a list of all my available projects that I wish to showcase.
- Contains information about tech stacks used as well as urls for images, project urls and descriptions.
