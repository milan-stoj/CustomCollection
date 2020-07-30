# LiteList
A lightweight *list-like* class written for C#.


## Features
* Add/Remove items
* Index/Itterate through items
* Zip lists together
* Sort (Using [Bubble Sort](https://en.wikipedia.org/wiki/Bubble_sort))

## Usage
**Instantiating a LiteList:**
```csharp
LiteList</*type*/> list = new LiteList</*type*/>();  
// or
LiteList</*type*/> newList = new LiteList</*type*/>() {/*thing*/, /*thing*/, /*thing*/}
```

**Adding Items to a LiteList**
```csharp
list.Add(/*item*/);     // Adds item to next index
```

**Removing Items from a LiteList**
```csharp
list.Remove(/*Target Item*/);   // Removes first instance of target item from list
```

**Zipping two LiteLists Together**
```csharp
LiteList<int> oddList = new LiteList<int>() {1, 3, 5};
LiteList<int> evenList = new LiteList<int>() {2, 4, 6};
LiteList<int> zippedList = oddList.Zip(evenList);  
// zippedList becomes a LiteList<int> containing values {1,2,3,4,5,6}
```

**Sort Items in a LiteList**
```csharp
LiteList<int> list = new LiteList<int>() {1,6,3,5,2,4};
list.sort();
// list becomes a LiteList<int> with values in ascending order {1,2,3,4,5,6}
```

**Adding Two Lists**
```csharp
LiteList<int> aList = new LiteList<int>() {3, 3, 10};
LiteList<int> bList = new LiteList<int>() {2, 4, 6};
LiteList<int> newList = aList + bList;
// list becomes a LiteList<int> with values in ascending order {5, 7, 16}
```

**Subtracting Two Lists**
```csharp
LiteList<int> aList = new LiteList<int>() {3, 3, 10};
LiteList<int> bList = new LiteList<int>() {2, 4, 6};
LiteList<int> newList = aList - bList;
// newList becomes a LiteList<int> with values {1,4}
// see "-OperatorDocumentation.txt" for more information.
```

**Viewing LiteList Properties**
```csharp
list.Count;         // Returns the count of items in the LiteList
list.Capacity;      // Returns the current capacity of the LiteList's internal array