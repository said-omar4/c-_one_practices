# Week 2 = Chapter 2: Processing Data

## Introduction

In this chapter, I learned how to work with data in a C# Windows Forms application. The main topics covered are TextBox input, variables, data types, calculations, type conversion, formatting numbers, exception handling, and named constants.



## 1. Reading Input with TextBox Controls

A TextBox control allows the user to enter information using the keyboard.

The value entered into a TextBox can be accessed through its `Text` property.

Example:

```csharp
string name = nameTextBox.Text;
```

The value from a TextBox is stored as a string.

A TextBox can also be cleared using:

```csharp
nameTextBox.Clear();
```

---

## 2. Variables

A variable is a storage location in memory that is used to store a value.

A variable has a data type and a name.

Example:

```csharp
string name;
int age;
```

A variable can also be declared and initialized at the same time:

```csharp
string name = "Ahmed";
int age = 20;
```

---

## 3. Data Types

A data type determines what kind of value a variable can store.

Some common C# data types are:

* `string` = used for text
* `int` = used for whole numbers
* `double` = used for numbers with decimal values
* `decimal` = used for decimal numbers, especially when more precision is needed

Example:

```csharp
string name = "Ahmed";
int age = 20;
double temperature = 36.5;
decimal price = 25.50m;
```

---

## 4. Variable Names

Variables should have meaningful names so that the code is easy to understand.

Some rules for variable names are:

* The first character must be a letter or underscore.
* Spaces are not allowed.
* Reserved C# keywords cannot be used as variable names.

Examples:

```csharp
string firstName;
int studentAge;
double totalAmount;
```

---

## 5. String Variables

A string variable stores text.

Example:

```csharp
string firstName = "Ahmed";
string university = "Jamhuriya University";
```

A string can contain letters, numbers, spaces, and other characters.

---

## 6. String Concatenation

String concatenation means joining two or more strings together.

The `+` operator can be used to join strings.

Example:

```csharp
string firstName = "Ahmed";
string lastName = "Ali";

string fullName = firstName + " " + lastName;
```

The result will be:

```text
Ahmed Ali
```

A string can also be combined with a number:

```csharp
int age = 20;

string message = "Age: " + age;
```

---

## 7. Local Variables

A local variable is a variable declared inside a method.

It can only be used within the part of the program where it is declared.

Example:

```csharp
private void button1_Click(object sender, EventArgs e)
{
    int age = 20;

    MessageBox.Show(age.ToString());
}
```

The variable `age` is a local variable because it is declared inside the method.

---

## 8. Initializing Variables

Initializing a variable means giving it an initial value.

Example:

```csharp
int age = 20;
```

Here, `age` is declared as an `int` and its initial value is `20`.

A local variable should be assigned a value before it is used.

---

## 9. Numeric Data Types

C# has several data types for storing numbers.

### int

The `int` data type is used for whole numbers.

```csharp
int students = 30;
```

### double

The `double` data type is used for numbers that can contain decimal values.

```csharp
double temperature = 36.5;
```

### decimal

The `decimal` data type is used for decimal numbers and is useful when more precision is required.

```csharp
decimal price = 25.50m;
```

---

## 10. Numeric Literals

A numeric literal is a number written directly in the program.

Examples:

```csharp
int age = 20;
double temperature = 36.5;
decimal price = 25.50m;
```

The `m` after `25.50` tells C# that the value is a decimal literal.

---

## 11. Type Casting

Type casting is the process of converting a value from one data type to another.

The target data type is written in parentheses.

Example:

```csharp
decimal money = 100.75m;
int value = (int)money;
```

The decimal part is removed when the value is converted to an integer.

Another example:

```csharp
int number = 10;
double result = (double)number;
```

---

## 12. The var Keyword

The `var` keyword allows C# to determine the data type automatically from the value assigned to the variable.

Example:

```csharp
var name = "Ahmed";
var age = 20;
var price = 25.50m;
```

In these examples, C# determines the type from the assigned value.

A variable declared using `var` must be initialized when it is declared.

---

## 13. Arithmetic Operators

C# provides arithmetic operators for performing calculations.

| Operator | Meaning        |
| -------- | -------------- |
| `+`      | Addition       |
| `-`      | Subtraction    |
| `*`      | Multiplication |
| `/`      | Division       |
| `%`      | Remainder      |

Example:

```csharp
int x = 10;
int y = 5;

int sum = x + y;
int difference = x - y;
int product = x * y;
int division = x / y;
```

Parentheses can be used to control the order of calculations.

Example:

```csharp
int result = (10 + 5) * 2;
```

---

## 14. Integer Division

When two integers are divided, the result is an integer.

Example:

```csharp
int x = 7;
int y = 3;

int result = x / y;
```

The result is:

```text
2
```

The decimal part is not included because both values are integers.

---

## 15. Reading Numeric Input

Data entered into a TextBox is stored as a string.

If the user enters a number, the program needs to convert the string into a numeric value before performing calculations.

For example:

```csharp
int age = int.Parse(ageTextBox.Text);
```

For decimal values:

```csharp
double temperature = double.Parse(temperatureTextBox.Text);
```

For decimal data:

```csharp
decimal price = decimal.Parse(priceTextBox.Text);
```

---

## 16. The Parse Method

The `Parse` method converts a string into a numeric data type.

Some commonly used Parse methods are:

```csharp
int.Parse()
double.Parse()
decimal.Parse()
```

Example:

```csharp
int number = int.Parse(numberTextBox.Text);
```

The text entered by the user is converted into an integer.

---

## 17. Displaying Numeric Values

The `Text` property of a Label or TextBox expects a string.

The `ToString()` method can be used to convert a numeric value into a string.

Example:

```csharp
int number = 100;

resultLabel.Text = number.ToString();
```

A number can also be combined with text:

```csharp
int age = 20;

resultLabel.Text = "Your age is " + age;
```

---

## 18. Formatting Numbers

The `ToString()` method can also be used to control how a number is displayed.

For example:

```csharp
double number = 12345.678;

string result = number.ToString("N2");
```

`N2` formats the number with two decimal places and a number separator.

Other formatting options can be used depending on how the value needs to be displayed.

---

## 19. Exception Handling

An exception is an error that occurs while the program is running.

For example, an exception can happen when a user enters invalid data where the program expects a number.

Exception handling allows the program to respond to these errors instead of stopping unexpectedly.

---

## 20. try-catch

The `try-catch` statement is used to handle exceptions.

The code that may produce an error is placed inside the `try` block.

The `catch` block handles the exception.

Example:

```csharp
try
{
    int age = int.Parse(ageTextBox.Text);
}
catch
{
    MessageBox.Show("Please enter a valid number.");
}
```

If the user enters invalid data, the `catch` block can display a message.

---

## 21. Exception Message

The exception object contains information about the error.

The `Message` property can be used to display the error message.

Example:

```csharp
try
{
    int number = int.Parse(numberTextBox.Text);
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

The program displays the message provided by the exception.

---

## 22. Named Constants

A named constant is a value that cannot be changed while the program is running.

The `const` keyword is used to create a constant.

Example:

```csharp
const double INTEREST_RATE = 0.05;
```

Once a constant has been assigned a value, that value cannot be changed.

Constants are useful when a value should remain the same throughout the program.

Another example is:

```csharp
const decimal TAX_RATE = 0.15m;
```

Using constants can make code easier to understand because the name describes what the value represents.

---

## Conclusion

In this part of Chapter 2, I learned how to receive input from TextBoxes, store information in variables, use different data types, perform calculations, convert values, format numbers, handle exceptions, and create named constants.

These concepts are important for processing data in C# Windows Forms applications.
