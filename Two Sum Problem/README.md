# Two Sum

## 🎯 Problem Description

Given an array of integers `nums` and an integer `target`, the goal is to find and return the **indices** of the two numbers in the array that add up to the `target`.

You are guaranteed that:
1. Each input will have **exactly one solution**.
2. You may **not use the same element twice**.

The answer can be returned in any order.

---

## ⚙️ Constraints

* `2 <= nums.length <= 10^4`
* `-10^9 <= nums[i] <= 10^9`
* `-10^9 <= target <= 10^9`
* **Only one valid answer exists.**

---

## 💡 Solution Approaches

### 1. Brute Force (Implemented in the Provided Code)

This is the most straightforward solution, involving checking every possible pair of numbers in the array.

#### Implementation Logic
Use two nested loops. The outer loop selects the first number, and the inner loop iterates over the remaining numbers to find the complement.

#### Complexity Analysis
| Metric | Complexity |
| :--- | :--- |
| **Time Complexity** | $O(n^2)$ |
| **Space Complexity** | $O(1)$ |