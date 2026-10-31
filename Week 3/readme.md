# Week 3 – Chapter 3: Making Decisions

## Introduction

In this chapter, I learned how to make decisions in C# programs. Decision structures allow a program to check conditions and choose what statements to execute. I also learned about logical operators, Boolean variables, input validation, RadioButtons, CheckBoxes, switch statements, and ListBox controls.

## 1. Decision Structures

A control structure controls the order in which statements execute in a program.

There are two important types of structures:

- **Sequence structure:** Statements execute in the order they appear.
- **Decision structure:** Statements execute depending on whether a condition is true or false.

Decision structures are also called selection structures.

## 2. The if Statement

The `if` statement executes a block of code only when a condition is true.

Example:

```csharp
if (sales > 50000)
{
    bonus = 500;
}
```

In this example, the bonus is set to 500 only if sales are greater than 50000.

### Relational Operators

Relational operators are used to compare two values.

| Operator | Meaning |
|---|---|
| `>` | Greater than |
| `<` | Less than |
| `>=` | Greater than or equal to |
| `<=` | Less than or equal to |
| `==` | Equal to |
| `!=` | Not equal to |

These operators produce a Boolean result, which is either `true` or `false`.

## 3. The if-else Statement

The `if-else` statement provides two possible paths. If the condition is true, the `if` block executes. Otherwise, the `else` block executes.

Example:

```csharp
if (age >= 18)
{
    MessageBox.Show("You are an adult.");
}
else
{
    MessageBox.Show("You are not an adult.");
}
```

This program checks the user's age and displays a different message depending on the result.

## 4. Nested Decision Structures

A nested decision structure is an `if` or `if-else` statement placed inside another decision structure. It is used when a program needs to check more than one condition.

Example:

```csharp
if (salary >= 30000)
{
    if (yearsOnJob >= 2)
    {
        MessageBox.Show("You qualify for the loan.");
    }
    else
    {
        MessageBox.Show("Minimum years at current job not met.");
    }
}
else
{
    MessageBox.Show("Minimum salary requirement not met.");
}
```

In this example, the program first checks the salary. If the salary meets the requirement, it checks the number of years the person has worked.

### The if-else-if Statement

The `if-else-if` statement is used when there are several conditions to check.

Example:

```csharp
if (mark >= 80)
{
    MessageBox.Show("Grade A");
}
else if (mark >= 70)
{
    MessageBox.Show("Grade B");
}
else if (mark >= 60)
{
    MessageBox.Show("Grade C");
}
else
{
    MessageBox.Show("Fail");
}
```

The conditions are checked from top to bottom. When a condition is true, its block executes, and the remaining conditions are skipped.

## 5. Logical Operators

Logical operators allow us to combine or reverse conditions.

There are three main logical operators in C#.

| Operator | Name | Meaning |
|---|---|---|
| `&&` | AND | Both conditions must be true. |
| `||` | OR | At least one condition must be true. |
| `!` | NOT | Reverses the Boolean value. |

### AND Operator

```csharp
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}
```

Both conditions must be true for the message to display.

### OR Operator

```csharp
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("The temperature is in the danger zone.");
}
```

The condition is true if either one or both conditions are true.

### NOT Operator

```csharp
if (!(temperature > 100))
{
    MessageBox.Show("The temperature is below the maximum.");
}
```

The NOT operator reverses the result of the condition inside the parentheses.

## 6. bool Variables and Flags

A `bool` variable stores only two values: `true` or `false`.

A flag is a variable used to indicate whether a particular condition exists in a program.

Example:

```csharp
bool isAvailable = true;

if (isAvailable)
{
    MessageBox.Show("The item is available.");
}
```

In this example, the Boolean variable indicates whether the item is available.

## 7. Comparing Strings

Strings can be compared using the `==` and `!=` operators. The `String.Compare()` method can also be used to compare strings.

### Using the == Operator

```csharp
if (name1 == name2)
{
    MessageBox.Show("The names are the same.");
}
```

This checks whether the two strings contain the same text.

### Using the != Operator

```csharp
if (name1 != "bob")
{
    MessageBox.Show("The name is not bob.");
}
```

This condition is true when `name1` is not equal to `"bob"`.

### Using String.Compare()

```csharp
if (String.Compare(name1, name2) == 0)
{
    MessageBox.Show("The names are the same.");
}
```

The `String.Compare()` method returns zero when the strings compare as equal.

## 8. The TryParse Method

The `TryParse()` method is used to convert a string into a numeric value without throwing a data conversion exception when the input is invalid.

Some commonly used methods are:

- `int.TryParse()`
- `double.TryParse()`
- `decimal.TryParse()`

Example:

```csharp
int age;

if (int.TryParse(ageTextBox.Text, out age))
{
    MessageBox.Show("Valid number entered.");
}
else
{
    MessageBox.Show("Please enter a valid number.");
}
```

