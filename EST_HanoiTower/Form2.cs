using EST_HanoiTower.Structures.Trees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EST_HanoiTower
{
    public partial class Form2 : Form
    {
        private ITree<int> tree;
        private Dictionary<NodeTree<int>, Point> positions = new Dictionary<NodeTree<int>, Point>();
        private const int LEVEL_HEIGHT = 80;
        private int? highlighted = null;

        public Form2()
        {
            InitializeComponent();
            SetDoubleBuffered(Panel_Tree);
            ClearLabels();

            cmb_Tree_Type.Items.Add("BST");
            cmb_Tree_Type.Items.Add("AVL");
            cmb_Tree_Type.SelectedIndex = 0;

            CreateTree();
        }

        private void ClearLabels()
        {
            txtb_Insert.Text = string.Empty;
            txt_Order_Current.Text = string.Empty;
            txt_Info_Current.Text = string.Empty;
            lbl_Result.Text = string.Empty;
        }

        private void CreateTree()
        {
            string selected = cmb_Tree_Type.SelectedItem.ToString();

            if (selected == "BST")
            {
                tree = new BinaryTree<int>();
            }
            else
            {
                tree = new AVLTree<int>();
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            highlighted = null;
            int value;

            bool valid = int.TryParse(txtb_Insert.Text, out value);

            if (!valid)
            {
                MessageBox.Show("Ingrese un número válido");
                return;
            }

            tree.Insert(value);

            ClearLabels();
            Panel_Tree.Invalidate();
        }

        private void Panel_Tree_Paint(object sender, PaintEventArgs e)
        {
            if (tree == null || tree.GetRoot() == null)
            {
                return;
            }

            positions.Clear();

            int counter = 0;

            AssignPositions(
                tree.GetRoot(),
                ref counter,
                50,
                70,
                50,
                0);

            DrawEdges(e.Graphics, tree.GetRoot());

            DrawNodes(e.Graphics, tree.GetRoot());
        }

        private void DrawEdges(Graphics g, NodeTree<int> node)
        {
            if (node == null)
            {
                return;
            }

            Point p = positions[node];

            if (node.left != null)
            {
                Point pL = positions[node.left];

                g.DrawLine(Pens.Black,
                           p.X,
                           p.Y,
                           pL.X,
                           pL.Y);

                DrawEdges(g, node.left);
            }

            if (node.right != null)
            {
                Point pR = positions[node.right];

                g.DrawLine(Pens.Black,
                           p.X,
                           p.Y,
                           pR.X,
                           pR.Y);

                DrawEdges(g, node.right);
            }
        }

        private void DrawNodes(Graphics g, NodeTree<int> node)
        {
            if (node == null)
            {
                return;
            }

            Point p = positions[node];

            int radius = 20;

            Rectangle rect = new Rectangle(
                p.X - radius,
                p.Y - radius,
                radius * 2,
                radius * 2);

            g.FillEllipse(Brushes.SteelBlue, rect);

            g.DrawEllipse(Pens.Black, rect);

            string text = node.Value.ToString();

            SizeF sz = g.MeasureString(text, Font);

            g.DrawString(
                text,
                Font,
                Brushes.White,
                p.X - sz.Width / 2,
                p.Y - sz.Height / 2);

            DrawNodes(g, node.left);

            DrawNodes(g, node.right);
        }

        private void cmb_Tree_Type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClearLabels();
            CreateTree();
            Panel_Tree.Invalidate();
        }

        private void btn_PreOrder_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txt_Order_Current.Text = tree.PreOrder();
        }

        private void btn_InOrder_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txt_Order_Current.Text = tree.InOrder();
        }

        private void btn_PostOrder_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txt_Order_Current.Text = tree.PostOrder();
        }

        private void btn_LevelOrder_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txt_Order_Current.Text = tree.LevelOrder();
        }

        private void btn_Height_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txt_Info_Current.Text = tree.Height().ToString();
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txt_Info_Current.Text = tree.Max().ToString();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txt_Info_Current.Text = tree.Min().ToString();

        }

        private void btn_Count_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txt_Info_Current.Text = tree.Count().ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

            highlighted = null;
            try
            {
                int value = int.Parse(txtb_Insert.Text);

                tree.remove(value);

                Panel_Tree.Invalidate();
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar");
            }

            ClearLabels();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearLabels();
            tree.Clear();
            CreateTree();
            Panel_Tree.Invalidate();
        }

        private void btn_Contains_Click(object sender, EventArgs e)
        {
            int value = int.Parse(txtb_Insert.Text);

            if (tree.Contains(value))
            {
                highlighted = value;
                lbl_Result.Text = "Added Value";
            }
            else
            {
                highlighted = null;
                lbl_Result.Text = "No-Added Value";
            }

            Panel_Tree.Invalidate();
        }

        private void SetDoubleBuffered(Panel panel)
        {
            typeof(Panel).InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                panel,
                new object[] { true });
        }

        private void AssignPositions(NodeTree<int> node, ref int counter, int sideMargin,
        int spacing, int topMargin, int level)
        {
            if (node == null)
            {
                return;
            }

            AssignPositions(
                node.left,
                ref counter,
                sideMargin,
                spacing,
                topMargin,
                level + 1);

            int x = sideMargin + counter * spacing;

            int y = topMargin + level * LEVEL_HEIGHT;

            positions[node] = new Point(x, y);

            counter++;

            AssignPositions(
                node.right,
                ref counter,
                sideMargin,
                spacing,
                topMargin,
                level + 1);
        }

        private void btn_Classification_Click(object sender, EventArgs e)
        {
            lbl_Result.Text = tree.Classification();
        }
    }
}
