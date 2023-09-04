// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World!");

using Logical_Programs;
/*1. Fibonacci Series
Fibonacci series is a special type of series in which the next term is the sum of the
previous two terms. For example, if 0 and 1 are the two previous terms in a series, then
the next term will be 1(0+1).*/

//Fibonacci.fibo();

/*2. Perfect Number
a. Just like the Armstrong number, the Perfect Number is also a special type of
positive number. When the number is equal to the sum of its positive divisors
excluding the number, it is called a Perfect Number. For example, 28 is the perfect
number because when we sum the divisors of 28, it will result in the same number.
The divisors of 28 are 1, 2, 4, 7, and 14. So,
b. 28 = 1+2+4+7
c. 28 = 28*/
//Perfect_Number.checkPerfectNum();

/*3. Prime Number
Just like the Perfect number, the Prime number is also a special type of number. When
the number is divided greater than 1 and divided by 1 or itself is referred to as the Prime
number. 0 and 1 are not counted as prime numbers. All the even numbers can be
divided by 2, so 2 is the only even prime minister.*/
//Prime_Number.checkPrime();

/*4. Reverse a number
In C#, we can reverse a number either by using for loop, while loop, or using recursion.
The simplest way to reverse a number is by using for loop or while loop. In order to
reverse a number, we have to follow the following steps:
a. We need to calculate the remainder of the number using the modulo
b. After that, we need to multiply the variable reverse by 10 and add the remainder into
it.
c. We then divide the number by 10 and repeat steps until the number becomes 0.*/
//Reverse_Number.CheckReverese();

/*5. Coupon Numbers
a. Desc -> Given N distinct Coupon Numbers, how many random numbers do you
need to generate a distinct coupon number? This program simulates this random
process.
b. I/P -> N Distinct Coupon Number
c. Logic -> repeatedly choose a random number and check whether it's a new one.
d. O/P -> total random number needed to have all distinct numbers.
e. Functions => Write Class Static Functions to generate random numbers and to
process distinct coupons.*/
//Coupon_Number.checkCoupon();

/*6. Simulate Stopwatch Program
a. Desc -> Write a Stopwatch Program for measuring the time that elapses between
the start and end clicks
b. I/P -> Start the Stopwatch and End the Stopwatch
c. Logic -> Measure the elapsed time between start and end
d. O/P -> Print the elapsed time.*/
StopWatch.play();
