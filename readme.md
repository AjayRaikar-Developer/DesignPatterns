<h1> Design Pattern </h1>
<p> Design patterns in software refer to reusable solutions to common problems that arise during software development. They are tried and tested solutions to specific design problems and can help developers save time by providing proven solutions to commonly encountered issues.

This patterns were formed by 4 engineers named: Erich Gamma, Richard Helm, Ralph Johnson & John Vlissides also this group was famously know as <b>Gang of 4</b>
</p>


# Types of Design Patterns

## Creational Pattern

1. Abstract Factory
2. Builder
3. Factory Method
4. Prototype
5. Singleton

## Structural Pattern

1. Adapter
2. Bridge
3. Composite
4. Decorator
5. Facade
6. Flyweight
7. Proxy

## Behavioral Pattern

1. Chain of Responsibility
2. Command
3. Interpreter
4. Iterator
5. Mediator
6. Memento
7. Observer
8. State
9. Strategy
10.  Template Method
11. Visitor


## Creational Pattern
### 1. Abstract Factory
> Definition :The Abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes

<b>Simple Definition: </b> 
The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes

Abstract factory is a super factory that creates other factories

<b><u> Real World Examples: </u></b>
- Furniture Manufacturing: Creating furniture with different styles (e.g., modern, traditional, Scandinavian) and materials (e.g., wood, metal, plastic) using the Abstract Factory pattern.

- Operating System Themes: Developing themes for different operating systems (e.g., Windows, macOS, Linux) using the Abstract Factory pattern.

- GUI Theme Customization: Implementing a GUI library with the ability to customize themes (e.g., dark mode, light mode) using the Abstract Factory pattern.

- Payment Gateway Integration: Integrating multiple payment gateways (e.g., PayPal, Stripe, Square) into an e-commerce platform using the Abstract Factory pattern.

- Database Abstraction Layer: Creating a database abstraction layer that can support multiple database systems (e.g., MySQL, PostgreSQL, SQLite) using the Abstract Factory pattern.

### 2. Builder
> Definition : "Separate the construction of a complex object from its representation so that the same construction process can create different representations"

<b>Simple Definition: </b> 
Builder Pattern solves the situation of increasing constructor parameters and constructors of a given class by providing a step by step initialisation of Parameters. After step by step initialisation, it returns the resulting constructed Object at once.

<b><u> Real World Examples: </u></b>
- House Construction: Using the Builder pattern to build houses with various configurations, such as the number of bedrooms, bathrooms, and other amenities.

- Email Composition: Using the Builder pattern to construct complex emails with various elements like attachments, inline images, and HTML formatting.

- Report Generation: Implementing the Builder pattern to create customized reports with specific sections, charts, and data.

- Course Enrollment System: Applying the Builder pattern to construct course enrollment forms with various fields and options.

- Travel Package Creation: Using the Builder pattern to create custom travel packages with specific destinations, activities, and accommodations.

### 3. Factory Method
> Definition : Define an interface for creating an object, but let sub-classes decide which class to instantiate. The Factory method lets a class defer instantiation it uses to sub-classes

<b>Simple Definition: </b> 
Factory pattern creates object without exposing the creation logic to the client and refer to newly created object using a common interface

<b><u> Real World Examples: </u></b>
- Pizza Ordering System
- Vehicle Manufacturing
- Social Media Posting
- Document Conversion Library

### 4. Prototype
> Definition : Prototype Design Pattern Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype

<b>Simple Definition: </b> 
To simplify, instead of creating object from scratch every time, you can make copies of an original instance and modify it as required.

Prototype is unique among the other creational patterns as it doesn't require a class but only an end object.

<b><u> Real World Examples: </u></b>
- Cloning in a Chess Game: Using the Prototype pattern to clone chess pieces, such as pawns, rooks, knights, etc., to initialize the board and facilitate moves.

- Document Cloning in Word Processors: Allowing users to clone existing documents to create new ones based on a template, using the Prototype pattern.

- GUI Widget Copying: Copying and reusing GUI widgets (e.g., buttons, checkboxes) in a graphical user interface by using the Prototype pattern.

- Drawing Tool Cloning: Cloning shapes and drawings in a graphics editing application to reuse and modify elements efficiently, leveraging the Prototype pattern.

- Object Copying in a Game Level Editor: Using the Prototype pattern to duplicate objects like trees, rocks, or buildings in a level editor for video game development.

- User Account Cloning: Allowing administrators to clone user accounts in an administrative system using the Prototype pattern.

### 5. Singleton 
> Definition : Singleton design pattern is used when we need to ensure that only one object of a particular class is Instantiated. That single instance created is responsible to coordinate actions across the application.

<b><u> Real World Examples: </u></b>
- Logging
- Managing a connection or a pool of connections to database
- Printer spooling
- File 
- Configuration 
- Cache
- Session based shopping cart 