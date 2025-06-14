# 610. Triangle Judgement

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/database-blue)

[610. Triangle Judgement](https://leetcode.com/problems/triangle-judgement/description/?envType=study-plan-v2&envId=top-sql-50)

```
Table: Triangle

+-------------+------+
| Column Name | Type |
+-------------+------+
| x           | int  |
| y           | int  |
| z           | int  |
+-------------+------+
In SQL, (x, y, z) is the primary key column for this table.
Each row of this table contains the lengths of three line segments.
 

Report for every three line segments whether they can form a triangle.

Return the result table in any order.

The result format is in the following example.
```

```Example 1:

Input: 
Triangle table:
+----+----+----+
| x  | y  | z  |
+----+----+----+
| 13 | 15 | 30 |
| 10 | 20 | 15 |
+----+----+----+
Output: 
+----+----+----+----------+
| x  | y  | z  | triangle |
+----+----+----+----------+
| 13 | 15 | 30 | No       |
| 10 | 20 | 15 | Yes      |
+----+----+----+----------+
```

## Code

```tsql
select
    x,
    y,
    z,
    case
        when x + y > z and x + z > y and y + z > x then 'Yes'
        else 'No'
        end [triangle]
from
    Triangle

```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)