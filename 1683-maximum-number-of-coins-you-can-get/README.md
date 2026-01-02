<h2><a href="https://leetcode.com/problems/maximum-number-of-coins-you-can-get">Maximum Number of Coins You Can Get</a></h2> <img src='https://img.shields.io/badge/Difficulty-Medium-orange' alt='Difficulty: Medium' /><hr><p>There are <code>3n</code> piles of coins of varying size, you and your friends will take piles of coins as follows:</p>

> **每日發一題 LeetCode 練習，直到我找到後端工程師工作 Day 10 (1/2)** >
> 第十天，複習我之前寫過的題目。

## 題目
題目：1561. Maximum Number of Coins You Can Get
給定一個Array，每個數字代表一個金額，三個人依序拿錢，A會拿最多金額的錢，而C會拿最少金額，最後要回傳我所能拿到的最大金額。


## 思路
這是一提Greedy題目，為了確保我拿的錢最第二多，首先先對Array進行排並反轉，確保Array變成從大到小排序，所以進行 for loop 從 i = 1開始拿錢，每次跳過A達的最大值的錢，拿到 Array的總數 - C會拿到的位置。

## 實作
1.Array.Sort() + Array.Reverse()讓Array從大到小排，
2.建立一個int sum (紀錄答案)， int n (等於C會拿的數量)
3.for loop i 從 1 開始，每次跳兩格 i = i + 2
4.終止條件式 Array.Length - n

## 複雜度分析
時間複雜度O(NlogN)，排序Array後，跑過一遍Array。<br>
空間複雜度O(1)，只記錄我們要的答案而已。

## 原文題目
<ul>
	<li>In each step, you will choose <strong>any </strong><code>3</code> piles of coins (not necessarily consecutive).</li>
	<li>Of your choice, Alice will pick the pile with the maximum number of coins.</li>
	<li>You will pick the next pile with the maximum number of coins.</li>
	<li>Your friend Bob will pick the last pile.</li>
	<li>Repeat until there are no more piles of coins.</li>
</ul>

<p>Given an array of integers <code>piles</code> where <code>piles[i]</code> is the number of coins in the <code>i<sup>th</sup></code> pile.</p>

<p>Return the maximum number of coins that you can have.</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<pre>
<strong>Input:</strong> piles = [2,4,1,2,7,8]
<strong>Output:</strong> 9
<strong>Explanation: </strong>Choose the triplet (2, 7, 8), Alice Pick the pile with 8 coins, you the pile with <strong>7</strong> coins and Bob the last one.
Choose the triplet (1, 2, 4), Alice Pick the pile with 4 coins, you the pile with <strong>2</strong> coins and Bob the last one.
The maximum number of coins which you can have are: 7 + 2 = 9.
On the other hand if we choose this arrangement (1, <strong>2</strong>, 8), (2, <strong>4</strong>, 7) you only get 2 + 4 = 6 coins which is not optimal.
</pre>

<p><strong class="example">Example 2:</strong></p>

<pre>
<strong>Input:</strong> piles = [2,4,5]
<strong>Output:</strong> 4
</pre>

<p><strong class="example">Example 3:</strong></p>

<pre>
<strong>Input:</strong> piles = [9,8,7,6,5,1,2,3,4]
<strong>Output:</strong> 18
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>3 &lt;= piles.length &lt;= 10<sup>5</sup></code></li>
	<li><code>piles.length % 3 == 0</code></li>
	<li><code>1 &lt;= piles[i] &lt;= 10<sup>4</sup></code></li>
</ul>
