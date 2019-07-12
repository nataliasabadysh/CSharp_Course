# Module Outline 

#  Customer Management System

1) Management  - class 
- customer's name 
- email
- address
+ method  :  Validation() Retrieve() Save()

2) Products  - class 
- products's name 
- description
- current price 
+ method  :  Validation() Retrieve() Save()

3) Handle Orderes - class 
- Customers
- Order date 
- Shipping address
+ method  :  Validation() Retrieve() Save()

4)  Order  Item  - class 
- Products 
- Quantities ordered
+ method  :  Validation() Retrieve() Save()

# Consider the effect of data changes over time 
-  Customer home address -> shipping address ->  ..
-  Product Item          -> Product name, price  , descriptions 

4)  Order  Item  - class 
- Products 
- Quantities ordered
- Purchase price  <----  for tracking , regardenless of chenges to the product data 


# Abstraction  
- simplifying reality
- ignoring extraneous details 
- focusing on what is important for a purpose 

Customers -> manage business, residentials, gaverment

we need : 
- name of customer 
- adress of customer 
- email 


# Encapsulatios  ( encapsulation units are classes )
- way to think 
- way to hide details within a class , hides both the data and implementation 
- data hiding has many benefits 
- Protects the data
- Allows for authorization before getting (or setting )the data  
- No other code can modify the underlying data exept through the get; set; -ers;
- Helps manage complexity
- Easier to test 
- no other code can just jump into this code, and no other app needs to know about these detailes 
- allows  Objects and app work together without each obj knowing the details of other object's implementations 


if UI wants to access the property such as the name, it must call {get; set;} in the Customer Class 
<p> Example</p>

- var name = customer.Name; 
- customer.Retrieve();            - methodin the  class 

### Layering the Application

- User intarface layer UI
- Business logic layer  
- Data access layer   
- Common code 


# Building the bisiness logic component

-  public accessibility to the class
-  each class we define  is  a  type   

```
public class Customer  {   }
```

-  + Proporties for the Customer class 

```
public class Customer  {   }
```

```
public Customer()
         {

            public string LastName { get; set; }
            public string FirstName { get; set; }
            public int EmailAddress { get; set; }
            public int CustomID { get; set; }

            public string FullName  {
                 get {return LastName + ", " + FirstName };
                // set we don't need, we are not going to change the value 
            }
    
         }
```

```Example : test for the class 
    [TestClass]
    public class CustomerUnitTest
    {
        [TestMethod]

        public void FullNameTestValid()
        {
            // Arrange - instans 
            Customer customer = new Customer();
            customer.FirstName = "Chris";
            customer.LastName = "Joh";

            // or Arrange instans 
            Customer customer = new Customer
            {
                FirstName = "Chris",
                LastName = "Joh"
            };

            // Act 

            string expected = "Chis Joh";
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
```

#  Creating a New Objects 

1)  Customer customer = new Customer();


 - new instans from the Cuntomer class , type of var "Customer" is the type og creatve obj  = new Customer();
 - customer  is Object variable

 2) var customer = new Customer();
 -  here we are obviously creating an object of type customer 


 ```
    var customer = new Customer();

    customer.FirstName = "Chris";
    customer.LastName = "Joh";

    var actual = customer.FullName;
 ```

# Objects are Reference Types  

```
    int i1; 
    i1 = 42;            // i1 = 42
    int i2 = i1;        // i2 = 42
    i2 = 2;             // i2 = 2
```

```
    var c1 = new Customer();
    c1.FirstName = "Bilbo";

    var c2 = c1;
    c2.FirstName = "Frodo";    // c1 = Frodo  && c2 = Frodo
```

# Static Modifier 

```



```
