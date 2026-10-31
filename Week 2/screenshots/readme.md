# Week 2 - Chapter Two Screenshots

This README explains the C# code shown in each screenshot from Chapter two.


## Screenshot 01 - Parse Methods

### Code

```csharp
// Parse methods to convert string to numeric data
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
````

### Code Explanation

```csharp
// Parse methods to convert string to numeric data
```

This is a comment that explains the purpose of the code below. It tells us
that the `Parse` methods are being used to convert string input into numeric data.

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
```

* `int` specifies that `hoursWorked` is an integer variable.
* `hoursWorked` is the name of the variable.
* `=` assigns a value to the variable.
* `hoursWorkedTextBox.Text` gets the text entered by the user in the TextBox.
* `int.Parse()` converts the text into an integer.
* The converted value is stored in `hoursWorked`.

```csharp
double temperature = double.Parse(temperatureTextBox.Text);
```

* `double` specifies that `temperature` is a double variable.
* `temperature` is the variable name.
* `temperatureTextBox.Text` gets the value entered in the TextBox.
* `double.Parse()` converts the string into a double value.
* The converted value is stored in `temperature`.

The `Parse` method is useful when numeric data is entered through a TextBox,
because the TextBox value is initially treated as a string.

### Screenshot

![Parse Methods](screenshot-01.png)

---

## Screenshot 02 - Implicit String Conversion with the + Operator

### Code

```csharp
// implicit string conversion with the + operator
int idNumber = 1044;
string output = "Your ID number is " + idNumber;
```

### Code Explanation

```csharp
// implicit string conversion with the + operator
```

This is a comment explaining that the example uses the `+` operator to combine
a string with an integer.

```csharp
int idNumber = 1044;
```

* `int` declares an integer variable.
* `idNumber` is the name of the variable.
* `1044` is the value assigned to the variable.

```csharp
string output = "Your ID number is " + idNumber;
```

* `string` declares a string variable.
* `output` is the name of the variable.
* `"Your ID number is "` is a string value.
* `+` is used to join the string with the integer value.
* `idNumber` contains the value `1044`.
* The complete result is stored in the `output` variable.

The result stored in `output` will be:

```text
Your ID number is 1044
```

C# automatically converts the numeric value to a string when it is combined
with a string using the `+` operator.

### Screenshot

![Implicit String Conversion](screenshot-02.png)

---

## Screenshot 03 - ToString Method

### Code

```csharp
// ToString
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;
MessageBox.Show(myNumber.ToString());
```

### Code Explanation

```csharp
// ToString
```

This is a comment that identifies the use of the `ToString()` method.

```csharp
decimal grossPay = 1550.0m;
```

* `decimal` declares a decimal variable.
* `grossPay` is the variable name.
* `1550.0m` is the decimal value assigned to the variable.
* The `m` indicates that the value is a decimal literal.

```csharp
grossPayLabel.Text = grossPay.ToString();
```

* `grossPayLabel` is the name of the Label control.
* `Text` is the property used to display text in the Label.
* `grossPay.ToString()` converts the decimal value into a string.
* The converted value is assigned to the Label's `Text` property.

```csharp
int myNumber = 123;
```

This creates an integer variable called `myNumber` and gives it the value `123`.

```csharp
MessageBox.Show(myNumber.ToString());
```

* `MessageBox` is used to display a message box.
* `Show()` displays the message.
* `myNumber.ToString()` converts the integer `123` into a string.
* The converted value is displayed in the message box.

The `ToString()` method is useful when a numeric value needs to be displayed
as text.

### Screenshot

![ToString Method](screenshot-03.png)

---

## Screenshot 04 - Cleaning the Label

### Code

```csharp
// cleaning the label
lbloutput.Text = "";
```

### Code Explanation

```csharp
// cleaning the label
```

This is a comment explaining that the code is used to clear the text displayed
by the Label.

```csharp
lbloutput.Text = "";
```

* `lbloutput` is the name of the Label control.
* `Text` is the property that contains the text displayed by the Label.
* `=` assigns a new value to the `Text` property.
* `""` is an empty string.
* `;` marks the end of the statement.

When this code runs, the Label becomes empty because its `Text` property is
set to an empty string.

### Screenshot

![Cleaning the Label](screenshot-04.png)

---

## Screenshot 05 - Cleaning the TextBoxes

### Code

```csharp
//cleaning the textbox
txtweek.Clear();
txtname.Clear();
txtmonth.Clear();
txtyear.Clear();
```

### Code Explanation

```csharp
//cleaning the textbox
```

This is a comment explaining that the code below is used to clear the TextBoxes.

```csharp
txtweek.Clear();
```

* `txtweek` is the name of the first TextBox.
* `Clear()` is a method used to remove the text from the TextBox.

```csharp
txtname.Clear();
```

This clears the text entered in the `txtname` TextBox.

```csharp
txtmonth.Clear();
```

This clears the text entered in the `txtmonth` TextBox.

```csharp
txtyear.Clear();
```

This clears the text entered in the `txtyear` TextBox.

The `Clear()` method removes the current text from a TextBox.

When these statements are executed, all four TextBoxes become empty.

