using System;
namespace level1.Lesson3_methods
{
    public class Example_2
    {

        class Data {
            public int MyProperty1 { get; set; }
            public int MyProperty2 { get; set; }
            public int MyProperty3 { get; set; }
            public int MyProperty4 { get; set; }

        }
        class Example {


            static Data Get() {
                return new Data() {
                        MyProperty1 = 123,
                        MyProperty2 = 12,
                        MyProperty3 =6,
                        MyProperty4 =78
                };
            }
           //  Get().MyProperty1(;

        }     
    }
}
