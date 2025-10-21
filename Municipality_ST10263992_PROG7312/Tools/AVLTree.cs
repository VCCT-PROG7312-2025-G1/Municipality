using Municipality_ST10263992_PROG7312.Forms.ReportIssue;
using System;

namespace Municipality_ST10263992_PROG7312.Tools
{
    internal class AVLNode
    {
        public ServiceRequest Data;
        public AVLNode Left, Right;
        public int Height;
        public AVLNode(ServiceRequest data)
        {
            Data = data;
            Height = 1;
        }
    }

    internal class AVLTree
    {
        private AVLNode root;

        private int Height(AVLNode n) => n?.Height ?? 0;
        private int BalanceFactor(AVLNode n) => n == null ? 0 : Height(n.Left) - Height(n.Right);

        private AVLNode RightRotate(AVLNode y)
        {
            AVLNode x = y.Left;
            AVLNode T2 = x.Right;
            x.Right = y;
            y.Left = T2;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            return x;
        }

        private AVLNode LeftRotate(AVLNode x)
        {
            AVLNode y = x.Right;
            AVLNode T2 = y.Left;
            y.Left = x;
            x.Right = T2;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
            return y;
        }

        public void Insert(ServiceRequest req) => root = InsertRec(root, req);

        private AVLNode InsertRec(AVLNode node, ServiceRequest key)
        {
            if (node == null) return new AVLNode(key);

            if (key.Id < node.Data.Id)
                node.Left = InsertRec(node.Left, key);
            else if (key.Id > node.Data.Id)
                node.Right = InsertRec(node.Right, key);
            else
            {
                node.Data = key; // update if exists
                return node;
            }

            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
            int balance = BalanceFactor(node);

            // Left Left Case
            if (balance > 1 && key.Id < node.Left.Data.Id)
                return RightRotate(node);

            // Right Right Case
            if (balance < -1 && key.Id > node.Right.Data.Id)
                return LeftRotate(node);

            // Left Right Case
            if (balance > 1 && key.Id > node.Left.Data.Id)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && key.Id < node.Right.Data.Id)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }
            return node;
        }

        public void Delete(int id) => root = DeleteRec(root, id);

        private AVLNode DeleteRec(AVLNode node, int id)
        {
            if (node == null) return node;

            if (id < node.Data.Id)
                node.Left = DeleteRec(node.Left, id);
            else if (id > node.Data.Id)
                node.Right = DeleteRec(node.Right, id);
            else
            {
                if ((node.Left == null) || (node.Right == null))
                {
                    AVLNode temp = node.Left ?? node.Right;
                    if (temp == null)
                    {
                        temp = node;
                        node = null;
                    }
                    else
                        node = temp;
                }
                else
                {
                    AVLNode temp = MinValueNode(node.Right);
                    node.Data = temp.Data;
                    node.Right = DeleteRec(node.Right, temp.Data.Id);
                }
            }

            if (node == null) return node;

            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
            int balance = BalanceFactor(node);

            // Left Left Case
            if (balance > 1 && BalanceFactor(node.Left) >= 0)
                return RightRotate(node);

            // Left Right Case
            if (balance > 1 && BalanceFactor(node.Left) < 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Right Case
            if (balance < -1 && BalanceFactor(node.Right) <= 0)
                return LeftRotate(node);

            // Right Left Case
            if (balance < -1 && BalanceFactor(node.Right) > 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        private AVLNode MinValueNode(AVLNode node)
        {
            AVLNode current = node;
            while (current.Left != null)
                current = current.Left;
            return current;
        }

        public ServiceRequest Search(int id) => SearchRec(root, id)?.Data;
        private AVLNode SearchRec(AVLNode node, int id)
        {
            if (node == null || node.Data.Id == id)
                return node;

            return (id < node.Data.Id) ? SearchRec(node.Left, id) : SearchRec(node.Right, id);
        }

        public void InOrderTraversal(Action<ServiceRequest> action) => InOrderRec(root, action);
        private void InOrderRec(AVLNode node, Action<ServiceRequest> action)
        {
            if (node == null) return;
            InOrderRec(node.Left, action);
            action(node.Data);
            InOrderRec(node.Right, action);
        }
    }
}
