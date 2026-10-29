# Week 1 = Chapter 1: Introduction to Visual C#

## Introduction

This week I studied the basic concepts of Visual C# and Windows Forms applications. The chapter introduces objects, controls, Visual Studio, forms, C# code, events, and some basic programming concepts used when creating a Windows Forms application.



## 1. Objects

An object is a program component that contains data and can perform operations.

Objects have:

* Properties = information or settings that describe an object.
* Methods = actions that an object can perform.

For example, a Button is an object. It has properties such as its text and name, and it can perform actions when the user clicks it.



## 2. Controls

Controls are objects that are visible in the graphical user interface (GUI) of an application.

Some common controls are:

* Label
* Button
* TextBox
* PictureBox

There are also some controls that are not normally visible, such as timers and OpenFileDialog.

A class is code that describes a particular type of object.



## 3. .NET Framework

.NET is a collection of classes and other code that can be used to create applications.

C# is one of the programming languages supported by .NET. Many of the controls used in Windows Forms applications are provided by classes in .NET.



## 4. Visual Studio

Visual Studio is an Integrated Development Environment (IDE) used for creating and developing applications.

Some important parts of the Visual Studio environment are:

* Designer Window
* Solution Explorer
* Properties Window
* Toolbox
* Code Editor

The Designer Window is used to design the form.

The Solution Explorer shows the projects and files in the solution.

The Properties Window is used to view and change the properties of selected objects.

The Toolbox contains controls that can be added to a form.



## 5. Projects and Solutions

A Visual Studio application is created as a project.

A project contains the files needed for an application.

A solution is a container that can hold one or more projects.

For example:

* Solution = can contain projects
* Project = contains application files
* Files = contain the code and resources of the application



## 6. Forms and Controls

When a new Windows Forms application is created, an empty form is created automatically.

The form is the main window of the application. Controls such as Buttons, Labels, and TextBoxes can be placed on the form.

Controls can be:

* Added from the Toolbox
* Moved around the form
* Resized
* Deleted
* Modified using the Properties Window



## 7. Properties

Properties control the appearance and behavior of an object.

For example, a form has properties such as:

* `Text`
* `Size`
* `BackColor`

A control also has properties. For example, a Button can have a `Text` property that determines what is displayed on the button.

To change a property, select the object and then change the property value in the Properties Window.



## 8. Naming Controls

Controls have names that are used to identify them in code.

Some basic rules for naming controls are:

* The first character must be a letter or an underscore.
* Other characters can be letters, numbers, or underscores.
* Spaces are not allowed.

C# programmers commonly use camelCase for control names.

Examples:

```csharp
showDayButton
displayTotal
scoreLabel
```

In camelCase, the first word starts with a lowercase letter and the following words start with uppercase letters.



## 9. Creating a GUI

GUI means Graphical User Interface.

A Windows Forms application uses a GUI so that users can interact with the program using controls such as buttons, text boxes, labels, and pictures.

The GUI is created in the Designer by adding controls to the form and changing their properties.



## 10. Introduction to C# Code

C# code is mainly organized into:

* Namespaces
* Classes
* Methods

A namespace is a container that holds classes.

A class is a container that holds methods.

A method is a group of one or more statements that performs an operation.

A file that contains C# code is called a source code file.



## 11. Form1.cs

In a Windows Forms project, `Form1.cs` contains code associated with the Form1 form.

The Form1 class contains methods that control what happens in the form.

The constructor of the form contains:

```csharp
InitializeComponent();
```

This is used to initialize the controls and components of the form.



## 12. Event-Driven Programming

Windows Forms applications are **event-driven**.

This means that the program waits for something to happen and then responds to that event.

Examples of events include:

* Clicking a button
* Pressing a key
* Moving the mouse

An event handler is a method that runs when a specific event occurs.

For example, when a Button is double-clicked in the Designer, Visual Studio can create a Click event handler for it.



## 13. Message Boxes

A message box is a small window used to display a message to the user.

C# provides the `MessageBox.Show()` method for displaying messages.

Example:

```csharp
MessageBox.Show("Hello World");
```

When the code runs, a message box appears showing the message.



## 14. Label Controls

A Label control is used to display text on a form.

It can display fixed text or output produced by the program.

Some common Label properties are:

* `Text`
* `Name`
* `Font`
* `BorderStyle`
* `AutoSize`
* `TextAlign`

The `Text` property contains the text displayed by the Label.



## 15. IntelliSense

IntelliSense is a feature in Visual Studio that helps when writing code.

It provides suggestions for:

* Keywords
* Variables
* Methods
* Classes
* Properties

It can make writing code easier because Visual Studio shows possible code elements while typing.



## 16. PictureBox Controls

A PictureBox control is used to display an image on a form.

Some common PictureBox properties are:

* `Image` = specifies the image.
* `SizeMode` = controls how the image is displayed.
* `Visible` = determines whether the PictureBox is visible.

A PictureBox can also respond to events such as a mouse click.



## 17. Sequential Execution of Statements

C# statements normally execute in the order in which they appear in a method.

For example:

```csharp
cardBackPictureBox.Visible = true;
cardFacePictureBox.Visible = false;
```

The first statement runs before the second statement.

The order of statements is important because putting statements in the wrong order can produce an incorrect result.



## 18. Comments

Comments are notes written in source code to explain parts of the program.

A single-line comment starts with `//`.

Example:

```csharp
// Close the form.
this.Close();
```

A block comment can be used for multiple lines:

```csharp
/*
   This is a block comment.
   It can contain multiple lines.
*/
```

Comments are ignored when the program runs.



## 19. Blank Lines and Indentation

Blank lines and indentation make source code easier to read.

For example, code inside a method is normally indented so that the structure of the program is clear.

Good formatting does not change what the program does, but it makes the code easier for programmers to understand.

---

## 20. Closing a Form

The following statement can be used to close the current form:

```csharp
this.Close();
```

Another statement is:

```csharp
Application.Exit();
```

`this.Close()` closes the current form, while `Application.Exit()` exits the application.


## 21. Syntax Errors

A syntax error happens when the code does not follow the rules of the C# language.

Visual Studio can identify many syntax errors while writing code. An error is usually shown with a red jagged underline.

For example, if a method name or statement is written incorrectly, Visual Studio can show an error before the program is executed.

Syntax errors need to be fixed before the application can compile and run correctly.



## Conclusion

Chapter 1 introduced the basic ideas needed to start working with Visual C# and Windows Forms. I learned about objects, controls, forms, properties, Visual Studio, C# code, events, message boxes, labels, PictureBox controls, comments, and syntax errors.

These concepts are important because they are the foundation for creating Windows Forms applications in C#.