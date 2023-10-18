# Instructions

You're an avid bird watcher that keeps track of how many birds have visited your garden in the last seven days.

You have six tasks, all dealing with the numbers of birds that visited your garden.

## 1. Check what the counts were last week

For comparison purposes, you always keep a copy of last week's counts nearby, which were: 0, 2, 5, 3, 7, 8 and 4. Implement the (_static_) `BirdCount.LastWeek()` method that returns last week's counts:

```csharp
BirdCount.LastWeek();
// => [0, 2, 5, 3, 7, 8, 4]
```

## 2. Check how many birds visited today

Implement the `BirdCount.Today()` method to return how many birds visited your garden today. The bird counts are ordered by day, with the first element being the count of the oldest day, and the last element being today's count.

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.Today();
// => 1
```

## 3. Increment today's count

Implement the `BirdCount.IncrementDayCount()` method to increment today's count:

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.IncrementDayCount();
birdCount.Today();
// => 2
```

## 4. Check if there was a day with no visiting birds

Implement the `BirdCount.HasDayWithoutBirds()` method that returns `true` if there was a day at which zero birds visited the garden; otherwise, return `false`:

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.HasDayWithoutBirds();
// => true
```

## 5. Calculate the number of visiting birds for the first number of days

Implement the `BirdCount.CountForFirstDays()` method that returns the number of birds that have visited your garden from the start of the week, but limit the count to the specified number of days from the start of the week.

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.CountForFirstDays(4);
// => 14
```

## 6. Calculate the number of busy days

Some days are busier that others. A busy day is one where five or more birds have visited your garden.
Implement the `BirdCount.BusyDays()` method to return the number of busy days:

```csharp
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.BusyDays();
// => 2
```

# Hints

## General

- The bird count per day is stored in a [field][fields] named `birdsPerDay`.
- The bird count per day is an array that contains exactly 7 integers.

## 1. Check what the counts were last week

- As this method does _not_ depend on the current week's count, it is defined as a [`static` method][static-members].
- There are [several ways to define an array][single-dimensional-arrays].

## 2. Check how many birds visited today

- Remember that the counts are ordered by day from oldest to most recent, with the last element representing today.
- Accessing the last element can be done either by using its (fixed) index (remember to start counting from zero) or by calculating its index using the [array's size][array-length].

## 3. Increment today's count

- Set the element representing today's count to today's count plus 1.

## 4. Check if there was a day with no visiting birds

- The `Array` class has a [built-in method][array-indexof] that returns the first index where the element is found, or -1 if no matching element was found.

## 5. Calculate the number of visiting birds for the first number of days

- A variable can be used to hold the count for the number of visiting birds.
- The array can be iterated over using a [`for` loop][for-statement].
- The variable can be updated inside the loop.
- Remember: arrays are indexed from `0`.

## 6. Calculate the number of busy days

- A variable can be used to hold the number of busy days.
- The array can be iterated over using a [`foreach` loop][array-foreach].
- The variable can be updated inside the loop.
- A [conditional statement][if-statement] can be used inside the loop.

[array-foreach]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/using-foreach-with-arrays
[single-dimensional-arrays]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays
[fields]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields
[static-members]: https://www.oreilly.com/library/view/programming-c/0596001177/ch04s03.html
[array-indexof]: https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=netcore-3.1#System_Array_IndexOf_System_Array_System_Object_
[if-statement]: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
[array-length]: https://docs.microsoft.com/en-us/dotnet/api/system.array.length?view=netcore-3.1
[for-statement]: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for