Waa kan dukumentigaaga cusub ee la midabka ah qaabkii uu ahaa Cutkii 1aad (Chapter 1), oo ay ku jiraan tusaalooyinka iyo sawirada aad soo dirtay:

---

# Discourse Chapter 2

## Overview

This practice demonstrates how to:

* Declare and use different data types (strings and integers)


* Parse numeric values from text box controls using `int.Parse()`

* Combine multiple string and numeric values with custom separators


* Clear form controls and close windows programmatically



---

## 1. Creating Variables and Handling Inputs

In this step, string and integer variables are declared to capture and store user input from various text boxes. For numeric inputs, the `int.Parse()` method is used to convert text values into integers.

* `day_of_week` and `name_of_month` store text information.


* `numeric_date` and `year` store parsed integer values.


* `fullDate` stores the complete combined string.



The following screenshots show how variables are declared and assigned initial values:

![Creating Variables](Screenshot 2026-09-23 232246.png)
![Student Inputs](Screenshot 2026-09-23 235727.png)

## 2. Concatenating Multiple Values

In this step, multiple variables are combined using the `+` operator along with formatting characters like `" / "` or `" : "` so that the final output is structured clearly.

The result is stored in a combined string variable (such as `fullDate` or student record strings).

The following screenshot shows the string concatenation process:

![String Concatenation](Screenshot 2026-09-23 232254.png)

## 3. Displaying Output, Clearing, and Closing

After the values are combined, the final result is displayed in a Label control using its `.Text` property. Additional features such as clearing textboxes (`.Clear()` or `""`) and closing the form (`this.Close()`) are also implemented.

The following screenshots show how the output is displayed and how controls are reset:

![Display Output](Screenshot 2026-09-23 232257.png)
![Clearing and Closing](Screenshot 2026-09-23 232303.png)