# LawnService
Windows Form Application created for a lawn service business for Database Development class (final project)

TODO:
-Add concurrency/database update faults to Customers, Employees, and Vendors List Forms.
-Disallow user from selecting another item in database when clicking edit. Doing so allows them to change the row without any validation (for example: they can make it so a name is blank instead of containing a name due to this.) To replicate, click edit, then input false/bad information in one of the fields. Select another row, and click "save changes". Bad fields from other selection will be saved also in the database.