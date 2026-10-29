# Week 1 - Chapter One Screenshots

This README explains the C# code shown in each screenshot from Chapter One.

## Screenshot 01 - Closing the Form

### Code

```csharp
// close the form
this.Close();
````

### Code Explanation

```csharp
// close the form
```

This is a comment. It explains what the code below does. Comments are used to make the code easier to understand, and they do not affect the execution of the program.

```csharp
this.Close();
```

* `this` refers to the current form.
* `Close()` is a method used to close the current form.
* `;` marks the end of the statement.

When this code is executed, the current form is closed.

### Screenshot

![Closing the Form](screenshot-01.png)

---

## Screenshot 02 - Hiding the PictureBox

### Code

```csharp
// show the picture box
studentpicturebox.Visible = false;
```

### Code Explanation

```csharp
// show the picture box
```

This is a comment that describes the purpose of the code. In this example, the comment says "show the picture box", but the actual code sets the PictureBox to invisible.

```csharp
studentpicturebox.Visible = false;
```

* `studentpicturebox` is the name of the PictureBox control.
* `Visible` is a property that controls whether the control can be seen.
* `=` assigns a value to the property.
* `false` means that the PictureBox will not be visible.
* `;` marks the end of the statement.

When this code runs, the `studentpicturebox` is hidden from the form.

### Screenshot

![Hiding the PictureBox](screenshot-02.png)

---

## Screenshot 03 - Changing the Label Text

### Code

```csharp
// change the text of the label to jamhuriya university
lblanswer.Text = "Jamhuriyo university";
```

### Code Explanation

```csharp
// change the text of the label to jamhuriya university
```

This is a comment. It explains that the code is going to change the text displayed by the Label.

```csharp
lblanswer.Text = "Jamhuriyo university";
```

* `lblanswer` is the name of the Label control.
* `Text` is the property that contains the text displayed by the Label.
* `=` assigns a new value to the `Text` property.
* `"Jamhuriyo university"` is the text that will be displayed.
* `;` marks the end of the statement.

When the code is executed, the text displayed by `lblanswer` changes to `Jamhuriyo university`.

### Screenshot

![Changing the Label Text](screenshot-03.png)

---

## Screenshot 04 - Displaying Hello World

### Code

```csharp
// print hello world
MessageBox.Show("hello world");
```

### Code Explanation

```csharp
// print hello world
```

This is a comment that describes what the code is going to do.

```csharp
MessageBox.Show("hello world");
```

* `MessageBox` is used to display a message box to the user.
* `Show()` is the method used to display the message.
* `"hello world"` is the text that will appear inside the message box.
* `;` marks the end of the statement.

When this code is executed, a message box appears on the screen with the message `hello world`.

### Screenshot

![Hello World Message](screenshot-04.png)

---

## Conclusion

These screenshots show some basic C# code used in a Windows Forms application. They demonstrate how to close a form, change the visibility of a PictureBox, change the text of a Label, and display a message using a MessageBox.

```
```
