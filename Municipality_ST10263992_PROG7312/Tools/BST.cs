using Municipality_ST10263992_PROG7312.Forms.ReportIssue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_ST10263992_PROG7312.Tools
{
    /// <summary>
    /// Represents a node in a Binary Search Tree.
    /// </summary>
    internal class BSTNode
    {
        public ServiceRequest Data;
        public BSTNode Left;
        public BSTNode Right;

        public BSTNode(ServiceRequest data)
        {
            Data = data;
            Left = Right = null;
        }
    }

    /// <summary>
    /// A Binary Search Tree for storing and retrieving ServiceRequest objects by their ID.
    /// </summary>
    internal class BinarySearchTree
    {
        private BSTNode root;

        /// <summary>
        /// Inserts a new ServiceRequest into the tree. If a request with the same ID exists, it is updated.
        /// </summary>
        public void Insert(ServiceRequest req)
        {
            root = InsertRec(root, req);
        }

        private BSTNode InsertRec(BSTNode node, ServiceRequest req)
        {
            if (node == null) return new BSTNode(req);

            if (req.Id < node.Data.Id)
            {
                node.Left = InsertRec(node.Left, req);
            }
            else if (req.Id > node.Data.Id)
            {
                node.Right = InsertRec(node.Right, req);
            }
            else
            {
                // Update existing request if ID is a duplicate
                node.Data = req;
            }
            return node;
        }

        /// <summary>
        /// Searches for a ServiceRequest by its ID.
        /// </summary>
        /// <returns>The found ServiceRequest or null if not found.</returns>
        public ServiceRequest Search(int id)
        {
            var node = SearchRec(root, id);
            return node?.Data;
        }

        private BSTNode SearchRec(BSTNode node, int id)
        {
            if (node == null) return null;
            if (id == node.Data.Id) return node;
            return id < node.Data.Id ? SearchRec(node.Left, id) : SearchRec(node.Right, id);
        }

        /// <summary>
        /// Performs an in-order traversal of the tree, executing an action on each node.
        /// Traversal is in ascending order of ServiceRequest ID.
        /// </summary>
        public void InOrderTraversal(Action<ServiceRequest> action)
        {
            InOrderRec(root, action);
        }

        private void InOrderRec(BSTNode node, Action<ServiceRequest> action)
        {
            if (node == null) return;
            InOrderRec(node.Left, action);
            action(node.Data);
            InOrderRec(node.Right, action);
        }

        /// <summary>
        /// Deletes a ServiceRequest from the tree by its ID.
        /// </summary>
        public void Delete(int id)
        {
            root = DeleteRec(root, id);
        }

        private BSTNode DeleteRec(BSTNode node, int id)
        {
            if (node == null) return node;

            if (id < node.Data.Id)
                node.Left = DeleteRec(node.Left, id);
            else if (id > node.Data.Id)
                node.Right = DeleteRec(node.Right, id);
            else
            {
                // Node with only one child or no child
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                // Node with two children: Get the inorder successor (smallest in the right subtree)
                node.Data = MinValue(node.Right);

                // Delete the inorder successor
                node.Right = DeleteRec(node.Right, node.Data.Id);
            }
            return node;
        }

        private ServiceRequest MinValue(BSTNode node)
        {
            ServiceRequest minv = node.Data;
            while (node.Left != null)
            {
                minv = node.Left.Data;
                node = node.Left;
            }
            return minv;
        }
    }
}
