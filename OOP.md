# OOP is the Foundation — are powerful programming tools/concepts but have their shortcomings
## using OOP give you methods to organized the code in the properly classes 

- clean code 
- defensive Coding 
- iterative Agile 
- API 
- Design Patterns
- Domain Driven Design 
- .NET apps

#### ______ OOP with C# 

<p> Object != Class </p>


# Class  - is defined in the code
- provides the definition of the object type 

```
public class Customer{                                        
    public int CustomerID { get; set; }      Properties       Members in the Class 
    public string  Email { get; set; }       Properties 
    public string Name {get; set; }          Properties 
    public bool Validate (){}               ->  function 
}
```

# Object - 
-  instances of the class
-  when the app terminates, the object is gone, any obj state is gone 
-  unless it was store in database ( but the class still exists )


```
var customer = new Customer();
customer.Name = "Chris";
customer.Validate();
```

- 'customer'        - Object varable
- 'customer.Name'   - use Object varable to get a set any of  Properties identified in the class
- 'customer.Validate()'  - use Object varable to call any of methods in the class 



# Business Object  == Class  (IBussinessObject )
- Customer class referred to as a business obj used this context 

``` same as class 
public class Customer{                                        
    public int CustomerID { get; set; }      Properties(data)      Members
    public string  Email { get; set; }       Properties(data)
    public string Name {get; set; }          Properties(data)
    public bool Validate (){}               ->  method function
}
```

# Entity

- calling each the things we want to create a class for (things is a little imprecise)
For example:  customer 


# OOP

- it is an approach to designing and building app that are:
- Flexible 
- Natural
- Well-crafted
- Testable

* by focusing on objects that interact cleanly with one another

- Identifying classes
- Separating responsibilities  ( decomposed into parts with minimal overlap )
- Establishing relationships ( betweek classes )
- Leveraging reuse ( classes )


#### ______  OOP with js 

# Encapsulation - create methods ( the best functions are those with NO parametrs )
- we can group related var and functions  together ( that operate on them into obj )
- reduce complexity + increase reusability 

```
    let baseSalary = 3000;
    let rate = 20;
    let overtime = 20;

    function getWage(baseSalary, rate, overtime){
        return baseSalary + (rate * overtime);
    }
```

OOP gives 

```
    let employee ={ 
        baseSalary = 3000,
        rate = 20,
        overtime = 20,
        
        getWage: function(baseSalary, rate, overtime){
            return this.baseSalary + (this.rate * this.overtime);
        }
    } 
    employee.getWage();
```

- this fun has NO PARAMS 
- they are properties of this obj 
- they are part of one unit 
 

* the best functions are those with NO parametrs
  
# Abstractions
- we hide the details and the complexity and show only the essentials 
- reduce complexity + isolate impact of changes 

- First :  simpler interfase - we can make intarface of those obj simpler using an understanding an object with a few properties and methods is easier than an object with several properties and methods 
- Second : Reduce the Impact of Change  - inner, methods user to chacge will change in the rest of the impact(ref) 


 # Inheritance
- mechanism that allows you to eliminate redundant code 
- inheritance help us eliminate redundant code (generic object with some code and we can inhirit these properties and methods)

- Summery: Eliminate redundant code  


# Polymorphism   poly(many)  mor (form)  - many forms 
- is a thechique that allows you to get rid of long evel -if()else()/ swith()case:  statements
- Refactor ugly switch/case - make a methods for it 
