# MVC-Knockout
Knockout &amp; MVC

Knockout.js is an open source JavaScript library that allows you to create dynamic
and rich web applications. It is built with the Model-View-ViewModel (MVVM) pattern.
Knockout makes it really simple to implement a complex user interface that
responds to user interactions.
I like Knockout because it is one of the most lightweight JavaScript libraries available
today. It also doesn’t try to be an all-in-one framework. It serves a single purpose:
data binding your ViewModel to your user interface.
Implementing Knockout involves three distinct things: a view that contains HTML
and CSS elements that get data-bound to it, a ViewModel that contains the data to
bind to the view, and telling Knockout to perform the data binding to the view with
the ViewModel.

Table of Contents
Preface. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ix
Part I. Getting Started
1. Introduction to MVC. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 1
	Creating Your First Project 1
	Examining the HomeController 4
	Examining the Views 6
	Understanding the URL Structure 8
	Summary 9
2. Introduction to Bootstrap. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 11
	Examining the Default Menu 11
	A Menu with Drop-Downs and a Search Box 14
	Buttons 17
	Alerts 19
	Themes 20
	Summary 20
3. Introduction to Knockout.js. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 21
	Installing Knockout.js 21
	A Basic Example 23
	What Is MVVM? 25
	Creating ViewModels 26
	Summary 29
4. Working with a Database. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 31
	Introduction to Entity Framework 32
	Code First 33
	Database First 37
	Creating Test Data 41
	Summary 44
Part II. Working with Data
5. Listing, Sorting, and Paging Through Tables. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 47
	Scaffolding the Author Model 47
	Sorting the Authors 55
	Paging the Authors 61
	Summary 66
6. Working with Forms. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 67
	Integrating Knockout with a Form 67
	Sharing the View and ViewModel 75
	Deleting with a Modal 83
	Empty Table Listings 88
	Summary 90
	7. Server-Side ViewModels. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 91
	Why Create Server-Side ViewModels? 91
	The Authors ViewModel 93
	Updating the Authors Listing 94
	Updating the Add/Edit Form 95
	Updating the Delete Modal 97
	Summary 98
8. Introduction to Web API. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 99
	Installing Web API 99
	Updating the List of Authors 102
	Updating the Add/Edit Authors Form 112
	Summary 115
Part III. Code Architecture
9. Creating Global Filters. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 119
	Authentication Filters 119
	Authorization Filters 120
	vi | Table of Contents
	www.it-ebooks.info
	Action Filters 120
	Result Filters 120
	Exception Filters 120
	Global Web API Validation 121
	Automapping with a Result Filter 125
	Web API Error Handling 129
	MVC Error Handling 132
	Summary 135
10. Adding Authentication and Authorization. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 137
	Authentication Overview 137
	Authorization Overview 138
	Implementing an Authentication Filter 139
	Implementing an Authorization Filter 148
	Summary 152
11. URL Routing Using Attributes. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 153
	Attribute Routing Basics 153
	Route Prefixes 157
	Routing Constraints 158
	Summary 162
12. Fat Model, Skinny Controller. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 163
	Separation of Concerns 163
	Controllers 164
	Services 164
	Behaviors 165
	Repositories 165
	Orchestrations 165
	Unit of Work 166
	Services and Behaviors 167
	Summary 175
Part IV. A Practical Example
13. Building a Shopping Cart. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 179
	Shopping Cart Requirements 179
	The Shopping Cart Project 180
	JavaScript Bundling and Minification 181
	Summary 183
	

14. Building the Data Model. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 185
	Code-First Models 185
	Defining the DbContext and Initializing Data 188
	The ViewModels 192
	Summary 195
15. Implementing the Layout. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 197
	The Shared Layout 197
	The Cart Summary 199
	The Categories Menu 207
	Summary 211
16. Lists of Books. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 213
	The Home Page 213
	The Featured Books 214
	Filtered Books by Category 218
	Summary 221
17. Adding Items to the Cart. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 223
	The Book Details 223
	Custom Components and Custom Bindings 228
	Saving the Cart Item 235
	Summary 238
18. Updating and Deleting Cart Items. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 239
	The Cart Details 239
	Knockout for the Cart Details 243
	Completing the Shopping Cart 248
	Summary 251
