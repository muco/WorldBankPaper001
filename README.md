# WorldBankPaper001
Source Codes of Factor Analysis Affecting the Number of Bank Branches Across Countries 
You need SQL Server and .Net client utilities to run this project
Create database and db objects using \DataUpload\DatabaseObjects\DbObjects.txt
Change the connection string in the method LoAndBehold (in the form1.cs)
Download all of the data for a selected year from woldbank database (http://databank.worldbank.org/data/reports.aspx?source=world-development-indicators)
unzip all of the data to a folder you downloaded from worldbank website.
Run the application and specify data path (default value is :D:\work\data\)
First load definition (indicator names) using "LoadDefinition" button.
After that press" LoadData" button and wait approximately 20 minutes. 
Check log.txt periodically
Switch to  SSMS (sql server management studio) and run  "exec sp_prepare_data"
After that run "exec sp_prepareStmt"  
Copy results of this sp and execute then in other query window.
Using sp_sel_WBCorelation stored procedure you can start your analysis
any kind of recommentation and bug fixing send me a message using mucahitg@gmail.com address. 
Regards...
