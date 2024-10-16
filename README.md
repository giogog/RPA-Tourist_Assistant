RPA Project - Travel Ticket Form Automation
This project is built using UiPath Studio and automates the process of filling travel ticket forms for tourists. It combines UiPath Coded Workflows with standard sequences, and the automation is organized with separate classes and extension methods for better structure and maintainability.

Project Flow
Email Integration: The robot connects to an email server and retrieves emails from tourists. Each email contains essential information such as the tourist's name, address, and destination country.
Data Processing: A service processes the retrieved data by filtering, parsing, and organizing it into dictionaries.
Form Filling: The robot navigates to a webpage where the travel forms are located. Each form is on a separate page, and the robot fills them sequentially, ensuring one form is completed before moving on to the next.
PDF Generation & Email Response: Once all forms are filled, the robot downloads a PDF version of the completed forms and sends it back to the original email sender.
This project streamlines the process of handling multiple travel requests, making it efficient and error-free.
