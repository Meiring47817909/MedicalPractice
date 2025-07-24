# Medical practice
## To install the medical practice application follow these steps:
<details open>

<summary>Database setup</summary>

### You can add a header

You can add text within a collapsed section.

You can add an image or a code block, too.

```ruby
   "Hello World"
```

</details>

<ol>
  <li>Database setup</li>
  <ol class="lead">
    <li>
        After installing and extracting the application. Ensure that you locate the database file within the Desktop_Application > Database folder:
        <img width="652" height="82" alt="image" src="https://github.com/user-attachments/assets/4436ceff-0d33-4e5d-9cd4-b2d033c57a8f" />
    </li>
    <li>
        Open Microsoft SQL Server Management Studio and select "Import Data-tier Application..." and click Next:
        <img width="295" height="162" alt="Image" src="https://github.com/user-attachments/assets/328f62a0-c9d6-40a1-a446-3f7e7d546bb2" />
    </li>
    <li>
        Browse and select the "Brighton_Medical_DB.bacpac" file located in step 1 and Click Next:
        <img width="502" height="118" alt="Image" src="https://github.com/user-attachments/assets/2f46733d-d73a-4bff-a0c3-d1f716b047b2" />
    </li>
    <li>
        Ensure that the database is named exacly as follows, click Next and Finish:
        <img width="143" height="56" alt="Image" src="https://github.com/user-attachments/assets/c47bb0db-885c-41cd-b2bd-df21b7ec6876" />
    </li>
     <li>
        The database should know be installed with the following tables:      
        <img width="194" height="198" alt="Image" src="https://github.com/user-attachments/assets/201e0814-30d5-4d14-9a9c-ab943e184c42" />
    </li>
  </ol>
  <li>Program setup</li>
  <ol>
      <li>
        Go to the Desktop_Application folder and open the "App.config" file with a code editor application:
        <img width="318" height="179" alt="image" src="https://github.com/user-attachments/assets/2c098a0a-e6ef-420c-b81e-974b4a08f009" />
      </li>
      <li>
          Ensure that you enter the correct connection string for the windows form application to access the database on Microsoft SQL Server:
          <img width="431" height="101" alt="Image" src="https://github.com/user-attachments/assets/e6424862-a202-4e45-9854-48ff17e156cb" />
      </li>
      <li>
          Go to the Web_Application folder and open the "Web.config" file with a code editor application:
          <img width="313" height="183" alt="image" src="https://github.com/user-attachments/assets/c71ff579-fa2a-481d-a14e-0e9388b31a4f" />
      </li>
      <li>
          Ensure that you enter the correct connection string for the web application to access the database on Microsoft SQL Server:
          <img width="431" height="101" alt="Image" src="https://github.com/user-attachments/assets/e6424862-a202-4e45-9854-48ff17e156cb" />
      </li>
      <li>
          Open the "47817909_Exam_Project.sln" solution file in Visual Studio and start the program:
          <img width="195" height="135" alt="image" src="https://github.com/user-attachments/assets/195b65b8-81a7-42f9-bf60-504707f9d93c" />
          <img width="67" height="58" alt="image" src="https://github.com/user-attachments/assets/a6b7730a-b503-4047-9bc6-1f8ce6027ef9" />
      </li>
      <li>
           You can log in with Administrator ID: "MV_1" and Password: "ne4124ne" from the "tblAdministrators" table:
          <img width="502" height="339" alt="image" src="https://github.com/user-attachments/assets/f8ab5f4b-02e8-4e79-b5af-8e4def82f5f7" />
      </li>
    </ol>
</ol>
