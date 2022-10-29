# Meal Planning API
## Overview
This repository is the source code for a RESTful API for a Meal Planning application.

## Deployment
The current plan is to deploy this API using Azure services.

## Database
This API communicates with an Azure SQL database which is located on an Azure Sql Server. The name of the database is "mealplanning".

## Tables
The database contains four tables:
1. Users
2. Recipes
3. Households
4. Groups

### UsersDB
This table contains the details of the users of the application.
- UserID
- FirstName
- LastName
- Email

### Recipes
This table contains the details of the available recipes within the application.
- RecipeID
- Recipe Name
- Difficulty
- PrepTime

### Households
This table contains the names of the households which exist within the application.
- HouseholdID
- Name

### Groups
This table stores all the informmation of the groups that are created. Each group contains:
- GroupID -> The primary key for the group which is an integer.
- HouseholdID -> A foreign key from the Households table which links the household to the group.
- AdminID -> A foreign key from the Users table whick links a user as the admin of the group.
- Members -> A string of numbers which contain the Id's of the users which are associated with this group.


## Endpoints
Summary of the endpoints for the API.