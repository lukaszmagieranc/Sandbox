using System;

namespace Problems
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class ReverseMirrorBinaryTree
    {
        public static void Solution()
        {

        }

        private static void swapChildren(TreeNode root)
        {
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
        }

        // public TreeNode InvertTreeRecursive(TreeNode root) {
        //     if (root != null) {
        //         // Swap children
        //         swapChildren(root);    
        //         // Invert Tree for Left node
        //         InvertTree(root.left);
        //         // Invert Tree for Right node
        //         InvertTree(root.right);
        //     }

        //     return root;
        // }

        // iterative solution

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root != null)
            {
                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                TreeNode firstNodeFromTheQueue;
                while (queue.TryDequeue(out firstNodeFromTheQueue))
                {
                    swapChildren(firstNodeFromTheQueue);
                    if (firstNodeFromTheQueue.left != null) queue.Enqueue(firstNodeFromTheQueue.left);
                    if (firstNodeFromTheQueue.right != null) queue.Enqueue(firstNodeFromTheQueue.right);
                }
            }

            return root;
        }


        /* ======= Complexity explained

        */
    }
}