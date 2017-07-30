# WorldBankPaper001
1. Source Codes of Factor Analysis Affecting the Number of Bank Branches Across Countries 
2. You need SQL Server and .Net client utilities to run this project
3. Create database and db objects using \DataUpload\DatabaseObjects\DbObjects.txt
4. Change the connection string in the method LoAndBehold (in the form1.cs)
5. Download all of the data for a selected year from woldbank database (http://databank.worldbank.org/data/reports.aspx?source=world-development-indicators)
6. Unzip all of the data to a folder you downloaded from worldbank website.
7. Run the application and specify data path (default value is :D:\work\data\)
8. First load definition (indicator names) using "LoadDefinition" button.
9. After that press" LoadData" button and wait approximately 20 minutes. 
10. Check log.txt periodically
11. Switch to  SSMS (sql server management studio) and run  "exec sp_prepare_data"
12. After that run "exec sp_prepareStmt"  
13. Copy results of this sp and execute then in other query window.
14. Using sp_sel_WBCorelation stored procedure you can start your analysis
15. Any kind of recommentation and bug fixing send me a message using mucahitg@gmail.com address. 
16. Regards...
