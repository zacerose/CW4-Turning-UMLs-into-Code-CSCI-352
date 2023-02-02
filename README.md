# CW 4: Turning UMLs into Code
Name: Zachary Rose  
Date: 2/2/2023  
Class: CSCI 352

Two different creational design pattern UMLs implemented in code. More specific details in related sections.

## Required Files
* CW4-Turning_UMLs_into_Code-Abstract_Pattern-CSCI352/ --> directory containing the Abstract Factory Pattern implementation
* CW4-Turning_UMLs_into_Code-Factory_Pattern-CSCI352/ --> directory containing the Factory Pattern implementation
* CW4-Turning_UMLs_into_Code-CSCI352.sln --> Visual Studio solution file, contains both projects

## Program Usage
To launch the program, clone the repository in Visual Studio. Then, select the desired project in the drop down, and finally compile/run by pressing "Start".

# Abstract Factory Pattern
* Contains three phone manufacterers (HTC, Samsung, Nokia) and each manufacterer has an associated PhoneFactory and
two associated phone models (one smart, one dumb). The factory can create and return the associated smart and dumb models.
* A phone type checker can be constructed with a particular manufacterer, which will in turn allow printing both
associated phone models.
* Main constructs a phone type checker of each available manufacterer and prints out each phone model.
## Design Decisions
* I seperated the concrete class definitions all into one seperate file.
  - I wanted to keep the bulky and not very interesting phone model definitions out of the way, but they weren't
  unique enough to give every single class their own individual file.
  - I left the interfaces in the main file as a sort of declaration to what's contained in the namespace.
* I added some extra print statements such as smart/dumb and manufacterer information for readability in the console output
# Factory Pattern
* Contains four shape types (line, circle, rectangle, triangle) and line, circle, and rectangle have associated 
geometric shapes that can be "drawn." 
* A shape factory can be given a type, and will return the associated geometric shape, given that it is implemented.
* Main attempts to draw each of the shape types, including the purposefully non-implemented triangle.
## Design Decisions
* Due to the simplicity of the classes, I kept everything in one file.
* Used a foreach to iterate over every element in the ShapeType enum to adhere to DRY and ETC principles. 
