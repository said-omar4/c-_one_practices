# Week 4 – Chapter 4: Loops

## Introduction

In this week, I learned about loops in C#. Loops are used to execute a statement or a group of statements repeatedly while a condition is true. They help reduce repeated code and make programs easier to write.

## 1. The while Loop

The `while` loop repeats a block of code as long as its Boolean condition is true.

**Example:**

```csharp
int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    count++;
}
```

In this example:
- `count` is initialized with 0.
- The condition checks whether `count` is less than 5.
- The message is displayed while the condition is true.
- `count++` increases the value by 1 after each iteration.

### Pretest Loop

The `while` loop is a pretest loop because it checks the condition before executing the loop body.

If the condition is false at the beginning, the loop will not execute.

### Infinite Loop

An infinite loop happens when the loop condition never becomes false. For example, forgetting to increase the counter variable can cause a `while` loop to continue running without stopping.

## 2. The Increment (++) and Decrement (--) Operators

C# provides two operators for increasing and decreasing the value of a variable.

**Increment (`++`)**

Increases a variable by 1.

```csharp
count++;
```

Other ways to increase a variable:

```csharp
count += 1;
count = count + 1;
```

**Decrement (`--`)**

Decreases a variable by 1.

```csharp
count--;
```

Other ways to decrease a variable:

```csharp
count -= 1;
count = count - 1;
```

### Prefix and Postfix

- **Postfix:** The operator is placed after the variable, such as `count++`.
- **Prefix:** The operator is placed before the variable, such as `++count`.

The difference is that postfix uses the old value before changing it, while prefix changes the value first and then uses it.

## 3. The for Loop

The `for` loop is used when we know how many times we want a block of code to repeat. It uses three expressions:

1. Initialization – sets the starting value of the counter.
2. Test – checks whether the condition is true.
3. Update – increases or decreases the counter.

**Example:**

```csharp
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

In this example, the loop displays the message five times.

We can also increase the counter by 10 or count backward.

**Counting by 10:**

```csharp
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}
```

**Counting backward:**

```csharp
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```

The `for` loop is also a pretest loop because it checks the condition before each iteration.

## 4. The do-while Loop

The `do-while` loop executes its statements first and checks the condition afterward.

**Example:**

```csharp
int number = 1;

do
{
    MessageBox.Show(number.ToString());
}
while (number < 0);
```

In this example, the message box will appear once even though the condition is false because the loop executes before checking the condition.

The main difference is:

- `while` checks the condition before executing.
- `do-while` checks the condition after executing.

## Conclusion

In this week, I learned how to use different types of loops in C#. I practiced repeating statements with `while`, `for`, and `do-while`. I also learned how to use increment and decrement operators to control loop counters. These concepts help me write programs that repeat tasks without writing the same code many times.