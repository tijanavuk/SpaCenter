# SpaCenter
Graduation thesis on the topic "Development of a software system for monitoring the operation of the SPA center using .NET technology".

Key Features:

Windows Presentation Foundation was used to develop the application.

Client-Server Architecture: The application operates using a client-server model.

Socket Communication: To ensure robust and secure communication, the application employs socket technology. Sockets facilitate the efficient exchange of information between the client and server parts of the program, enabling real-time updates and notifications.

Model-View-Controller (MVC) Pattern: The application is built following the industry-standard Model-View-Controller pattern. This design approach separates the application into three distinct components:

Model: The model handles data management and processing, ensuring that all information is accurately stored and updated.
View: The view represents the user interface, allowing clients to interact with the application intuitively and conveniently.
Controller: The controller acts as an intermediary between the model and view, managing user inputs, processing requests, and updating the model accordingly.
Through the MVC pattern, the application achieves enhanced maintainability, scalability, and flexibility, making it easier to adapt to future requirements and advancements.


Verbal model:

This software represents a system for monitoring the operation of the spa center. A software system enables easier storage and management of data. Records are kept about employees, customers, services, loyalty programs, receipts, payment methods, categories, and roles that the employee can have.
The users of the system are employees from the spa center. There are two types of employees, an ordinary employee and an employee who has an admin role. Admins are able to use more functionality than ordinary employees.
The services consist of various treatments, massages, and face and body care.
Clients represent registered users of the spa center. Regular clients can take advantage of the loyalty program that allows them to use the spa center at more favorable prices.
In the system, it is possible to issue receipts for services and create a PDF document for the issued receipts using one of the libraries provided for this functionality. There is the possibility of canceling receipts.
An ordinary user can use the following functionalities: creating new, searching, changing, and deactivating clients, and services. If the receipt is created for a customer who is registered and owns loyalty cards, the amount on the account would be reduced by a discount depending on the type of loyalty card. 
In addition to the functionalities listed for ordinary users, the admin user can use a few more functionalities: creating new, editing, and deactivation of employees. There is also the possibility of adding new roles to employees. Admin users can manipulate loyalty programs too.
