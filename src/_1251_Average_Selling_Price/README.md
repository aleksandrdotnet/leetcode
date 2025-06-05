# 1193. Monthly Transactions I

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/database-blue)

[1193. Monthly Transactions I](https://leetcode.com/problems/average-selling-price/description/)

```
Table: Transactions

+---------------+---------+
| Column Name   | Type    |
+---------------+---------+
| id            | int     |
| country       | varchar |
| state         | enum    |
| amount        | int     |
| trans_date    | date    |
+---------------+---------+
id is the primary key of this table.
The table has information about incoming transactions.
The state column is an enum of type ["approved", "declined"].
 

Write an SQL query to find for each month and country, the number of transactions and their total amount, the number of approved transactions and their total amount.

Return the result table in any order.

The query result format is in the following example.
```

## Example 1

```
Example 1:

Input: 
Transactions table:
+------+---------+----------+--------+------------+
| id   | country | state    | amount | trans_date |
+------+---------+----------+--------+------------+
| 121  | US      | approved | 1000   | 2018-12-18 |
| 122  | US      | declined | 2000   | 2018-12-19 |
| 123  | US      | approved | 2000   | 2019-01-01 |
| 124  | DE      | approved | 2000   | 2019-01-07 |
+------+---------+----------+--------+------------+
Output: 
+----------+---------+-------------+----------------+--------------------+-----------------------+
| month    | country | trans_count | approved_count | trans_total_amount | approved_total_amount |
+----------+---------+-------------+----------------+--------------------+-----------------------+
| 2018-12  | US      | 2           | 1              | 3000               | 1000                  |
| 2019-01  | US      | 1           | 1              | 2000               | 2000                  |
| 2019-01  | DE      | 1           | 1              | 2000               | 2000                  |
+----------+---------+-------------+----------------+--------------------+-----------------------+
```

## Code

```tsql
/* Write your T-SQL query statement below */
select
    FORMAT(t1.trans_date, 'yyyy-MM') [month],
    t1.country,
    count(1) [trans_count],
    sum(iif(t1.state = 'approved', 1, 0)) [approved_count],
    sum(ISNULL(t1.amount, 0)) [trans_total_amount],
    sum(iif(t1.state = 'approved', ISNULL(t1.amount, 0), 0)) [approved_total_amount]
from
    Transactions t1
group by
    FORMAT(t1.trans_date, 'yyyy-MM'), t1.country
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)