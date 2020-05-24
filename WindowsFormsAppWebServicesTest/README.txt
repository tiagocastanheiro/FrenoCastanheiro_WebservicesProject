!!!!!!! PLEASE DON'T OPEN THE form1.cs FILE !!!!!!!!

It may produce errors with the user controls and the service reference, some connections may be deleted !!!

Maybe if you want to see the work done in this file, you can run the first time the app without opening it. 
When you have finished to test, you can open the file (knowing that probably it could break the app Windows Form App)

To run our windows form app, you need to open the database at WcfServiceMSSQL/App_Data/StudentsDB.mdf, 
update the service reference : MSSQLServiceReference in Connected Services

And rebuild the entire solution.

All calls to our webservice are done in the repository UserControls.
No calls are made into form1.cs.
