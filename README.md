# DependencyInjection

Definition of Dependency Injection C#

If you take a closer look at Dependency Injection (DI), it is a software design pattern which enables the development
of loosely coupled code. Through DI, you can decrease tight coupling between software components.
It is also known as Inversion-of-Control, which makes unit testing convenient.

It is critical to take a step back to the basics of designing an object-oriented application where a
major facet of design is “loose coupling.” This means that objects only have as many dependencies as needed to
do their jobs–and, the number of dependencies should be limited.

In addition, an object’s dependencies should be on interfaces as opposed to “concrete” objects.
What is a concrete object? This is any object created with the keyword “new.” Through loose coupling,
you enable easier maintainability and greater reusability. Moreover, you can feature “mock” objects designed to take
the place of costly services such as a socket-communicator. There are three types of DIs:

-Constructor Injection
-Setter Injection
-Method Injection

Since DI is utilized to make code maintainable, it uses a pattern with a builder object to initialize objects
and give the required dependencies to the object. As you can see, you can now “inject” a dependency from outside the class.
