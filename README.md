Application for browsing and modifing data, accessing files and folders and creating text files

SHORT DESCRIPTION This project uses a database with which a user can interact with to browse car models using search filters. The results can be stored in a file while the user has the ability to modify the database updating, deleting or inserting new data. In addition the user has quick access to files and folders from a tree view menu with the ability to change the root directory and apply copy, cut, paste and delete operations on them. Lastly the user can send emails.

GETTING STARTED PREREQUISITES Visual Studio (preferably 2015/2017), MS Server with Microsoft SQL Server Management Studio Installed. This project uses MS Server 17 but older edition are compatible too.

RUNNING THE APPLICATION i) Once you have installed the above open Sql Server Management Studio. When you open the program a window will appear asking you to connect to Sql Server(in this case the Sql Server is your computer). Select: Server type: Database Engine Server name: DESKTOP-07JF109\SQLEXPRESS (it will be something like that, this is my computer server name) Authentication: Windows Authentication and click connect.

ii) This application uses a Datadase named Cars and a Table named MycarsTB. To create them right click on the Databases folder, select New Database and give a name for your database (e.g Cars). Tip: To view changes right click on the respective folder and select refresh. To create the Table select the New Query option from the toolbar menu and make sure you are connected to the Cars database from the textbox on the top left. Then type the following create table sql command:

CREATE Table MycarsTB ( ID int IDENTITY(1,1) PRIMARY KEY, Brand varchar(MAX), Model varchar(MAX), [Engine Type] varchar(MAX), [Engine Capacity] int, [Max Speed] varchar(MAX), Acceleration varchar(MAX), [Horse Power] varchar(MAX), Fuel varchar(MAX), [Fuel Consumption] varchar(MAX), Doors smallint, Type varchar(MAX), [Price(€)] int, Reused varchar(MAX) );

Now refresh the folder Tables, right click on the MycarsTB you just created and select Edit Top 200 Rows. A sample data which i have inserted to my table are with the following format: Brand Model Engine Type Engine Capacity Max Speed Acceleation Horse Power Fuel Fuel Consumtion Type Doors Price Reused Skoda Octavia RS 2.0 TDI 2000 230 km/h 8.0 sec 184 hp Diesel 4.5 L/100 km Combi 5 28000 Yes

After you have filled your table with some data refresh the table.

iii) Open CarsApplication.sln with Visual Studio. Go to the QueryExecution.cs class and replace in the connectionString variable the word myLocalServerName with your Server name. e.g "data source = DESKTOP-07JF109\SQLEXPRESS; Initial Catalog = Cars; Integrated Security = SSPI";

Note: If you gave different name to the datadase you have to change it in the Initial Catalog above. If you gave different name to the table you have to replace it in the queries in the QueryExecution.cs class.

iv) Go to form1.cs and change the default directory path in the treeViewRootDirectoryPath variable.

Now the application is ready to start with your own data.
