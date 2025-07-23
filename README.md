# Medical practice
To install the medical practice application follow these steps:
1. After installing and extracting the application. Ensure that you locate the database file within the Desktop_Application > Database folder:
<img width="885" height="108" alt="Image" src="https://github.com/user-attachments/assets/9396d0d6-f484-4ec7-b51e-b02571966b88" />

2. Open Microsoft SQL Server Management Studio and select "Import Data-tier Application..." and click Next:
<img width="295" height="162" alt="Image" src="https://github.com/user-attachments/assets/328f62a0-c9d6-40a1-a446-3f7e7d546bb2" />

3. Browse and select the "Brighton_Medical_DB.bacpac" file located in step 1 and Click Next:
<img width="502" height="118" alt="Image" src="https://github.com/user-attachments/assets/2f46733d-d73a-4bff-a0c3-d1f716b047b2" />

4. Ensure that the database is named exacly as follows, click Next and Finish:
<img width="143" height="56" alt="Image" src="https://github.com/user-attachments/assets/c47bb0db-885c-41cd-b2bd-df21b7ec6876" />

The database should know be installed with the following tables:

<img width="194" height="198" alt="Image" src="https://github.com/user-attachments/assets/201e0814-30d5-4d14-9a9c-ab943e184c42" />

5. Return to the Desktop_Application folder and open the "App.config" file with a code editor application:
<img width="369" height="250" alt="Image" src="https://github.com/user-attachments/assets/0c4daee9-da03-4240-9bf8-07b19afef642" />

6. Ensure that you enter the correct connection string for the windows form application to access the database on Microsoft SQL Server.
<img width="431" height="101" alt="Image" src="https://github.com/user-attachments/assets/e6424862-a202-4e45-9854-48ff17e156cb" />

7. Go to the Web_Application folder and open the "Web.config" file with a code editor application:


8. Ensure that you enter the correct connection string for the web application to access the database on Microsoft SQL Server.
