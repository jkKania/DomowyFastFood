# DomowyFastFood

Application downloads a dish of the day from a number of catering restaurants in Bielsko - Biała by parsing their websites 
html and presents them to user allowing to make an order.

Program uses Entity Framework and Windows Forms

## Application business background

Program is made to `ease` the process of `ordering the dinner` inside the company `by employees`.

## Process mdoel:
- Employees log in the application
- Emplayees make orders for dinner
- One of employee in a company has an `Administrator` account who is able to `see all orders` and `execute` them contacting with restaurants

---

## How to work with the application

Application is written using `Database first` approach, which requieres recreation of db state on your local computer 
which may be problematic but repository has attached *.mdf files in `/PlikiBazy` folder. 

---

## Sample detailed application workflow:

- User creates account or logs in
- User is able to see dishes of the day and refresh the list comparing the date of last refresh
- User can make an order and store it in the database `Orders` table
- Administrator from his panel is able to see all orders made by every user and delete the selected order using a button after executing it.
