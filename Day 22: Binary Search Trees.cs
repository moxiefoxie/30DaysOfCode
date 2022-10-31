using System;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

	static int getHeight(Node root){
      //Write your code here
      if (root == null)
        //because we add +1 at the end, we must have -1 to balance the final node
        return -1;
    else {
        /* compute the depth of each subtree */
        int lDepth = getHeight(root.left);
        int rDepth = getHeight(root.right);
 
        /* use the larger one */
        if (lDepth > rDepth)
            return (lDepth+1);
        else
            return (rDepth+1);
    }
    }

	static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        int height=getHeight(root);
        Console.WriteLine(height);
        
    }
}
