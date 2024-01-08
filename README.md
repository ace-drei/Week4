# Week4

1.	Write a Calculator class which contains a static method which divides 2 floating point numbers and returns the answer. If the second number is 0 throw an ArgumentException since division by 0 is undefined. 

Use a test class to call the method. Pass in 2 numbers which have been input by the user. The test class should validate the inputs by using Double.Parse() to convert the inputs to floating point numbers catching FormatException or OverflowExceptions if the inputs are invalid. If valid then call the static method to divide the numbers and display the result. Catch any exceptions that may arise.

2.	Implement a class which represents a set of results for CAs for a student in a particular module i.e. ModuleCAResults. The class should contain auto-implemented properties for the module name, and the number of credits it is worth, and the student name. It should contain a collection of results (scores) for CAs in the module in order i.e. CA1 results in the first position in the collection, CA2 in the second etc. Override ToString to return all module details and CA results.

Implement an indexer for the class which allows retrieval of a specific CA result, and setting or a result i.e. a read/write indexer property. If the CA number is invalid then throw an exception. No gaps should be allowed in the result collection e.g. a result for CA3 should not be entered before results for CA1 and CA2 for instance. 

Test in a separate class using a try/catch block.
