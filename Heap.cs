// Heap

// It's a tree data structure, where each node is smaller than or equal to its children if it's a MIN-HEAP,
// or greater than or equal to its children if it's a MAX-HEAP, depending on the type.
// Binary Heap is the most popular.
// Store heaps in an array for efficiency.

// TO FIND ELEMENTS IN THE TREE YOU CAN USED THE FOLLOWING EQUATIONS:
// Node: i
// Left child: 2i + 1
// Right child: 2i + 2
// Parent: (i - 1)/2

// There are 5 operations
// insert
    // Append: appends to the end of the tree, then use sisft-up method to update it in the right place
// get min/max
    // min: it's always at index 0 of the heap. O(1) complexity because we know the index.
// extract min/max
    // extract min: swap the root with the last leaf that has no children then apply sift down to place it in the correct place.
// update
    // We update the node and compare it to the value that was there, if the updated value is smaller than the value that was there we sift-up to place it in the correct. If it's bigger
    // we sift-down.
// build
    // You have an array and you want to heapify it. Start by the last nodes that have not children and then sift-up.

// There are 2 sift operations to reposition a node and respect the heap properties
// Sift up (Ologn)
// Sift Down (Ologn)

// Examples of Heaps
    // Priority Queue in which the elements with the highest priority are served first
    // Exmaple: https://www.youtube.com/watch?v=7z_HXFZqXqc

// Source: https://www.youtube.com/watch?v=pLIajuc31qk