### Screenshot

![Cleaning the TextBoxes](screenshot-05.png)

---

## Screenshot 06 - Output Using Label

### Code

```csharp
// stage 3: The Output using Label
lbloutput.Text = fullDate;
```

### Code Explanation

```csharp
// stage 3: The Output using Label
```

This is a comment showing that this is the third stage of the program,
where the final result is displayed using a Label.

```csharp
lbloutput.Text = fullDate;
```

* `lbloutput` is the name of the Label control.
* `Text` is the property used to display text in the Label.
* `=` assigns the value of `fullDate` to the Label.
* `fullDate` is the variable containing the final date value.

When this statement runs, the value stored in `fullDate` is displayed in
the `lbloutput` Label.

### Screenshot

![Output Using Label](screenshot-06.png)

---

## Screenshot 07 - Initial Values to Variables

### Code

```csharp
//initial values to variables
day_of_week = txtweek.Text;
name_of_month = txtname.Text;
numeric_date = int.Parse(txtmonth.Text);
year = int.Parse(txtyear.Text);
```

### Code Explanation

```csharp
//initial values to variables
```

This is a comment explaining that the values entered by the user are being
assigned to variables.

```csharp
day_of_week = txtweek.Text;
```

* `txtweek.Text` gets the text entered in the `txtweek` TextBox.
* The value is assigned to the `day_of_week` variable.

```csharp
name_of_month = txtname.Text;
```

* `txtname.Text` gets the text entered in the `txtname` TextBox.
* The value is assigned to the `name_of_month` variable.

```csharp
numeric_date = int.Parse(txtmonth.Text);
```

* `txtmonth.Text` gets the value entered in the TextBox.
* `int.Parse()` converts the string value into an integer.
* The converted value is stored in `numeric_date`.

```csharp
year = int.Parse(txtyear.Text);
```

* `txtyear.Text` gets the value entered in the year TextBox.
* `int.Parse()` converts the value from a string to an integer.
* The converted value is stored in the `year` variable.

This stage takes the values entered by the user and stores them in variables
so they can be processed by the program.

### Screenshot

![Initial Values to Variables](screenshot-07.png)

---

## Screenshot 08 - Creating Variables

### Code

```csharp
//stage 1: of input
// creating variables
string day_of_week;
string name_of_month;
int numeric_date;
int year;
string fullDate;
```

### Code Explanation

```csharp
//stage 1: of input
```

This is a comment showing that this code belongs to the first stage of the
input process.

```csharp
// creating variables
```

This comment explains that the code below is used to create variables.

```csharp
string day_of_week;
```

This declares a string variable called `day_of_week`. It can store text such
as a day of the week.

```csharp
string name_of_month;
```

This declares a string variable called `name_of_month`. It can store the name
of a month.

```csharp
int numeric_date;
```

This declares an integer variable called `numeric_date`. It is used for
whole-number date values.

```csharp
int year;
```

This declares an integer variable called `year`. It is used to store a year
as a whole number.

```csharp
string fullDate;
```

This declares a string variable called `fullDate`. It can later be used to
store the complete date as text.

The data type is written before each variable name to specify what kind of
data the variable will store.

### Screenshot

![Creating Variables](screenshot-08.png)


---

## Screenshot 09 - Exception Handling with try-catch

### Code

```csharp
try
{
    // declare variables 
    int age;
    double salary;
    string grade;

    // initializing variables with values from textboxes
    age = int.Parse(textBox3.Text);
    salary = double.Parse(textBox4.Text);
    grade = textBox5.Text;

    // displaying the values in the label using concatenation
    label2.Text = age + " " + salary + " " + grade;
}
catch (Exception X)
{
    // display default error message
    MessageBox.Show(X.Message);
}


Code Explanation
try
{

The try block contains the code that may cause an error while the program
is running. In this example, the program tries to read and convert values
entered by the user.

// declare variables 
int age;
double salary;
string grade;

These statements declare three variables:

age is an integer variable used to store a whole number.
salary is a double variable used to store a numeric value that can
contain decimals.
grade is a string variable used to store text.
age = int.Parse(textBox3.Text);

The Text property gets the value entered in textBox3.

int.Parse() converts the text into an integer and stores the result in
the age variable.

salary = double.Parse(textBox4.Text);

The Text property gets the value entered in textBox4.

double.Parse() converts the text into a double value and stores it in
the salary variable.

grade = textBox5.Text;

This gets the text entered in textBox5 and stores it directly in the
grade string variable.

label2.Text = age + " " + salary + " " + grade;

This statement displays the values in label2.

The + operator is used to join the values together. Spaces are also added
between the values so that they are displayed separately.

For example, if the user enters:

20
500.5
A

the Label will display:

20 500.5 A
Catch Block
catch (Exception X)
{

The catch block handles an exception if an error occurs inside the try
block.

Exception X stores information about the error in the variable X.

MessageBox.Show(X.Message);

X.Message contains the error message.

MessageBox.Show() displays that error message to the user.

For example, if the user enters text instead of a valid number for age,
int.Parse() can cause an exception. The catch block then displays the
error message instead of allowing the program to stop unexpectedly.