﻿# Cognition

An ASP.NET MVC Web app to manage structured data such as profiles or knowledge base articles. A cross between a wiki, CMS and database app. For a video overview go to: http://www.edandersen.com/2013/10/10/open-sourcing-cognition/

This is built as an experiment with modern .NET tools and frameworks as of August 2013:

* .NET 4.5
* async/await as much as possible
* ~~MVC5~~ Updated to 5.1
* ~~SignalR 2.0 beta~~ Updated to 2.0
* ~~Entity Framework 6 beta~~ Updated to 6.1
* CouchDB via the awesome MyCouch library: https://github.com/danielwertheim/mycouch
* Bootstrap 3 RC2

## Features

* A CouchDB-based document storage engine.
* Supports a type-based system of dynamic document types. There are two implementations available:
  * Static, compiled document types
  * Dynamically set by the user and compiled at runtime. There is an editor in the admin area.
* Markdown support for string properties with the ```[DataType(DataType.MultilineText)]``` attribute
* View previous versions and supports reverting
* A simple token-based search across document titles
* Permissions system to restrict the following to anonymous users, registered users, email address or email domain:
  * Public documents
  * Internal documents (default)
  * Registration
  * Admin access
* Google single sign on support
* Live updating of document pages and update feed
* Simple app.config configuration


## Planned features
* Document store engines based on MongoDB and SQL Server
* Comments on documents
* Change Subscription to documents for notifications
* Full text searching
* Advanced search on document properties
* Document collections
* Parent/Child relationships
* Document reference fields
* File attachments
* Image drag and drop
* Web UI for app config

... and lots more!

Developed by Ed Andersen (eandersen at mdsol.com). Only made possible by the Innovation Time programme at Medidata Solutions. We are hiring!

Licensed under MIT.
