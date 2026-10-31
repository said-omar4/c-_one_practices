# Week 5 – Chapter 4: Files and Random Numbers

## Introduction

In this week, I continued studying Chapter 4. I learned how to save and read data from text files, use file dialog controls, generate random numbers, and work with the Form Load event in Windows Forms.

## 1. Using Files for Data Storage

Files allow a program to save data so that it can be used later.

There are three main steps when working with files:

1. Open the file – create a connection between the file and the program.
2. Process the file – read data from it or write data to it.
3. Close the file – disconnect the file from the program.

### Types of Files

There are two general types of files:

- **Text File:** Contains data encoded as text, which can be viewed using a text editor.
- **Binary File:** Contains data that has not been converted into text and cannot normally be viewed using a text editor.

In this chapter, I worked with text files.

### StreamWriter

`StreamWriter` is used to write data into a text file.

**Example:**

```csharp
StreamWriter outputFile;

outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");

outputFile.Close();
```

In this example:
- `StreamWriter` creates a variable for writing data.
- `File.CreateText()` creates the text file.
- `WriteLine()` writes data into the file and moves to a new line.
- `Close()` closes the file connection.

### Write and WriteLine Methods

- `WriteLine()` writes data and adds a new line.
- `Write()` writes data without adding a new line.

### CreateText and AppendText

There are two important methods used to create or add data to a text file.

**File.CreateText()**

Creates a new text file. If the file already exists, its previous contents are erased.

**File.AppendText()**

Adds new data to an existing file without erasing its previous contents.

**Example:**

```csharp
StreamWriter outputFile;

outputFile = File.AppendText("Names.txt");

outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");

outputFile.Close();
```

### StreamReader

`StreamReader` is used to read data from a text file.

**Example:**

```csharp
StreamReader inputFile;

inputFile = File.OpenText("students.txt");
```

Some methods used when reading files include:

- `ReadLine()` – reads one line of text.
- `Read()` – reads the next character or characters.
- `ReadToEnd()` – reads the remaining content of the file.
- `Close()` – closes the file connection.

### Reading a File with a Loop

The `EndOfStream` property checks whether the end of a file has been reached.

**Example:**

```csharp
while (!inputFile.EndOfStream)
{
    // Read data from the file
}
```

This loop continues reading while there is still data available in the file.

## 2. OpenFileDialog and SaveFileDialog Controls

These controls allow an application to display standard Windows dialog boxes for opening and saving files.

They are invisible controls, meaning they do not appear directly on the form like Buttons, Labels, and TextBoxes. They appear in the component tray in the Designer.

### OpenFileDialog

`OpenFileDialog` displays a standard Windows Open dialog box. It allows the user to select a file.

**Example:**

```csharp
openFileDialog.ShowDialog();
```

### DialogResult

The `ShowDialog()` method returns a `DialogResult` value that tells us which button the user selected.

- `DialogResult.OK` – the user selected Open.
- `DialogResult.Cancel` – the user selected Cancel.

**Example:**

```csharp
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog.FileName);
}
```

### Filename and InitialDirectory Properties

- `FileName` stores the selected file path and filename.
- `InitialDirectory` specifies the directory that appears first when the dialog opens.

**Example:**

```csharp
openFileDialog.InitialDirectory = @"C:\Data";
```

### SaveFileDialog

`SaveFileDialog` displays a standard Windows Save As dialog box. It allows the user to select where to save a file.

**Example:**

```csharp
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    outputFile = File.CreateText(saveFileDialog.FileName);
}
```

## 3. Random Numbers

C# provides the `Random` class to generate random numbers.

First, we create a Random object:

```csharp
Random rand = new Random();
```

There are two commonly used methods:

**Next()**

Generates a random integer.

```csharp
int number1 = rand.Next();
```

**NextDouble()**

Generates a random floating-point number between 0.0 and 1.0.

```csharp
double number2 = rand.NextDouble();
```

### Generating Random Numbers Within a Range

The `Next()` method can also generate a random number from zero up to a specified maximum, excluding that maximum.

**Example:**

```csharp
int number = rand.Next(100);
```

This example generates a random integer from 0 to 99.

## 4. The Load Event

The Load event occurs when a form is loaded into memory as the application starts.

To create a Load event handler, we can double-click the form in the Windows Forms Designer.

**Example:**

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
```

Any code written inside the `Form1_Load` method executes when the form is launched.

## Conclusion

In this week, I learned how to work with text files using `StreamWriter` and `StreamReader`. I also practiced creating and appending files, reading file contents, using OpenFileDialog and SaveFileDialog, generating random numbers, and writing code that executes when a form loads.