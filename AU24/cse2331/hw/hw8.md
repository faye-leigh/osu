# Homework 8

## Question 1

The height of the tree can be reduced by up to half. \
The maximum number of children of any node can be 4.

## Question 2

min nodes: \
$2^{(h_b - 1) +1} - 1 = 2^{h_b} - 1$ \
max nodes: \
$2^{(2h_b - 1) + 1} - 1 = 4^{h_b} - 1$

## Question 3

1. 
```
  1B
```
1. 
```
  1B
    \
    2R
```
1. 
```
  1B \
    \ \
    2R \ CASE IV
      \ \
      3R \

  2B
 /  \
1R  3R
```
4. 
```
  2B
 /  \
1R  3R
      \
      4R

   2 B
  /   \
1 B   3 B
         \
         4 R
```
5. 
```
  2B
 /  \
1B  3B \
      \ \
      4R \ CASE III
        \ \
        5R \

  2B
 /  \
1B  4B
   /  \
  3R  5R
```
6. 
```
  2B
 /  \
1B  4B
   /  \
  3R  5R
        \
        6R

  2B
 /  \
1B  4R
   /  \
  3B  5B
        \
        6R
```
7. 
```
  2B
 /  \
1B  4R
   /  \
  3B  5B \
        \ \
        6R \ 
          \ \
          7R \

  2B
 /  \
1B  4R
   /  \
  3B  6B 
     /  \ 
    5R  7R 
```
8. 
```
  2B
 /  \
1B  4R
   /  \
  3B  6B 
     /  \ 
    5R  7R 
          \
          8R

  2B
 /  \
1B  4R
   /  \
  3B  6R 
     /  \ 
    5B  7B 
          \
          8R

     4R
   /     \
  2B     6R
 /  \   /  \
1B  3B 5B  7B 
             \ 
             8R 

     4B
   /     \
  2R     6R
 /  \   /  \
1B  3B 5B  7B 
             \ 
             8R 

BST
1B
  \
  2B
    \
    3B
      \
      4B
        \
        5B
          \
          6B
            \
            7B
              \
              8B
```

## Question 4

For any cycle in $G$ let $e$ denote its max weight edge. If $T$ uses $e_M$ then $e$ can be swapped with any cycle-edge and the tree will remain connected. So $e$ can be swapped for a cheaper tree so $T$ does not use $e$. Thus $T$ is a minimum spanning tree of $G$. 

## Question 5

Consider graph $U, V(G) - U$. \
Assume many possible MSTs and fix one, $T$. An edge of $T$ must cross a cut or the
graph is disconnected. Since $T$ spans $V(G)$ it spans $U$ and $V(G) - U$.
Every node on both sides of the cut is in the tree. Any edge crossing the cut results in a spanning tree. If any edge other than the minimum is selected the tree will not have minimal cost, since its cost could be reduced by using this edge.There is a unique choice of edge $T$ across any cut. 

## Question 6

No. \
Suppose the shortest path from $s$ to $t$ contains a cycle. Then some vertex $v$ appears at least twice from $s$ to $t$. Deleting a portion of the walk which loops back to v decreases the length since the graph has positive edge weights.

## Question 7

```
          ----- 4 -----
         /             \
        E - 3 - A - 2 - B
        |       |\     /
        5       | 5   3
        |       |  \ /
H - 1 - F       4   C
 \     /        |  /
  3   2         | 6
   \ /          |/
    G --- 1 --- D
```