The method checks whether the text can be converted into an integer. If the conversion succeeds, it returns `true`; otherwise, it returns `false`.

The `out` keyword allows the converted value to be stored in the variable.

## 9. Input Validation

Input validation is the process of checking entered data to make sure it is acceptable before using it in a program.

`TryParse()` checks whether input can be converted to the required data type, but it does not guarantee that the value is reasonable.

For example, 999 is a valid integer, but it is not a reasonable number of working hours in one week.

### Example: Validating Working Hours

```csharp
if (hours > 0 && hours <= 168)
{
    MessageBox.Show("Valid working hours.");
}
else
{
    MessageBox.Show("Invalid working hours.");
}
```

### Example: Validating a Test Score

```csharp
if (testScore >= 0 && testScore <= 100)
{
    MessageBox.Show("Valid test score.");
}
else
{
    MessageBox.Show("Invalid test score.");
}
```

These examples check whether the values are within the allowed ranges.

## 10. RadioButtons and CheckBoxes

RadioButtons and CheckBoxes allow users to select options in a Windows Forms application.

### RadioButton Control

A RadioButton allows the user to select one option from a group of choices. Selecting another RadioButton in the same group automatically deselects the previous one.

Common properties include:

- `Text` – contains the text displayed beside the control.
- `Checked` – indicates whether the RadioButton is selected.

Example:

```csharp
if (choiceRadioButton.Checked)
{
    MessageBox.Show("The option is selected.");
}
else
{
    MessageBox.Show("The option is not selected.");
}
```

### CheckBox Control

A CheckBox is used when the user can select or deselect an option, such as a yes/no choice. Multiple CheckBoxes can be selected at the same time.

Common properties include:

- `Text` – contains the text displayed beside the CheckBox.
- `Checked` – indicates whether the CheckBox is selected.

Example:

```csharp
if (option1CheckBox.Checked)
{
    MessageBox.Show("The option is selected.");
}
else
{
    MessageBox.Show("The option is not selected.");
}
```

### CheckedChanged Event

The `CheckedChanged` event occurs when the `Checked` property of a RadioButton or CheckBox changes.

An event handler can be used to execute code when the selection changes.

## 11. The switch Statement

The `switch` statement is a decision structure that selects a path based on the value of an expression. It can be used as an alternative to an `if-else-if` statement when checking several possible values of the same expression.

Example:

```csharp
switch (dayNumber)
{
    case 1:
        MessageBox.Show("Monday");
        break;

    case 2:
        MessageBox.Show("Tuesday");
        break;

    case 3:
        MessageBox.Show("Wednesday");
        break;

    default:
        MessageBox.Show("Invalid day number.");
        break;
}
```

The `case` sections represent the possible values. The `break` statement ends the current case, while `default` runs when no case matches.

The `default` section is optional.

## 12. Introduction to ListBox Controls

A ListBox is a Windows Forms control that displays a list of items and allows the user to select an item.

Some important ListBox properties are:

- `Text` – contains the text of the currently selected item.
- `Items` – contains the items in the ListBox.
- `Items.Count` – returns the total number of items.
- `SelectedItem` – gets the currently selected item.
- `SelectedIndex` – gets the index of the selected item.

ListBox indexes start from zero. The first item has index `0`, the second item has index `1`, and so on. If no item is selected, `SelectedIndex` is `-1`.

### Adding Items to a ListBox

The `Items.Add()` method adds a new item to a ListBox.

Example:

```csharp
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");
```

This code adds three days to the list.

### Getting the Selected Item

The `SelectedItem` property gets the item selected by the user.

Example:

```csharp
if (fruitListBox.SelectedIndex != -1)
{
    string selectedFruit = fruitListBox.SelectedItem.ToString();
    MessageBox.Show(selectedFruit);
}
```

The condition checks whether an item has been selected before trying to get its value. This helps prevent an exception when no item is selected.

### Removing Items from a ListBox

The `Items.Remove()` method removes a specific item.

```csharp
daysListBox.Items.Remove("Tuesday");
```

The `Items.RemoveAt()` method removes an item using its index.

```csharp
daysListBox.Items.RemoveAt(2);
```

The `Items.Clear()` method removes all items from the ListBox.

```csharp
daysListBox.Items.Clear();
```

The index used with `RemoveAt()` must be valid. Otherwise, an exception can occur.

## Conclusion

In this chapter, I learned how to control the execution of a C# program using decision structures. I studied the `if`, `if-else`, nested `if`, and `switch` statements, as well as logical operators and Boolean variables.

I also learned how to compare strings, use `TryParse()` to handle invalid numeric input, validate data, and work with RadioButtons, CheckBoxes, and ListBox controls.

These concepts help me write programs that make decisions, check user input, and respond to different user selections.