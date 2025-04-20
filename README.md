# InterfaceExampleApp

A simple C# Console Application demonstrating:

- ✅ Creation of a custom interface (`IQuittable`)
- ✅ Implementation of the interface in a class (`Employee`)
- ✅ Use of **polymorphism** to treat a class instance as an interface type
- ✅ Calling interface-defined methods through interface references

---

## 🧠 What This App Does

This app simulates an employee quitting a job using interface-based logic.

- We define an interface called `IQuittable` that includes a `Quit()` method.
- The `Employee` class implements this interface and defines what happens when `Quit()` is called.
- We use **polymorphism** to create an object of type `IQuittable` and assign an `Employee` object to it.
- When we call `Quit()` on the interface reference, it runs the `Employee` implementation.

---

## 📂 Project Structure

